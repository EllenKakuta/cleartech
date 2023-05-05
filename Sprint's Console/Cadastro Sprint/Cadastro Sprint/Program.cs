using Cadastro_Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Cadastro;

    public class Cadastro
{
    public static void Main(string[] args)
    {
        Editar categoriaEditar = new Editar();
        Categoria categoria = new Categoria();
        Menu menu = new Menu();

        do
        {
            Console.WriteLine(menu.inicio);
            menu.escolha = (Console.ReadLine());
            switch (menu.escolha)
            {
                case "1":
                    Console.WriteLine("Criar Categoria");
                    categoria.CadCategoria();
                    //Console.WriteLine(categoria.GetNovaCategoria);
                    break;
                case "2":
                    Console.WriteLine("Editar Categoria");
                    categoriaEditar.EdCategoria();
                    // Console.WriteLine(categoriaEditar.GetNovaCategoria);
                    break;
                case "3":
                    Console.WriteLine("Criar Subcategoria");
                    Console.ReadKey();
                    return;
                    break;
                case "4":
                    Console.WriteLine("Editar Subcategoria");
                    categoriaEditar.EdCategoria();
                    // Console.WriteLine(categoriaEditar.GetNovaCategoria);
                    break;
                case "5":
                    Console.WriteLine("Sair");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
        } while (menu.escolha != "1" || menu.escolha != "2" || menu.escolha != "3" || menu.escolha != "4" || menu.escolha != "5");
        if (menu.escolha == "5");
        Console.Clear();
    }



}   
        


