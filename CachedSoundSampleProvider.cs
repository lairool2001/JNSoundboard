using System;
using System.IO.MemoryMappedFiles;
using NAudio.Wave;

namespace JNSoundboard
{
    class CachedSoundSampleProvider : ISampleProvider
    {
        private readonly CachedSound cachedSound;
        private long position;

        public CachedSoundSampleProvider(CachedSound cachedSound)
        {
            this.cachedSound = cachedSound;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            // 計算可用樣本數
            long availableSamples = cachedSound.sampleCount - position;
            long samplesToCopy = Math.Min(availableSamples, count);

            if (samplesToCopy <= 0)
                return 0;

            cachedSound.accessor.ReadArray(position*sizeof(float), buffer, offset, (int)samplesToCopy);

            position += samplesToCopy;
            return (int)samplesToCopy;
        }

        public WaveFormat WaveFormat { get { return cachedSound.WaveFormat; } }
    }
}
