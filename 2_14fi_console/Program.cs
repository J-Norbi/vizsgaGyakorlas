using System.Text;

namespace _2_14fi_console
{
    internal class Program
    {
        static List<string> all = new();
        static Random r = new();
        static void Main(string[] args)
        {
            Kolbasz oneKolbasz = new Kolbasz(5);
            Console.WriteLine(Kolbasz.text);
            //Console.WriteLine(oneKolbasz.text);
            Console.WriteLine(oneKolbasz.taste);
            Console.WriteLine(oneKolbasz.taste / 2);
            Console.WriteLine((double)oneKolbasz.taste / 2);
            Console.WriteLine((int)(1.5));
            string number = "666";
            Console.WriteLine((int)(int.Parse(number)+1.9));
            FileReader reader = new FileReader();
            List<string> allLines = reader.readFile("kolbasz.txt");
            //all = reader.readFile("kolbasz.txt");
            all.Add(("sajt szalonna").Substring(5,5));
            Console.WriteLine(all.Last());
            Console.WriteLine(all.Last().IndexOf('a'));
            Console.WriteLine(all.Last().IndexOf("lo"));
            Console.WriteLine(all.Last()[4]);
            //szalo > szalp
            Console.WriteLine(all.Last().CompareTo("szalo"));

            string szamSzoveg = "123";
            Console.WriteLine(szamSzoveg.CompareTo("1200"));

            string datum = "2025.09.01-02:00:00";
            Console.WriteLine("Nagyobb-e mint 2026.01.01: " + datum.CompareTo("2026.01.01"));

            string gyumolcs = "alma";
            gyumolcs += " és körte";
            Console.WriteLine(gyumolcs);

            Console.WriteLine(r.Next(1));    //  matematikailag: 0 <= x < 1      
            Console.WriteLine(r.Next(10));    //0,1,2,3,4,5,6,7,8,9

            Console.WriteLine(r.Next(10,21));   //math: 10 <= x < 21
            //PI, sqrt, pow, round
            Console.WriteLine(Math.Pow(10,Math.PI));


            int num = int.MinValue;
            Console.WriteLine(num-1);
            uint num2 = uint.MinValue;
            Console.WriteLine(num2-1);
            /*Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);*/

        }
    }
    class FileReader
    {
        public List<string> readFile(string fileName)
        {
            List<string> lines = new();
            try
            {
                foreach (string item in File.ReadAllLines(fileName, Encoding.UTF8))
                {
                    lines.Add(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lines;
        }
    }
    class Kolbasz
    {
        public static string text = "A kolbász finom";
        public int taste { get; private set; }
        private int taste2 = 0;
        public Kolbasz(int taste = 0)
        {
            this.taste = taste;
        }

    }
}
