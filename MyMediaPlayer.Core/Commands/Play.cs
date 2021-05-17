using MyMediaPlayer.Abstractions;
using MyMediaPlayer.Models;
using System;
using System.Collections.Generic;

namespace MyMediaPlayer.Core.Commands
{
    public class Play : ICommand
    {
        private readonly IMediaFormatProvider _mediaFormat;
        private readonly List<IMediaFilterProvider> _filters;

        public Play(IMediaFormatProvider mediaFormat, List<IMediaFilterProvider> filters)
        {
            _mediaFormat = mediaFormat ?? throw new ArgumentNullException("Media Format cannot be NULL.");
            _filters = filters;
        }

        public void Execute(RequestModel request)
        {
            _mediaFormat.Play(_filters);
        }
    }
}
