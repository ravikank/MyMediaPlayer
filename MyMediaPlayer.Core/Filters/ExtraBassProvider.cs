using MyMediaPlayer.Abstractions;

namespace MyMediaPlayer.Core.Filters
{
    public class ExtraBassProvider : BaseFilterProvider, IMediaFilterProvider
    {
        private const string extraBaseKey = "ExtraBass";

        public ExtraBassProvider() : base(extraBaseKey)
        {
        }

        public void AddFilter()
        {
            base.AddFilter(this);
        }

        public void ApplyFilter()
        {
            //Logic to apply extra base.
        }
    }
}
