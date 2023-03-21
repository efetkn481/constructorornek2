using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            Console.Write("Adınızı giriniz: ");
            kml.AD = Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            kml.SOYAD= Console.ReadLine();
            Console.Write("Memleketinizi giriniz: ");
            kml.MEMLEKET=Console.ReadLine();
            Console.Write("Yaşınızı sayı olarak giriniz: ");
            kml.YAS=Convert.ToInt32(Console.ReadLine());
            Console.Write("Medeni halinizi ''E'' veya ''B'' olarak giriniz: ");
            kml.Medenihal=Convert.ToChar(Console.ReadLine());
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.Medenihal);
            Console.ReadLine();

        }
    }
}
