using System;
using System.Text;

namespace enums
{
    class Program
    {
        //Enumirator 
        enum days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enumirators");
            Console.WriteLine("----------------------------");


            //Enum elemekre való hivatkozás
            Console.WriteLine(days.Wednesday + "\n");

            //Enum  indexes
            int enumIndex = (int)days.Sunday;
            Console.WriteLine(days.Sunday + ": " + enumIndex + "\n\n");

            Console.WriteLine("StringBuilder");
            Console.WriteLine("----------------------------");
            
            //Deklarálás
            StringBuilder sb = new StringBuilder("A string builder egy nagyon jó dolog!");

            //Hivatkozás/Kiirás
            Console.WriteLine(sb);

            //Szöveg fűzés
            sb.AppendLine(" Még egy kis szöveg.");
            sb.Append("Ez pedig új sorba lesz.");

            Console.WriteLine("\n\n"+sb+"\n");

            sb.Append("\nqqqqqqqq");

            //Bejárás,index,insert
            int counter = 0;
            for (var i = 0; i < sb.Length; i++)
            {

                if (sb[i].ToString().Contains("q"))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter + " ennyi 'q' karakter van az sb string builderben.\n");
            
            
            


        }
    }
}
