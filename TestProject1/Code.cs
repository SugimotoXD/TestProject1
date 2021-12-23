using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaba1i3
{
    public class Code
    {
        static void Main(string[] args)
        {
            Atmosfera auto = new Atmosfera("Атмосфера");
            Luna auto2 = new Luna("Луна");
            Noch auto3 = new Noch("Ночь");
            Artur auto4 = new Artur("Артур");
            Starik auto5 = new Starik("Старик");

            Console.WriteLine(" {1}  {3}  {5}  {7} {9}", auto.name, auto.Zadacha(), auto2.name, auto2.Zadacha2(), auto3.name, auto3.Zadacha3(), auto4.name, auto4.Zadacha4(), auto5.name, auto5.Zadacha5());
            Console.ReadKey();
        }
    }

    public class Atmosfera
    {
        public string name { get; set; }
        public Atmosfera(string name)
        {
            this.name = name;
        }

        public string Zadacha()
        {
            return "Iz-za razrajennosti atmosferi";
        }
    }

    public class Luna
    {
        public string name { get; set; }
        public Luna(string name)
        {
            this.name = name;
        }

        public string Zadacha2()
        {
            return "i iz-za togo chto luni ne bilo";
        }
    }

    public class Noch
    {
        public string name { get; set; }
        public Noch(string name)
        {
            this.name = name;
        }

        public string Zadacha3()
        {
            return "Noch nastupila ochen bistro, i bilo yje ochen temno.";
        }
    }

    public class Artur
    {
        public string name { get; set; }
        public Artur(string name)
        {
            this.name = name;
        }

        public string Zadacha4()
        {
            return "Po etomy Atrur ne zametil";
        }
    }
    public class Starik
    {
        public string name { get; set; }
        public Starik(string name)
        {
            this.name = name;
        }

        public string Zadacha5()
        {
            return "Starika, poka ne stolknulsa s nim";
        }
    }
}

