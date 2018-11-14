using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Piece
    {

        #region attributs

        private string name = "default";
        private bool white;     // white player = true , black player = false
        private Case currentCase = null;

        #endregion

        #region propiétés

        public Case CurrentCase { get => currentCase; set => currentCase = value; }

        #endregion

        #region méthodes

        public Piece(string name, Case myCase, bool ennemy)
        {
            white = ennemy;
            this.CurrentCase = myCase;
            this.name = name;
        }

        public virtual Coup MovePossible(Case[,] map)
        {
            return null;
        }

        #endregion
        
    }
}
