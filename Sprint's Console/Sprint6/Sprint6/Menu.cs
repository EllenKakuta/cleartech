using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Sprint6
{
    public class Menu
    {
        public List<Categoria> Lista { get; set; } = new List<Categoria>();
        public int IdC { get; set; } = 1;

           
        public string escolha;
        public string opcao = " 1- Cadastrar \n 2- Editar\n 3- Listar\n 4- Pesquisar \n 5- Sair\n";

        Categoria categoria = new Categoria(); 
        Subcategoria subcategoria = new Subcategoria();

        public void MenuInicial()
        {
            
            do
            {
                Console.WriteLine("\n-> Digite a opção desejada:\n");
                Console.WriteLine(opcao);
                escolha = Console.ReadLine();
                Console.Clear();
                switch (escolha)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("\n-> Cadastrar");
                            Console.WriteLine("\n * 1- Categoria\n * 2- Subcategoria\n * 3- Voltar");
                            escolha=Console.ReadLine();
                            switch (escolha)
                            {
                                case "1":
                                    AddCategoria();
                                    break;
                                case "2":
                                    if (String.IsNullOrEmpty(categoria.Nome))
                                    {
                                        Console.WriteLine("\n *** Só é possível cadastrar uma subcategoria se houver uma categoria cadastrada ***");
                                        MenuInicial();
                                    }
                                    else
                                        AddSubcategoria();
                                    break;
                                case "3":
                                    Console.Clear();
                                    MenuInicial();
                                    
                                    break;
                                default:
                                    Console.WriteLine("*** Escolha uma opção válida ***");
                                    break;
                            }

                        }while (escolha != "1" || escolha != "2");
                                               
                        break;

                    case "2":
                        if (String.IsNullOrEmpty(categoria.Nome))
                        {
                            Console.WriteLine("\n *** A edição só é possível se houver uma categoria cadastrada ***");
                        }
                        else
                            do
                        {

                            Console.WriteLine("\n-> Editar");
                            Console.WriteLine("\n * 1- Categoria/Subcategoria\n * 2- Voltar");
                            escolha = Console.ReadLine();
                            switch (escolha)
                            {
                                case "1":
                                    Editar();
                                    break;
                                case "2":
                                    Console.Clear();
                                    MenuInicial();
                                    break;
                                 default:
                                Console.WriteLine("*** Escolha uma opção válida ***");
                                    break ;
                            }

                        } while (escolha != "1" || escolha != "2" || escolha!="3");
                   
                                       
                        break;
                    case "3":
                        
                        if (String.IsNullOrEmpty(categoria.Nome))
                        {
                            Console.WriteLine("\n *** Não há categoria ou subcategoria cadastrada ***");
                        }
                        else
                        Console.WriteLine("\n-> Listar:");
                        Listar();
                       
                        break;
                    case "4":
                        if (String.IsNullOrEmpty(categoria.Nome))
                        {
                            Console.WriteLine("\n *** Não há categoria ou subcategoria cadastrada ***");
                        }
                        else

                            do
                        {
                            Console.WriteLine("\n-> Pesquisar");

                            Console.WriteLine("\n * 1- Pesquisar por ID/ Nome\n * 2- Voltar");
                            escolha = Console.ReadLine();
                            switch (escolha)
                            {
                                case "1":
                                    Pesquisar(); 
                                    break;
                              
                                    case "2":
                                    Console.Clear();
                                    MenuInicial();
                                   
                                    break;
                                default:
                                    Console.WriteLine("*** Escolha uma opção válida ***");                                                                    
                                    break;
                            }

                        } while (escolha != "1" || escolha != "2" );                  
                        break;
                    case "5":
                        Console.WriteLine("\n-> Encerrando ...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("*** Escolha uma opção válida ***");
                        break;
                }

            } while (escolha != "1" || escolha != "2" || escolha != "3" || escolha != "4" || escolha != "5" );
            if (escolha == "5");
            Console.Clear();
        }

        private void AddCategoria()
        {
            categoria.Cadastrar();
            categoria = new(IdC,categoria.Nome);
            Lista.Add(new Categoria(IdC, categoria.Nome));
            IdC++;
            categoria.Dados();

        }
        
        private void AddSubcategoria()
        {
            subcategoria.Cadastrar();
            subcategoria = new(IdC,subcategoria.Nome);
            Lista.Add(new Subcategoria(IdC,subcategoria.Nome));
            IdC++;
            subcategoria.Dados();
        }

        private void Listar()
        {
            foreach (Categoria categoria in Lista)
            {

                categoria.Dados();


            }
        }

        private int IdCat()
        {
            
            string Idcat = Console.ReadLine();
            if (!int.TryParse(Idcat, out var id))
            {
                throw new ArgumentException("** Digite um valor válido **");
            }
           
            return id;

        }
        private bool Ativar()
        {
            bool ativo;
            string escolha;

            
                Console.WriteLine("-> Digite A para ATIVAR ou I para INATIVAR");
                escolha = Console.ReadLine();
                switch (escolha.ToUpper())
                {
                    case "A":
                        ativo = true;
                        break;

                    case "I":
                        ativo = false;
                        break;

                    default:
                    throw new ArgumentException("*** Digite uma opção válida ***");
                    break;
                }
            return ativo;
        }
        private void Editar()
        {
            foreach (Categoria c in Lista)
            {

                Console.WriteLine(
                    " | ID | " + c.Id + "      | Status | " + c.Status + "      | Nome | " + c.Nome +
                     "\n ------------------------------------------------------------------------");


            }

            Categoria categoria = null;
            Console.WriteLine("\n-> Digite o ID desejado para edição");
            int idCat = IdCat();
            foreach (Categoria cat in Lista)
            {
                if (cat.Id == idCat)
                {
                    categoria = cat;
                    break;
                }
            }    
            if (categoria is null)
            {
                Console.WriteLine("*** ID não localizado ***");
                MenuInicial();
            }
            Console.WriteLine("\n-> Insira o novo nome ");
            string Nomecat = Console.ReadLine();
            bool ativar = Ativar();
            categoria.Editar(Nomecat, ativar);
            categoria.Dados();

        }
        
        private void Pesquisar()
        {
            List<Categoria> pesquisar = new List<Categoria>();
            Console.WriteLine(" Digite I para pesquisa por ID ou N para pesquias por Nome: ");
            string opcao = Console.ReadLine();
            switch (opcao.ToUpper())
            {
                case "I":
                    {
                        Console.WriteLine("Digite o ID para pesquisa: ");
                        int id = IdCat();
                        foreach (Categoria c in Lista)
                            if (c.Id == id)
                            {
                                pesquisar.Add(c);
                            }                                         
                    }
                    break;
                case "N":
                    {
                        Console.WriteLine("Digite o nome para pesquisa: ");
                        string nome = Console.ReadLine();

                        foreach (Categoria c in Lista)
                            if (c.Nome.ToLower().StartsWith(nome.ToLower()))
                            {
                                pesquisar.Add(c);
                            }
                    }
                    break;
                default: throw new ArgumentException(" Por favor informe I ou N para pesquisa ");
                    

            }
            foreach (Categoria c in pesquisar)
            {
                c.Dados();
            }
                
        }

    }
}

