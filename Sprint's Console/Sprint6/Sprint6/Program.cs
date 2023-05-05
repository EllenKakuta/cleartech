using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint6
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string str = "";

            do
            {
                try
                {
                    Console.WriteLine("\n ----   Bem vindo!   ---- ");
                    menu.MenuInicial();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }while (str != "0");
            
        }
    }
}