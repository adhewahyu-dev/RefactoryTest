using System;
using System.Linq;

namespace VScodeC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NumberOne.hello();
            NumberThree.count();
            NumberFour.word();
            NumberFive.IsOdd(4);
            NumberFive.IsEven(8);
            NumberSix.grade(50);
            NumberSeven.CelciusToFahrenheit(100);
            NumberSeven.FahrenheitToCelcius(50);
            NumberSeven.CelciusToKelvin(100);
            NumberSeven.KelvinToCelcius(375);
            NumberSeven.KelvinToFahrenheit(375);
            NumberSeven.FahrenheitToKelvin(12);
            NumberEight.IsLeapYear();
            NumberTen.Sum(1,6);
            NumberTen.Multiply(2,6);
            NumberTen.Substract(2,7);
            NumberTen.Divide(9,2);
            NumberEleven.dotnet();
            NumberTwelve.uppercase("welcome to the world!");
            NumberThirteen.CountWords("Lorem ipsum dolor sit amet");
            NumberFourteen.IsPalindrome("ipsum");
            NumberFifteen.Mirror("---vv");
            NumberSixteen.IndexFinder("Pepaya");
            NumberSeventeen.loop();
            NumberEighteen.FindMax();
            NumberEighteen.FindMin();
            NumberEighteen.FindAverage();
            NumberNineteen.array();
        }
    }
    
    class NumberOne 
    {
        public static void hello()
        {
          Console.WriteLine("Write your name ...");
      	  string input = Console.ReadLine();
          Console.WriteLine($"Hello my name is {input}");
        }
    }

    class NumberThree
    {
        public static void count()
        {
            int hitung = 0;
	        string mystring ="hello word";
	            foreach(char c in mystring)
	            {
	            if(char.IsLetter(c))
	            {
		        hitung++;
	            }
	    }
          Console.WriteLine($"{mystring} Memiliki {hitung} karakter!");
        }
    }

    class NumberFour
    {
        public static void word()
        {
            string [] censoredWords;
            censoredWords = new string[] {
                "imprediet","dolor","duo"
            };
            string paragraph =$"Lorem ipsum {censoredWords[1]} sit ame, {censoredWords[0]} vituperata {censoredWords[2]} in, nonumy.";
        
            Console.WriteLine(paragraph);
        }
    }

    class NumberFive
    {
        public static void IsEven(int angka)
        { 
            bool answer = angka %2 == 0;
            Console.WriteLine(answer);
        }
        public static void IsOdd(int angka)
        { 
            bool answer = angka %2 == 1;
            Console.WriteLine(answer);
        }
    }

    class NumberSix
    {
        public static void grade( int grade)
        {
            int nilai = grade;

            if(nilai >= 90)
            {
                Console.WriteLine("A");
            } else if( nilai >= 80) 
            {
                Console.WriteLine("B");
            }  else if ( nilai >= 70)
            {
                Console.WriteLine("C");
            } else if ( nilai >= 60)
            {
                Console.WriteLine("D");
            } else 
            {
                Console.WriteLine("E");
            }
        }
    }

    class NumberSeven
    {
        public static void CelciusToFahrenheit(int celcius)
        {
            float fahrenheit;
            fahrenheit = celcius * 9 / 5 + 32;
            Console.WriteLine(fahrenheit);
        }
        public static void FahrenheitToCelcius(int fahrenheit)
        {
            float celcius;
            celcius = (fahrenheit-32) * 5/9;
            Console.WriteLine(celcius);
        }
        public static void CelciusToKelvin(double Celcius)
        {
            double kelvin;
            kelvin = Celcius + 273.15;
            Console.WriteLine(kelvin);
        }
        public static void KelvinToCelcius( double kelvin)
        {
            double celcius;
            celcius = kelvin - 273.15;
            Console.WriteLine(Math.Round(celcius, 2));
        }
        public static void KelvinToFahrenheit(double kelvin)
        {
            double fahrenheit;
            fahrenheit = (kelvin - 273.15) * 9/5 +32;
            Console.WriteLine(Math.Round(fahrenheit,2));
        }
        public static void FahrenheitToKelvin(double fahrenheit)
        {
            double kelvin;
            kelvin = (fahrenheit - 32) * 5/9 + 273.15;
            Console.WriteLine(Math.Round(kelvin,3));
        }
        
    }

    class NumberEight
    {
        public static void IsLeapYear()
        { 
            int tahun;
            Console.Write("Masukkan tahun: ");
            tahun = Convert.ToInt16(Console.ReadLine());

            bool answer = tahun % 4 == 0 || tahun % 400 == 0;
            Console.WriteLine(answer);
        }
    }

    class NumberTen
    {
        public static void Sum(int a, int b)
        {
            int total;
            total = a + b;
            Console.WriteLine(total);
        }
        public static void Multiply(int a, int b)
        {
            float total;
            total = a * b;
            Console.WriteLine(total);
        }
        public static void Substract(int a, int b)
        {
            float total;
            total = a - b;
            Console.WriteLine(total);
        }
        public static void Divide(double a, double b)
        {
            double total;
            total = a / b;
            Console.WriteLine(total);
        }

    }

    class NumberEleven
    {
        public static void dotnet()
        {
            int a,b,c,d, total;
            Console.WriteLine("dotnet run -- ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            total = a+b+c+d;
            Console.WriteLine(total);
        }

    }

    class NumberTwelve
    {
        public static void uppercase(string word)
        {
            string upper = word.ToUpper();
            Console.WriteLine(upper);
        }

    }

    class NumberThirteen
    {
        public static void CountWords(string kalimat)
        {
            string[] katakata = kalimat.Split(' ');
            Console.WriteLine("Count ="+katakata.Length);
        }

    }

    class NumberFourteen
    {
        private static string reverse(string kata)
        {
            char[] data = kata.ToCharArray();
    
            Array.Reverse(data);
            return new string(data);
        }

        public static void IsPalindrome(string kata)
        { 
            bool answer = kata.Equals(reverse(kata));
            Console.WriteLine(answer);
        }
    }



    static class StringHelper
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

    class NumberFifteen
    {
        public static void Mirror(string kal)
        {
            string balik;
            balik = StringHelper.ReverseString(kal);
            Console.WriteLine(kal+balik);
        }

    }

    class NumberSixteen
    {
        public static void IndexFinder(string buah)
        {
            var fruits = new string[] { "Jeruk","Apel","Angur","Pepaya","Pisang","Kiwi","Markisa"};
            int index2 = Array.IndexOf<string>(fruits, buah);
            Console.WriteLine(index2);
        }

    }

    class NumberSeventeen
    {
        public static void loop()
        {
            int number = 0;  
      
            while (number < 1000)
            {
                number++;
                if (number == 5)
                {
                    Console.WriteLine($"{number}. Foo");
                }else if(number == 20)
                {
                    Console.WriteLine($"{number}. Bar");
                }else if(number == 200)
                {
                    Console.WriteLine($"{number}. Baz");
                }else
                {
                    Console.WriteLine($"{number}.");
                }
            }
        }

    }

    class NumberEighteen
    {
        public static void FindMax()
        {
            var anArray = new int[] { 2,4,54,12,-65,19,40,92,88,330,-4,54 };
            var max = anArray.Select((n, i) => (Number: n, Index: i)).Max();
            Console.WriteLine($"Maximum number = {max.Number}");
        }
        public static void FindMin()
        {
            var anArray = new int[] { 2,4,54,12,-65,19,40,92,88,330,-4,54 };
            var max = anArray.Select((n, i) => (Number: n, Index: i)).Min();
            Console.WriteLine($"Maximum number = {max.Number}");
        }
        public static void FindAverage()
        {
            var anArray = new int[] { 2,4,54,12,-65,19,40,92,88,330,-4,54 };
            int size;
            size = anArray.Length;
            int sum = 0;
            int average = 0;
                for (int i = 0; i < size; i++)
                {
                    sum += anArray[i];
                }
            average = sum / size; 
            Console.WriteLine($"Average = {average}");
        }

    }

    class NumberNineteen
    {
        public static void array()
        {
            int[] points = new int[] {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45}; 
   
            Array.Sort(points); 
     
            foreach(int value in points) 
            { 
                Console.Write(value + " "); 
            } 
        }

    }


}
