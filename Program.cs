using System;
using System.Collections.Generic;

namespace nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> goodSongs = new List<(string, string)>();
            List<(string, string)> badSongs = new List<(string, string)>();

            HashSet<(string artist, string song)> allSongs = new HashSet<(string, string)>();
            (string artist, string song) photograph = ("Nickleback", "Photograph");
            (string artist, string song) remind = ("Nickleback", "How You Remind Me");
            (string artist, string song) too_good = ("Nickleback", "Feelin Way Too Damn Good");
            (string artist, string song) graduation = ("Head Automatica", "Graduation Day");
            (string artist, string song) ride = ("Ryan Adams", "Let It Ride");
            (string artist, string song) friends = ("Manchester Orchestra", "Ive Got Friends");
            (string artist, string song) semi = ("Third Eye Blind", "Semi-Charmed Life");

            allSongs.Add(photograph);
            allSongs.Add(remind);
            allSongs.Add(too_good);
            allSongs.Add(graduation);
            allSongs.Add(ride);
            allSongs.Add(friends);
            allSongs.Add(semi);


            foreach((string, string) song in allSongs){
                if(song.Item1 != "Nickleback"){
                    goodSongs.Add(song);
                }
                else{
                    badSongs.Add(song);
                }
            }

            foreach((string, string) song in goodSongs){
                Console.WriteLine($"{song.Item2} by {song.Item1} is a good song");
            }
            
            foreach((string, string) song in badSongs){
                Console.WriteLine($"{song.Item2} by {song.Item1} is a bad song");
            }


        }
    }
}
