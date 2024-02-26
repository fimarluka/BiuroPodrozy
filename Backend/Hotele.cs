using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy.Backend
{
    public class Hotel
    {
        public string? Kategoria { get; set; }
        public string? Nazwa { get; set; }
        public string? Kraj { get; set; }
        public int Cena { get; set; }
        public bool AllInclusive { get; set; }
        public int ID { get; set; }
        public string? Region { get; set; }
        public void ShowHotel(int ktory, DateTime data) 
        {
            Console.WriteLine("NUMER: "+(ktory+1)+"\n");
            Console.WriteLine("KRAJ: " + this.Kraj + "\n");
            if(ktory==0)
            {
                Console.WriteLine("TERMIN: " + data.ToShortDateString() + " - " + data.AddDays(7).ToShortDateString() + "\n");
            }
            else if(ktory==1) 
            {
                Console.WriteLine("TERMIN: " + data.ToShortDateString() + " - " + data.AddDays(10).ToShortDateString() + "\n");
            }
            else
            {
                Console.WriteLine("TERMIN: " + data.ToShortDateString() + " - " + data.AddDays(14).ToShortDateString() + "\n");
            }
            Console.WriteLine("HOTEL: " + this.Nazwa + " (" + this.Kategoria + ") \n");
            if(ktory==0) 
            {
                this.AllInclusive = false;
                Console.WriteLine("WYŻYWIENIE: ŚNIADANIA");
            }
            else
            {
                this.AllInclusive = true;
                Console.WriteLine("WYŻYWIENIE: All Inclusive");
            }
            if(this.AllInclusive)
            {
                Console.WriteLine("CENA: " + (this.Cena + 1200));
            }
            else
            {
                Console.WriteLine("CENA: " + this.Cena);
            }
        }
        
    }
    
    class Program
    {
        public static List<int> GetNumbers()
        {
            var numbers = new List<int>();
            var random = new Random();
            while (numbers.Count < 3)
            {
                int number = random.Next(1, 16);
                if (!numbers.Contains(number))
                    numbers.Add(number);
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            Hotel Hotel1 = new Hotel()
            {
                Kategoria = "****",
                Nazwa = "Cancun Bay resort",
                Kraj = "Meksyk",
                Cena = 450,
                Region = "Ameryka",
                ID = 1
            };
            Hotel Hotel2 = new Hotel()
            {
                Kategoria = "*****",
                Nazwa = "Iberostar Quetzal",
                Kraj = "Meksyk",
                Cena = 690,
                Region = "Ameryka",
                ID = 2
            };
            Hotel Hotel3 = new Hotel()
            {
                Kategoria = "***",
                Nazwa = "Imperial Laguna by Faranda",
                Kraj = "Meksyk",
                Cena = 320,
                Region = "Ameryka",
                ID = 3
            };
            Hotel Hotel4 = new Hotel()
            {
                Kategoria = "*****",
                Nazwa = "Playacalida",
                Kraj = "Hiszpania",
                Cena = 600,
                Region = "Europa",
                ID = 4
            };
            Hotel Hotel5 = new Hotel()
            {
                Kategoria = "***",
                Nazwa = "Palia Puerto del Sol",
                Kraj = "Hiszpania",
                Cena = 240,
                Region = "Europa",
                ID = 5
            };
            Hotel Hotel6 = new Hotel()
            {
                Kategoria = "****",
                Nazwa = "Playa Real Resort",
                Kraj = "Hiszpania",
                Cena = 380,
                Region = "Europa",
                ID = 6
            };
            Hotel Hotel7 = new Hotel()
            {
                Kategoria = "***",
                Nazwa = "Sea Gull",
                Kraj = "Egipt",
                Cena = 270,
                Region = "Afryka",
                ID = 7
            };
            Hotel Hotel8 = new Hotel()
            {
                Kategoria = "****",
                Nazwa = "Continental Hurghada",
                Kraj = "Egipt",
                Cena = 360,
                Region = "Afryka",
                ID = 8
            };
            Hotel Hotel9 = new Hotel()
            {
                Kategoria = "*****",
                Nazwa = "Sharm Grand Plaza",
                Kraj = "Egipt",
                Cena = 620,
                Region = "Afryka",
                ID = 9
            };
            Hotel Hotel10 = new Hotel()
            {
                Kategoria = "***",
                Nazwa = "Ikaros Hotel",
                Kraj = "Grecja",
                Cena = 220,
                Region = "Europa",
                ID = 10
            };
            Hotel Hotel11 = new Hotel()
            {
                Kategoria = "*****",
                Nazwa = "Labranda Sandy Beach Resort",
                Kraj = "Grecja",
                Cena = 580,
                Region = "Europa",
                ID = 11
            };
            Hotel Hotel12 = new Hotel()
            {
                Kategoria = "*****",
                Nazwa = "Mytt Beach Hotel",
                Kraj = "Tajlandia",
                Cena = 720,
                Region = "Azja",
                ID = 12
            };
            Hotel Hotel13 = new Hotel()
            {
                Kategoria = "****",
                Nazwa = "Novotel Rayong",
                Kraj = "Tajlandia",
                Cena = 410,
                Region = "Azja",
                ID = 13
            };
            Hotel Hotel14 = new Hotel()
            {
                Kategoria = "***",
                Nazwa = "Cholchan Pattaya Resort",
                Kraj = "Tajlandia",
                Cena = 410,
                Region = "Azja",
                ID = 14
            };
            Hotel Hotel15 = new Hotel()
            {
                Kategoria = "****",
                Nazwa = "Lida Corfu",
                Kraj = "Grecja",
                Cena = 310,
                Region = "Europa",
                ID = 15
            };

            List<Hotel> Hotele = new List<Hotel>(15);
            Hotele.Add(Hotel1);
            Hotele.Add(Hotel2);
            Hotele.Add(Hotel3);
            Hotele.Add(Hotel4);
            Hotele.Add(Hotel5);
            Hotele.Add(Hotel6);
            Hotele.Add(Hotel7);
            Hotele.Add(Hotel8);
            Hotele.Add(Hotel9);
            Hotele.Add(Hotel10);
            Hotele.Add(Hotel11);
            Hotele.Add(Hotel12);
            Hotele.Add(Hotel13);
            Hotele.Add(Hotel14);
            Hotele.Add(Hotel15);

            List<int> numbers = GetNumbers();
            DateTime data = new DateTime(2024, 6, 15);

            for (int i = 0; i < numbers.Count; i++)
            {
                for(int j=0; j<Hotele.Count;j++)
                {
                    if (numbers[i] == Hotele[j].ID)
                    {
                        Hotele[j].ShowHotel(i, data);
                        Console.WriteLine("------------------------------");
                    }
                }
            }
            int dorosli;
            int dzieci;
            int wybor;
            int wycena=0;

            Console.WriteLine("WYBIERZ OFERTE: \n");
            wybor = Int32.Parse(Console.ReadLine());
            wybor--;

            Console.WriteLine("ILE OSOB DOROSLYCH: \n");
            dorosli = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ILE DZIECI: \n");
            dzieci = Int32.Parse(Console.ReadLine());

            int ktoryhotel = numbers[wybor];

            if(wybor == 0)
            {
                wycena += Hotele[ktoryhotel-1].Cena * 7;
                if (Hotele[ktoryhotel-1].AllInclusive == true)
                {
                    wycena += 1200*7;
                }
            }
            else if (wybor == 1)
            {
                wycena += Hotele[ktoryhotel-1].Cena * 10; 
                if (Hotele[ktoryhotel-1].AllInclusive == true)
                {
                    wycena += 1200*10;
                }
            }
            else
            {
                wycena += Hotele[ktoryhotel - 1].Cena * 14; 
                if (Hotele[ktoryhotel - 1].AllInclusive == true)
                {
                    wycena += 1200*14;
                }
            }

            if (Hotele[ktoryhotel-1].Region=="Europa")
            {
                wycena += 1000;
            }
            else if (Hotele[ktoryhotel - 1].Region=="Azja")
            {
                wycena += 2000;
            }
            else if (Hotele[ktoryhotel-1].Region=="Afryka")
            {
                wycena += 1500;
            }
            else
            {
                wycena += 2500;
            }

            double OstatecznaCena=wycena*dorosli+(wycena/2)*dzieci;

            Console.WriteLine("CENA OSTATECZNA: " + OstatecznaCena);

        }
    }
}
