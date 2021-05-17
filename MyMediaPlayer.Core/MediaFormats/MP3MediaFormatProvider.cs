using MyMediaPlayer.Abstractions;
using System.Collections.Generic;

namespace MyMediaPlayer.Core.MediaFormats
{
    public class MP3MediaFormatProvider : IMediaFormatProvider
    {
        public void Decompress()
        {
            //Logic to decompress MP3 media file.
        }

        public void Play(List<IMediaFilterProvider> filters)
        {
            //Logic to play MP3 media file and apply the filters if any.
            //foreach filter in filters, filter.ApplyFilter();
        }
    }
}
