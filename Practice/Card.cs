using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Card
    {
        public string Name { get; }
        public string Suite { get; }
        public int Points { get; }

        public Card(string name, string suite, int points)
        {
            Name = name;
            Suite = suite;
            Points = points;
        }
    }
}
