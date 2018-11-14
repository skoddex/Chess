using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Case
    {
        private int x;
        private int y;

        Piece currentPiece = null;

        public Case(int x , int y, Piece piece)
        {
            this.x = x;
            this.y = y;
            this.currentPiece = piece;

        }

    }
}
