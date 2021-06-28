using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tzssst
{
    class Etudiant : Personne
    {
        public string filiere;

        public override void Marcher()
        {
            Console.WriteLine("Ce Etudiant marche");
        }


    }
}
