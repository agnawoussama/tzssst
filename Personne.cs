using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tzssst
{
    class Personne 
    {
        //attributs
        int cin;
        string nom;
        int age;

        public string Prenom {get ; set; }

        //proprietes
        public int Cin
        {
            get { return cin; }
            set {
                if (value < 50)
                {
                    cin = value;
                }
                else
                {
                    Console.WriteLine("Ne peut pas ajouter le cin");
                }            
            }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //methods
        public virtual void Marcher()
        {
            Console.WriteLine("Ce personne marche");
        }

         


    }
}
