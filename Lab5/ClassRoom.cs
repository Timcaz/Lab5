using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class ClassRoom
    {
        private List<Pupil> allPup = new List<Pupil>();
        public ClassRoom(Pupil pup0, Pupil pup1)
        {
            allPup.Add(pup0);
            allPup.Add(pup1);
        }
        public ClassRoom(Pupil pup0, Pupil pup1, Pupil pup2)
        {
            allPup.Add(pup0);
            allPup.Add(pup1);
            allPup.Add(pup2);
        }
        public ClassRoom(Pupil pup0, Pupil pup1, Pupil pup2, Pupil pup3)
        {
            allPup.Add(pup0);
            allPup.Add(pup1);
            allPup.Add(pup2);
            allPup.Add(pup3);
        }
        public void ShowPup()
        {
            foreach (Pupil pup in allPup)
            {
                Console.WriteLine(pup);
                pup.Study();
                Console.WriteLine();
                pup.Relax();
                Console.WriteLine();
                pup.Read();
                Console.WriteLine();
                pup.Write();
                Console.WriteLine();
            }
        }
    }
}
