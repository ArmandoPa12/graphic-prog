using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PGrafica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(600, 600, "Drawable"))
            {
                game.Run(60.0);
            }


            //IDictionary<int, string> diccionario = new Dictionary<int, string>();
            //diccionario.Add(1, "uno");
            //diccionario.Add(2, "dos");
            //diccionario.Add(3, "tres");

            //foreach(KeyValuePair<int, string> kvp in diccionario)
            //{
            //    Console.WriteLine("key: {0}, Value: {1}", kvp.Key, kvp.Value);  
            //}


        }
    }
}
