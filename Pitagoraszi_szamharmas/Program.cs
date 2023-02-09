using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections;
using System.Security.Claims;

namespace Pitagoraszi_szamharmas
{
    //Át kell írni a az internalt publicra,hogy a UNIT TESZT működjön!
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<Haromszog> haromszogek = new List<Haromszog>();
            StreamReader sr = new StreamReader("szamok.txt");
            
            Console.WriteLine("Derékszögű háromszögek:");
            while(!sr.EndOfStream)
            {
                Haromszog h = new Haromszog(sr.ReadLine());

                haromszogek.Add(h);

                if (derekszogu(h)==true)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            sr.Close();

            Console.WriteLine("");
            //2.Feladat:Ki íratni úgy a számokat ,hogy a:10 b:20 c:30 formátumban!
            Console.WriteLine("a,b,c oldal kiíratása:");
            foreach (var item in haromszogek)
            {
                Console.WriteLine($"a:{item.a} b:{item.b} c:{item.c}");
            }

            //3.Feladat:Melyik derékszögű háromszög a legnagyobb területű (a*b/2)!

            int legnagyobbterulet = 0;
            Haromszog legnagyobbTeruletu3szog = haromszogek[0];
            
            
            foreach (var item in haromszogek)
            {
                
                if (item.a*item.a+item.b*item.b==item.c*item.c)
                {
                    if (item.a*item.b/2>legnagyobbterulet)
                    {
                        legnagyobbterulet = item.a * item.b / 2;
                        legnagyobbTeruletu3szog = item;
                    }
                }

               
            }

            Console.WriteLine("A legnagyobb területű háromszög:"+legnagyobbterulet);

            Console.WriteLine("A legnagyobb területű háromszög adatai: a:"+legnagyobbTeruletu3szog.a+"b:"+ legnagyobbTeruletu3szog.b+"c:"+legnagyobbTeruletu3szog.c );



            //4.Feladat:Unit tesztek elvégzése!

            Console.ReadKey();
        }

        //1.Feladat:Állapítsd meg,hogy az adott a,b,c oldal derékszögű háromszög-e bool használatával (Metódus használatával==Függvény)!
        public static bool derekszogu(Haromszog h)
        {
            if (h.a*h.a+h.b*h.b==h.c*h.c)
            {
                return true;
            }

            return false;
        }
    }
}
