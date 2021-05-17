using MyMediaPlayer.Abstractions;
using MyMediaPlayer.Core.Commands;
using MyMediaPlayer.Core.MediaFormats;
using MyMediaPlayer.Models;
using System;
using System.Collections.Generic;

namespace MyMediaPlayer.Core
{
    public class MediaPlayer
    {
        private List<ICommand> _commands = new List<ICommand>() { };
        public RequestModel RequestModel { get; private set; }

        public MediaPlayer(string fileAddress, string filtersToApply = "", string actionToPerform = "Play")
        {
            //Validate the input and throw appropriate exception, if invalid.

            RequestModel = ConvertToRequestModel(fileAddress, filtersToApply, actionToPerform);
        }

        private RequestModel ConvertToRequestModel(string fileAddress, string filtersToApply, string actionToPerform)
        {
            return new RequestModel
            {
                FileAddress = fileAddress,
                FiltersToApply = filtersToApply,
                ActionToPerform = (ActionToPerform)Enum.Parse(typeof(ActionToPerform), actionToPerform)
            };
        }

        public void Run()
        {
            IMediaFormatProvider mediaFormat = DetermineMediaFormat(RequestModel);

            List<IMediaFilterProvider> filters = GetFilters(RequestModel);

            switch (RequestModel.ActionToPerform)
            {
                case ActionToPerform.Play:
                    ICommand playCommand = new Play(mediaFormat, filters);
                    _commands.Add(playCommand);
                    playCommand.Execute(RequestModel);
                    break;
                case ActionToPerform.Decompress:
                    ICommand deCompressCommand = new Decompress(mediaFormat);
                    _commands.Add(deCompressCommand);
                    deCompressCommand.Execute(RequestModel);
                    break;
                default:
                    throw new ArgumentException("This function is not yet supported by MyMediaPlayer.");
            }
        }

        private List<IMediaFilterProvider> GetFilters(RequestModel requestModel)
        {
            var filters = new List<IMediaFilterProvider>();
            if (string.IsNullOrWhiteSpace(requestModel.FiltersToApply))
            {
                return filters;
            }

            //Logic to get the list filters to apply from the request.
            //Assuming that multiple filters can be applied simultaneously
            //and the input string (requestModel.FiltersToApply) contains those filters as comma separated values.
            //We can create list of different IMediaFilterProvider instances. e.g. ExtraBassProvider.
            // We can use reflection here to identify the list of
            // To map the filter name with Filter object we can use the filters collections in BaseMediaFilter.
            // This way we don't need to modify this code, for new filters.
            return filters; //This is a placeholder so that this method builds successfully.
        }

        private IMediaFormatProvider DetermineMediaFormat(RequestModel requestModel)
        {
            //Logic to determine the media format to use based on the request.
            return new MP3MediaFormatProvider();//This is just a placeholder so that this method builds successfully.
        }
    }
}
