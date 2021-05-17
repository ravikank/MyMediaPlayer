using System.Collections.Generic;

namespace MyMediaPlayer.Abstractions
{
    /// <summary>
    /// In order to support multiple media formats, each media format should implement this interface.
    /// </summary>
    public interface IMediaFormatProvider
    {
        public void Play(List<IMediaFilterProvider> filters);
        public void Decompress();
    }
}
