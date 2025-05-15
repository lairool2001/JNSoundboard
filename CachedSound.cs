using NAudio.Wave;
using System;
using System.IO;
using System.IO.MemoryMappedFiles;

public class CachedSound
{
    public WaveFormat WaveFormat { get; private set; }
    private readonly string _memoryMappedFileName;
    public long sampleCount { private set; get; }
    public MemoryMappedViewAccessor accessor { private set; get; }
    public CachedSound(string audioFileName)
    {
        using (var audioFileReader = new AudioFileReader(audioFileName))
        {
            WaveFormat = audioFileReader.WaveFormat;
            sampleCount = audioFileReader.Length / sizeof(float);
            _memoryMappedFileName = $"Audio_{Guid.NewGuid()}"; // 唯一檔案名
            long size = audioFileReader.Length * WaveFormat.Channels;
            int bufferSize = WaveFormat.SampleRate * WaveFormat.Channels * 10; // 每秒樣本數
            float[] readBuffer = new float[bufferSize];
            // 使用 MemoryMappedFile 儲存數據
            using (var memory = MemoryMappedFile.CreateNew(_memoryMappedFileName, size))
            {
                accessor = memory.CreateViewAccessor(0, size);
                long offset = 0;
                int samplesRead;

                while ((samplesRead = audioFileReader.Read(readBuffer, 0, bufferSize)) > 0)
                {
                    accessor.WriteArray(offset, readBuffer, 0, samplesRead);
                    offset += samplesRead*sizeof(float);
                }
            }
        }
    }

    // 讀取指定範圍的樣本
    public float[] GetSamples(long startSample, int count)
    {
        if (startSample < 0 || startSample + count > sampleCount)
            throw new ArgumentOutOfRangeException("Invalid sample range.");

        using (var mmf = MemoryMappedFile.OpenExisting(_memoryMappedFileName))
        using (var accessor = mmf.CreateViewAccessor(startSample * sizeof(float), count * sizeof(float)))
        {
            float[] samples = new float[count];
            accessor.ReadArray(0, samples, 0, count);
            return samples;
        }
    }

    // 清理 MemoryMappedFile（需在不再需要時手動調用）
    public void Dispose()
    {
        try
        {
            using (var mmf = MemoryMappedFile.OpenExisting(_memoryMappedFileName))
            {
                // MemoryMappedFile 會在關閉後自動清理
            }
        }
        catch (FileNotFoundException)
        {
            // 已清理，無需處理
        }
    }
}