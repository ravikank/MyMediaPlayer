using System;
using System.ComponentModel;

namespace MyMediaPlayer.Models
{
    public class RequestModel
    {
        public RequestModel()
        {
            IsWebAddress = Uri.IsWellFormedUriString(FileAddress, UriKind.RelativeOrAbsolute);
        }
        public string FileAddress { get; set; }
        public bool IsWebAddress { get; } = false;
        public string FiltersToApply { get; set; }
        public ActionToPerform ActionToPerform { get; set; } = ActionToPerform.Play;
    }

    public enum ActionToPerform
    {
        [Description("Play")]
        Play = 1,
        [Description("Decompress")]
        Decompress
    }
}
