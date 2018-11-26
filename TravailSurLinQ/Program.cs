
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IciCestUnSuperNamespace;
using RappelClasses;

namespace TravailSurLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GunGan> list = new List<GunGan>();

            for (int i = 0; i < 1000; i++)
            {
                var gg = new GunGan("toto" + i);

                gg.Poids = i + 10;

                list.Add(gg);


                list.Add(new GunGan("toto" + i)
                {
                    Poids = i + 10
                });

            }

            var nb = list.Count;


            decimal poidsTotal = 0;
            foreach (var item in list)
            {
                poidsTotal = poidsTotal + item.Poids;
            }

            Console.WriteLine("Le poids total des GG est de : " + poidsTotal);



            poidsTotal = list.Sum(plouf => plouf.Poids);

            decimal moyenneDesPoids = list.Average(plaf => plaf.Poids);

            Console.WriteLine("moy : " + moyenneDesPoids);


            GunGan lePremier = list.First();
            GunGan leDernier = list.Last();


        }
    }
}
