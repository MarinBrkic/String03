using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesi neku recenicu: ");
        string unos = Console.ReadLine();

        string sVelika = unos.ToUpper();
        string sMala = unos.ToLower();
        string sPrvaTri = unos.Substring(0, 3);
        string sZadnjihPet = unos.Substring(unos.Length - 5);
        string s8_11 = unos.Substring(7, 4);

        Console.WriteLine("sVelika: " + sVelika);
        Console.WriteLine("sMala: " + sMala);
        Console.WriteLine("sPrvaTri: " + sPrvaTri);
        Console.WriteLine("sZadnjihPet: " + sZadnjihPet);
        Console.WriteLine("s8_11: " + s8_11);

        Console.ReadKey();
    }
}
