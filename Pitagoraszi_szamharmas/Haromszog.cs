using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoraszi_szamharmas
{
    /*
    Ha a 17.sorban ki viszem a számokhoz az egeret mentés után akkor bejön egy kis csavarhuzó szerű valami és ott 
    rá kell kattintani a GENERATE CONSTRUKTOR és ott mindent ki kell pipálni majd okés és legenerálja magát.

    Feladatban az volt hogy a beállítást tegyük privátra azt a private szóval tudjuk megoldani a prop-os felsorolásnál.

    A 17.sorban a class internallal kezdődik de ott át kell írni publicra mert nem fogja engedni a UNIT TESZTET futtatni.
    */
    public class Haromszog
    {
        public int a { get; private set; }
        public int b { get; private set; }
        public int c { get; private set; }

        public Haromszog(string sor)
        {
            string[] darabok=sor.Split(' ');
            
            this.a = Convert.ToInt32(darabok[0]);
            this.b = Convert.ToInt32(darabok[1]);
            this.c = Convert.ToInt32(darabok[2]);
        }

    }
}
