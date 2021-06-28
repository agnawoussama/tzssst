using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tzssst
{
    class testclass
    {
        // attributs
        int num = 12;
        string nom;

        //proprietes
        public int Num
        {
            get { return num; }
            //set { num = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }        


    }
}
