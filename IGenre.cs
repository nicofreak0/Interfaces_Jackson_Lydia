using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Jackson_Lydia
{
    internal interface IGenre
    {
        //automatic get and set properties for esrb
        public string Esrb { get; set; }
        //automatic get and set properties for genre
        public string Genre { get; set;}
        //automatic get and set properties for title
        public string Title { get; set; }


        // public method called describe
        public string Describe();

    }
}
