using MyMediaPlayer.Abstractions;
using MyMediaPlayer.Models;
using System;

namespace MyMediaPlayer.Core.Commands
{
    public class Decompress : ICommand
    {
        private readonly IMediaFormatProvider _mediaFormat;

        public Decompress(IMediaFormatProvider mediaFormat)
        {
            _mediaFormat = mediaFormat ?? throw new ArgumentNullException("Media Format cannot be NULL.");
        }

        public void Execute(RequestModel request)
        {
            _mediaFormat.Decompress();
        }
    }
}
