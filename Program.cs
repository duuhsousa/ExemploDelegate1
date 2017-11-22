using System;

namespace ExemploDelegate1
{
    class Program
    {
        public delegate void Cortador(string queijo);
        public delegate string Novinha(string mortadela);
        static void Main(string[] args)
        {
            /*Data("BACON");
            System.Console.WriteLine(DataCompleta("BACON 2"));
            */
            
            Cortador vera = new Cortador(Data);
            vera("BACON ");
            Novinha novinha = new Novinha(DataCompleta);
            System.Console.WriteLine(novinha("BACON 2 "));
        }

        static void Data(string texto){
            System.Console.WriteLine(texto+" Hoje eh "+ DateTime.Now.ToShortDateString());
        }

        static string DataCompleta(string nome){
            return "Ola "+nome+" Hoje eh "+DateTime.Now.ToLongTimeString();
        }
    }
}
