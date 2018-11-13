using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {
        public char nom { get; set; }
        public short valeur { get; set; }

        public Piece(char name)
        {
            nom = name;

            if (name == 'D')
            {
                valeur = 8;
            }
            else if (name == 'T')
            {
                valeur = 5;
            }
            else if (name == 'P')
            {
                valeur = 1;
            }
            else
            {
                valeur = 3;
            }
        }
    }
}
