using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Categoria_Sub
{
    public class Menu

    {
        Categoria Categoria = new Categoria();
        SubCategoria SubCategoria = new SubCategoria();
        

        public string escolha;
        public string opcao = " 1- Cadastrar Categoria\n 2- Editar Categoria\n 3- Cadastrar Subcategoria\n " +
            "4- Editar Subcategoria\n 5- Listar\n 6- Pesquisar Categoria\n 7- Pesquisar Subcateogria\n 8- Sair\n";



        public void MenuInicial()
        {
           
            do
            {
                Console.WriteLine("\n-> Digite a Opção Desejada:\n");
                Console.WriteLine(opcao);
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Categoria");
                        Categoria._id = Categoria._id + 1;
                        Categoria.CadCategoria();
                        Console.ReadKey();
                        break;
                
                    case "2":
                        Console.WriteLine("Editar Categoria:");
                        if (String.IsNullOrEmpty(Categoria._nome))
                        {
                            Console.WriteLine("A edição só é possível se houver uma categoria cadastrada");
                        }
                        else
                        Categoria.EditarCategoria();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Cadastrar Subcategoria:");
                        if (String.IsNullOrEmpty(Categoria._nome))
                        {
                            Console.WriteLine("Só é possível cadastrar uma subcategoria se houver uma categoria cadastrada");
                        }
                        else
                            SubCategoria.idS=SubCategoria.idS+1;
                            SubCategoria.Subcategoria();
                        Console.ReadKey();
                        break ;
                    case "4":
                        Console.WriteLine("Editar Subcategoria:");
                        if (String.IsNullOrEmpty(SubCategoria.nomeSub))
                        {
                            Console.WriteLine("A edição só é possível se houver uma subcategoria cadastrada");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Listar:");
                        if (String.IsNullOrEmpty(Categoria._nome)) 
                        {
                            Console.WriteLine("Não há nenhuma categoria cadastrada\n");
                        }
                        else
                        {
                            Console.WriteLine("Categorias:\n");
                            Categoria.Listar();

                        }
                        if (String.IsNullOrEmpty(SubCategoria.nomeSub))
                        {
                            Console.WriteLine("Não há nenhuma subcategoria cadastrada\n");
                        }
                        else
                        {
                            Console.WriteLine("Subcategorias:");
                            SubCategoria.ListarSub();
                        }
                       
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Pesquisar");
                        if (String.IsNullOrEmpty(Categoria._nome))
                        {
                            Console.WriteLine("Não há nenhuma categoria  cadastrada\n");
                        }
                        else
                        {
                            Console.WriteLine("Digite o nome da categoria  a ser pesquisada");
                            Categoria.Pesquisar();                            
                        }
                        break;                                             
                    case "7":
                        Console.WriteLine("Pesquisar Subcategoria");
                        if (String.IsNullOrEmpty(SubCategoria.nomeSub))
                        {
                            Console.WriteLine("Não há nenhuma  subcategoria cadastrada\n");
                        }
                        else
                        {
                            Console.WriteLine("Digite o nome da subcategoria a ser pesquisada");
                            SubCategoria.PesquisarSub();
                        }
                        break;
                     case "8":
                        Console.WriteLine("Sair");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }

            }while (escolha != "1" || escolha != "2" || escolha !="3"|| escolha != "4" || escolha != "5" || escolha !="6" || escolha!="7" || escolha!="8");
            if (escolha == "8") ;
            Console.Clear();
        }
    
    }
}