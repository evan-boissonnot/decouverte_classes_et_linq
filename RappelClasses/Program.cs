using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IciCestUnSuperNamespace;

namespace RappelClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GunGan fff = new GunGan("dd");
            fff.FirstName = "";

            List<GunGan> list = new List<GunGan>();

            list.Add(new GunGan("jarjar"));
            list.Add(new GunGan("bossnass"));

            GunGan[] unTableau = new GunGan[2];
            unTableau[0] = new GunGan("jarjar");
            unTableau[1] = new GunGan("bossnass");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].FirstName);
            }

            foreach (var truc in list)
            {
                Console.WriteLine(truc.FirstName);
                truc.Marcher();
                truc.Courrir();
            }

            Console.ReadLine();
        }
    }
}
