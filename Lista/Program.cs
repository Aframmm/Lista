using System;
using System.Collections.Generic;

namespace hejpådiguppgiftlistor
{
    class Program
    {
        static int Minsta(List<int> listan) {
            int minst = listan[0];

            foreach(int i in listan){
if(i < minst){
                minst = i;
                }
            }

            return minst;
        }

        static int Största(List<int> listan) {
            int störst = listan[0];

            foreach(int i in listan){
                if(i > störst){
                    störst = i;
                }
            }

            return störst;
        }

        static void SkrivUt(List<int> listan) {
            foreach(int i in listan){
                Console.WriteLine(i);
            }
        }

        public static void Main (string[] args) {
            Console.WriteLine("Lista:");
            List<int> minLista = new List<int>();
            minLista.Add(11);
            minLista.Add(5);
            minLista.Add(12);
            minLista.Add(3);
            minLista.Add(6);
            minLista.Add(3);

            SkrivUt(minLista);

            Console.WriteLine("Största tal: "+Största(minLista));
            Console.WriteLine("Minsta tal: "+Minsta(minLista));

        }
    }
}