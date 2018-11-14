using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Tower : Piece
    {

        public Tower(Case myCase, bool ennemy) : base("Tower", myCase ,ennemy)
        {

        }

        public override Coup MovePossible(Case[,] map)
        {
            return null;
        }
    }
}
