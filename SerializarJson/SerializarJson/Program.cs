using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace SerializarJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("serialiiii");
            Persona persona = new Persona { Nombre = "debanhi", Apellido = "nava", Edad = 12 };
            string result = JsonConvert.SerializeObject(persona);
            //Console.WriteLine(result);
            //Console.ReadLine();

            string path = @"C:\Users\Curso\Documents\enero\persona.txt";
            System.IO.File.WriteAllText(path, result);



    }

    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
        
        

}
