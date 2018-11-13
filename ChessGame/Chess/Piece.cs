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
        public char couleur { get; set; }

        public Piece(char name, char color)
        {
            nom = name;
            couleur = color;

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

        public bool[,] DeplacementsPossibles(short x,short y)
        {
            bool[,] mat = new bool[8, 8];
            MiseFalse(mat);
            if(nom == 'T')
            {
                LateralATrue(mat,x,y);
            }

            return mat;
        }

        public void MiseFalse(bool[,] pikachu)
        {
            for(short i = 0; i < pikachu.GetLength(0); i++)
            {
                for(short j = 0; j < pikachu.GetLength(1); j++)
                {
                    pikachu[i, j] = false;
                }
            }
        }
        public void LateralATrue(bool[,] pikachu, short x, short y)
        {
            for(short i = 0; i<8; i++)
            {
                pikachu[i, y] = true;
            }
            for(short j = 0; j<8; j++)
            {
                pikachu[x, j] = true;
            }
            pikachu[x, y] = false;
        }
        public void AfficherMatriceBool(bool[,] mat)
        {
            for(int i = 0; i<8; i++)
            {
                for(int j = 0; j<8; j++)
                {
                    Console.Write(mat[i, j] == true ? "1" : "0");
                }
                Console.WriteLine();
            }
        }
    }
}
