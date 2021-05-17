using MyMediaPlayer.Abstractions;
using System.Collections.Generic;

namespace MyMediaPlayer.Core.MediaFormats
{
    public class FLACMediaFormatProvider : IMediaFormatProvider
    {
        public void Decompress()
        {
            //Logic to decompress FLAC media file.
        }

        public void Play(List<IMediaFilterProvider> filters)
        {
            //Logic to play FLAC media file and apply the filters if any.
            //foreach filter in filters, filter.ApplyFilter();
        }
    }
}
