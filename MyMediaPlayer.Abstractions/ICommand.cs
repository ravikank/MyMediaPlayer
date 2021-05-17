using MyMediaPlayer.Models;

namespace MyMediaPlayer.Abstractions
{
    /// <summary>
    /// This is the interface required for media player playback commands.
    /// Currently it only supports, Play and Decompress options.
    /// Any new playback command should implement this interface. 
    /// </summary>
    public interface ICommand
    {
        public void Execute(RequestModel request);
    }
}
