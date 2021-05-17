using System;
using MyMediaPlayer.Core;

namespace MyMediaPlayer.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MyMediaPlayer!");

            string filePath = "";
            //Code to get the input from user.
            //filePath = ....
            var myMediaPlayer = new MediaPlayer(filePath);
            myMediaPlayer.Run();

        }
    }
}
