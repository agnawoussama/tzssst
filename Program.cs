using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace tzssst
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne yassine = new Personne();
            Etudiant et1 = new Etudiant();
            Professeur p1 = new Professeur();
            et1.Marcher();
            yassine.Marcher();
            p1.Marcher();
            
            
            



            Console.ReadKey();
        }

        


    }
}
