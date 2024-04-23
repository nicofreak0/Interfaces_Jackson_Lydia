using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Jackson_Lydia
{
    internal class Game : IGenre
    {
        //automatic get and set properties for esrb
        public string Esrb { get; set; }
        //automatic get and set properties for genre
        public string Genre { get; set; }
        //automatic get and set properties for title
        public string Title { get; set; }


        //implements a constructor with string parameters for genre esrb and title,
        //and creates properties for Esrb Genre and Title within the public Game
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// prints to console that the game title is starting when PlayGame is called on
        /// </summary>
        public void PlayGame() 
        {
            Console.WriteLine($"{Title} is starting! Game on!");
        }

        /// <summary>
        /// creates a discribe string to be able to print title, genre, and rating to console in a sentence describing them
        /// </summary>
        /// <returns></returns>
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}.";
        }
    }
}
