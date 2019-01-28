using NetCoreAudio;
using System;

namespace RecordAudio
{
    class Program
    {
        /*[DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);*/

        static void Main(string[] args)
        {
            /*mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
            mciSendString("record recsound", "", 0, 0);
            Console.WriteLine("recording, press Enter to stop and save ...");
            Console.ReadLine();

            mciSendString("save recsound c:\\users\\ogilo\\documents\\result.wav", "", 0, 0);
            mciSendString("close recsound ", "", 0, 0);*/

            Player player = new Player();
            player.Record().Wait();
            Console.WriteLine("type stop to stop recording...");
            string stop = Console.ReadLine();

            if (stop == "stop")
            {
                Console.WriteLine("stopping recording...");
                player.StopRecording().Wait();
                Console.ReadLine();
            }
        }
    }
}