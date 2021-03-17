using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = Console.ReadLine();
            Client c1 = new Client(nom,"Ilyass","I65220" , new List<Compte>() );
            MAD solde1 = new MAD(8000);
            MAD debiter = new MAD(200);
            Compte cpt = new Compte(c1, solde1);
            cpt.Debiter(debiter);
            Operation o1 = new Operation("retrait", debiter);
            o1.afficher();

            cpt.consulter();
            Console.ReadKey();


        }
    }
}
