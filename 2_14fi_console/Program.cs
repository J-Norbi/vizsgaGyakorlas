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
            Console.WriteLine((int)(int.Parse(number) + 1.9));
            FileReader reader = new FileReader();
            List<string> allLines = reader.readFile("kolbasz.txt");
            //all = reader.readFile("kolbasz.txt");
            all.Add(("sajt szalonna").Substring(5, 5));
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

            Console.WriteLine(r.Next(10, 21));   //math: 10 <= x < 21
            //PI, sqrt, pow, round
            Console.WriteLine(Math.Pow(10, Math.PI));


            int num = int.MinValue;
            Console.WriteLine(num - 1);
            uint num2 = uint.MinValue;
            Console.WriteLine(num2 - 1);
            /*Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);*/

            Console.WriteLine(String.Join(';', allLines));
            // "első sor..."
            Console.WriteLine("r betű az első sorban: " + allLines.First().IndexOf('r'));
            Console.WriteLine("második sor a fájlban: " + allLines.IndexOf("második sor"));

            bool logicValue = false;
            logicValue = !logicValue;
            logicValue = true;
            logicValue = 4 < 9;
            // <, >, <=, >=, ==, !=
            if (gyumolcs.Contains("alma"))
            {
                Console.WriteLine("van benne alma");
            }
            else
            {
                Console.WriteLine("Nincs benne alma");
            }


            if (gyumolcs.Length > 14)
            {
                Console.WriteLine("Ez több gyümölcs");
            }
            else if (gyumolcs.Length >= 4)
            {
                Console.WriteLine("Ez valószínűleg 1 gyümölcs");
            }
            else
            {
                Console.WriteLine("Ez valószínűleg nem gyümölcs. Túl rövid a szó.");
            }

            // hármas operátor ( ? : )
            //
            // így nem használhatom, ha függvényt adok vissza, csak ha értéket adok vissza:
            //
            //gyumolcs.Contains("alma") ? Console.WriteLine("van benne alma") : Console.WriteLine("Nincs benne alma");
            string gyumolcsVolt = gyumolcs.Contains("alma") ? "van benne alma" : "Nincs benne alma";
            Console.WriteLine(gyumolcsVolt);

            bool IdItMorning = DateTime.Now.Hour >= 12 ? false : true;
            // szövegesen:
            string IdItMorning2 = DateTime.Now.Hour >= 12 ? "nincs már reggel" : "Reggel van még";
            Console.WriteLine(IdItMorning2);

            string szoveg = "aúsdH.giÁof123";
            foreach (char letter in szoveg)
            {
                // pattern matching - mintázat felismerés
                // ez mindig gyorsabb, mint az if - else
                // feltételek összefűzése: 'and', 'or'
                string betuE = letter switch
                {
                    >= '0' and <= '9' => "szám",
                    >= 'a' and <= 'z' => "kisbetű",
                    >= 'A' and <= 'Z' => "nagybetű",
                    'á' or 'é' or 'í' or 'ó' or 'ö' or 'ő' or 'ú' or 'ü' or 'ű' => "magyar ékezetes kisbetű",
                    'Á' or 'É' or 'Í' or 'Ó' or 'Ö' or 'Ő' or 'Ú' or 'Ü' or 'Ű' => "magyar ékezetes nagybetű",
                    _ => "egyéb karakter" // mint az else ág
                };
                Console.WriteLine("A karakter: " + letter + " " + betuE);
            }

            // számok kiírása 1 - 10-ig
            Console.WriteLine("számok kiírása 1 - 10-ig");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            // páros számok kiírása 100-ig
            Console.WriteLine("páros számok kiírása 100-ig");
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            // hattal osztható számok 55-ig
            Console.WriteLine("hattal osztható számok 55-ig");
            for (int i = 0; i <= 54; i += 6)
            {
                Console.WriteLine(i);
            }
            // páratlan számok 10-től 33-ig
            Console.WriteLine("páratlan számok 10-től 33-ig");
            for (int i = 11; i <= 33; i += 2)
            {
                Console.WriteLine(i);
            }
            // számok 100-tól 1-ig
            List<int> visszafeleSzamok = new();
            Console.WriteLine("számok 100-tól 1-ig");
            for (int i = 100; i >= 1; i--)
            {
                visszafeleSzamok.Add(i);
                Console.WriteLine(i);
            }
            // páros számok 66-tól 11-ig
            Console.WriteLine("páros számok 66-tól 11-ig");
            for (int i = 66; i >= 11; i -= 2)
            {
                Console.WriteLine(i);
            }

            // gyümölcs változót karakterenként kiíratni
            Console.WriteLine("gyümölcs változót karakterenként kiíratni");
            for (int i = 0; i < gyumolcs.Length; i++)
            {
                Console.WriteLine(gyumolcs[i]);
            }
            // írjuk ki a gyümölcs változót visszafelé
            Console.WriteLine("írjuk ki a gyümölcs változót visszafelé");
            for (int i = gyumolcs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(gyumolcs[i]);
            }

            bool voltBenneSzo = false;
            int index = 0;
            while (!voltBenneSzo && index < (allLines.Count - 1))
            {
                if (allLines[index].Contains("sajt"))
                {
                    voltBenneSzo = true;
                    // break: teljes ciklus leállítása
                    // continue: a ciklus következő iterációjára ugrik
                    continue;
                }
                index++;
            }
            Console.WriteLine(voltBenneSzo ? "Volt benne szó" : "Nem volt benne szó");

            // legalább egyszer leellenőrzi a feltételt - hátul tesztelő ciklus
            // ritkán használjuk
            /*
            
            do
            {
                Console.WriteLine("jaj de jó"); // végtelen ciklus - mert a feltétel mindig igaz
            } while (voltBenneSzo);
            
            */


            // Tömbök
            int[] szamok = new int[3];      // adott méretű tömb
            szamok[0] = 0;
            szamok[1] = 7;
            szamok[2] = 11;

            List<int> szamokLista = new();  // dinamikus méretű tömb
            szamokLista.Add(0);
            szamokLista.Add(7);
            szamokLista.Add(11);

            // több dimenziós tömb
            /*int[,] matrix = new int[2, 2]; // 2x2 mátrix
            matrix[0, 0] = 0;
            matrix[1, 0] = 1;
            matrix[0, 1] = 1;
            matrix[1, 1] = 0;*/

            int[,] matrix;
            int matrixMerete = 10;

            matrix = new int[matrixMerete, matrixMerete]; // 10x10 mátrix

            for (int i = 0; i < matrixMerete; i++)
            {
                for (int j = 0; j < matrixMerete; j++)
                {
                    matrix[i, j] = (j % 2 + i % 2) % 2;
                }
            }

            for (int magassag = 0; magassag < matrix.GetLength(1); magassag++)
            {
                for (int szelesseg = 0; szelesseg < matrix.GetLength(0); szelesseg++)
                {
                    Console.Write(matrix[magassag, szelesseg] + " ");
                }
                Console.Write('\n');
            }
            //
            // lista lambda kifejezéssel (valami =>valami % x == y)
            //
            int listaDarabszam = visszafeleSzamok.Count(szam => szam % 2 == 0);
            Console.WriteLine("páros számok 100-tól 1-ig: " + listaDarabszam);

            int listaDarabszam2 = visszafeleSzamok.Count(szam => szam % 2 == 0 && szam % 3 == 0);
            Console.WriteLine("2-vel és 3-mal osztható számok mennyisége 100-tól 1-ig: " + listaDarabszam2);

            List<int> hattalOszthato = visszafeleSzamok.Where(kolbasz => kolbasz % 6 == 0).ToList();
            hattalOszthato.Sort();
            Console.WriteLine(String.Join(' ', hattalOszthato));

            List<Kolbasz> kolbaszok = new();
            for (int i = 30; i > 0; i--)
            {
                kolbaszok.Add(new Kolbasz(i));
            }
            kolbaszok = kolbaszok.OrderBy(k => k.taste).ToList();
            Console.WriteLine(String.Join(' ', kolbaszok.Select(kolbasz => kolbasz.taste)));
            /*
             * vagy 
             * IEnumerable<Kolbasz> sortedKolbaszok = kolbaszok.OrderBy(k => k.taste);
             * Console.WriteLine(String.Join(' ', sortedKolbaszok.Select(kolbasz => kolbasz.taste)));
            */

            // írjuk ki a 7-mal osztható tastel rendelkező kolbászokat, hogy mennyi a taste értékük soronként
            // csökkenő sorrendben
            Console.WriteLine(String.Join(' ',
                kolbaszok.Where(k => k.taste % 7 == 0)
                .Select(k => k.taste)
                .OrderByDescending(k => k)));
            // írjuk ki annak a kolbásznak az id-ját, aminek az átlag tastje van, egészre kerekítve.
            Console.WriteLine(kolbaszok.Average(k => k.taste));
            int atlagID = kolbaszok.FindIndex(k => k.taste == (int)Math.Round(kolbaszok.Average(a => a.taste)));

            Console.WriteLine(atlagID);

            // minden változónak van egy default értéke
            bool logicalValue2 = default; // false
            int szam = default; // 0
            string szoveg2 = default; // null
            Console.WriteLine(logicalValue2);
            char karakter = default; // '\0' - null karakter
            Console.WriteLine("char: " + karakter);

            Console.WriteLine("--------------------------------------------------------------------");

            //List<Car> cars = new();
            List<IVehicle> cars = new();
            cars.Add(new Car("Honda") { year = 1992, power = 125, topSpeed = 190 });    // int => 0; string => NULL
            cars.Add(new Car("Trabant") { year = 1990, model = "1.1", power = 38, topSpeed = 135});

            Console.WriteLine((cars.Last()as Car).make);
            Console.WriteLine((cars.Last()as Car).model);
            Console.WriteLine(cars.Last().year);

            if (cars[0].CompareTo(cars[1]) > 0)
                Console.WriteLine("A Honda erősebb");
            else if(cars[0].CompareTo(cars[1]) == 0)
                Console.WriteLine("Egyenlő erősek");
            else
                Console.WriteLine("A Trabant erősebb");

            cars.Sort();    // ezt a CompareTo metódus alapján csinálja. E nélkül nem tudná, hogyan kell sorrendezni a Car objektumokat

            Console.WriteLine(String.Join(' ', cars.Select(car => car.power)));

            cars.Add(new Motorcycle() { year = 2020, power = 150, topSpeed = 280 });
            Console.WriteLine(String.Join(' ', cars.Select(car => car.power)));
            Console.WriteLine(String.Join(' ', cars.Select(car => car.year)));


            int motorcycleCount = cars.Count(car => car is Motorcycle); // mennyi motor van a listában
            Console.WriteLine(motorcycleCount + " db motor típus van");
            int carCount = cars.Count(car => car is Car);
            Console.WriteLine(carCount + " db autó típus van");

            //List<IVehicle> over150 = cars.Where(car => car.topSpeed > 150).ToList();
            IEnumerable<IVehicle> over150 = cars.Where(car => car.topSpeed > 150);

            Console.WriteLine(String.Join(' ', over150.Select(car => car.topSpeed)));
        }
    }
    internal class  Motorcycle : IVehicle
    {
        public int power { get; set; }
        public int year { get; set; }
        public int topSpeed { get; set; }

        public int CompareTo(IVehicle? obj)
        {
            return power - obj.power;
        }

        public double Move(int distance)
        {
            return (double)distance / topSpeed * 1.1;
        }
    }
    internal interface IVehicle : IComparable<IVehicle>
    {
        public int power { get; set; }
        public int year { get; set; }
        public int topSpeed { get; set; }
        public double Move(int distance);
    }

    // 3.7.4.6.1
    // IComparable interface implementálása, ami a CompareTo metódust követeli meg és segíti az objektumok sorrendezését
    internal class Car : IVehicle, IComparable<IVehicle>
    {
        public int power { get; set; }
        public string make { get; set; }
        private string _model = "";
        public string model
        {
            get
            {
                if (_model.Length < 2)
                {
                    return "Még nincs beállítva a modell";
                }
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        private int _year;  // ez lesz a változó, amit a year property kezel
        public int year
        {   // ez a publikus property, már függvényként viselkedik
            get
            {
                return _year;
            }
            set
            {
                if (value <= DateTime.UtcNow.Year && value > 1896)
                    _year = value;
                else
                    throw new Exception("Hibás évjárat");
            }
        }

        public int topSpeed { get; set; }

        public Car(string make = "")
        {
            this.make = make;
        }
        public int CompareTo(IVehicle? other)
        {
            return power - other.power;
        }

        public double Move(int distance)
        {
            return (double)distance / topSpeed;     // a double azért kell, hogy ne egész szám legyen a visszatérési érték -> típus kényszerítés (konverzió)
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
                throw new Exception("Valami hiba történt"); // csak a példa miatt
            }
            catch (Exception e) // rengeteg féle exception van
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

        // minden classnek van egy default konstruktora, egészen addig, amíg nem hozol létre egy sajátot
        // default konstruktor: létrehoz egy classt, minden változó értékét a default értékre állítja
        public Kolbasz(int taste = 0)
        {
            this.taste = taste;
        }

    }
}
