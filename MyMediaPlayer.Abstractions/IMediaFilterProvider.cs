namespace MyMediaPlayer.Abstractions
{
    /// <summary>
    /// In order to support multiple filters, each filter needs to implement this interface.
    /// </summary>
    public interface IMediaFilterProvider
    {
        void AddFilter();
        void ApplyFilter();
    }
}
