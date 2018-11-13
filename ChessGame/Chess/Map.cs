using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using JeuEchec;

namespace Chess
{
    public class Map
    {
        private int size = 64;
        private Case[,] map;

        public Map()
        {

        }

        public void DisplayMap()
        {
            for(int y = 0; y < 8; y++)
            {
                for(int x = 0; x < 8; x++)
                {
                    Console.Write((y * 10 + x).ToString() + " ; ");
                }
                Console.Write('\n');
            }

        }
    }
}
