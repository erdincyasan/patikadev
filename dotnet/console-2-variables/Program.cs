using System;

namespace console_2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------byte değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(byte)}");
            Console.WriteLine($"Maksimum değer {byte.MaxValue}");
            Console.WriteLine($"Minimum değer {byte.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------sbyte değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(sbyte)}");
            Console.WriteLine($"Maksimum değer {sbyte.MaxValue}");
            Console.WriteLine($"Minimum değer {sbyte.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------short değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(short)}");
            Console.WriteLine($"Maksimum değer {short.MaxValue}");
            Console.WriteLine($"Minimum değer {short.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------ushort değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(ushort)}");
            Console.WriteLine($"Maksimum değer {ushort.MaxValue}");
            Console.WriteLine($"Minimum değer {ushort.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------Int16 değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(Int16)}");
            Console.WriteLine($"Maksimum değer {Int16.MaxValue}");
            Console.WriteLine($"Minimum değer {Int16.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------int değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(int)}");
            Console.WriteLine($"Maksimum değer {int.MaxValue}");
            Console.WriteLine($"Minimum değer {int.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------Int32 değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(Int32)}");
            Console.WriteLine($"Maksimum değer {Int32.MaxValue}");
            Console.WriteLine($"Minimum değer {Int32.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------Int64 değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(Int64)}");
            Console.WriteLine($"Maksimum değer {Int64.MaxValue}");
            Console.WriteLine($"Minimum değer {Int64.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------uint değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(uint)}");
            Console.WriteLine($"Maksimum değer {uint.MaxValue}");
            Console.WriteLine($"Minimum değer {uint.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------long değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(long)}");
            Console.WriteLine($"Maksimum değer {long.MaxValue}");
            Console.WriteLine($"Minimum değer {long.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------ulong değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(ulong)}");
            Console.WriteLine($"Maksimum değer {ulong.MaxValue}");
            Console.WriteLine($"Minimum değer {ulong.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------float değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(float)}");
            Console.WriteLine($"Maksimum değer {float.MaxValue}");
            Console.WriteLine($"Minimum değer {float.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------double değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(double)}");
            Console.WriteLine($"Maksimum değer {double.MaxValue}");
            Console.WriteLine($"Minimum değer {double.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------decimal değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(decimal)}");
            Console.WriteLine($"Maksimum değer {decimal.MaxValue}");
            Console.WriteLine($"Minimum değer {decimal.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------char değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(char)}");
            Console.WriteLine($"Maksimum değer {char.MaxValue}");
            Console.WriteLine($"Minimum değer {char.MinValue}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("------string değişkeni başlangıç-----");
            //string sınırsız olduğu için hata veriyor.
            // Console.WriteLine($"kapladığı alan {sizeof(String)}");
            // Console.WriteLine($"Maksimum değer {string.MaxValue}");
            // Console.WriteLine($"Minimum değer {string.MinValue}");
            Console.WriteLine("-------------------------");

            Console.WriteLine("------bool değişkeni başlangıç-----");
            Console.WriteLine($"kapladığı alan {sizeof(bool)}");
            // Console.WriteLine($"Maksimum değer {bool.MaxValue}");
            // Console.WriteLine($"Minimum değer {bool.MinValue}");
            Console.WriteLine("-------------------------");

            object o1 = "y";
            object o2 = 'y';
            object o3 = 3;
            object o4 = 4.5;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Erdinç YAŞAN";
            string ad = "Erdinç";
            string soyad = "Yaşan";
            string tam_ad = ad + " " + soyad;

            //int ifadeler
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //bool ifadeler
            bool bool1 = 10 < 2;
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //datetime 

            string datetime=DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            System.Console.WriteLine(datetime);

        }
    }
}
