using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgainApp.Models
{
    public class Jokes
    {
        public int Id { get; set; }
        public string JokeQuestion  { get; set; }
        public string JokeAnswer { get; set;}

        public Jokes()
        {
            
        }
    }
}
