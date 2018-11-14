using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Coup
    {
        private List<Case> casesPossible = new List<Case>();

        public List<Case> CasesPossible
        {
            get { return casesPossible; }
            set { casesPossible = value; }
        }

    public Coup()
        {

        }
    }
}
