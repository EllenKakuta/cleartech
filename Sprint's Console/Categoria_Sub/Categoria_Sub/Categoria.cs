using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Categoria_Sub
{
    public class Categoria

    {
        public Categoria() { }
        public string _nome { get; set; }
        public int _id { get; set; }
        public DateTime DataCad { get; set; }

        public DateTime DataEd { get; set; }
        public bool edstatus = false;
        public Categoria (string nome, int id, DateTime dataCad)
        {

            _nome = nome;
            _id = id;
            DataCad = DateTime.Now;
        }

        List<Categoria> categorias = new List<Categoria>();

        public string escolha2;
        public bool status = true;           
       
       

       //CADASTRAR CATEGORIA
        public void CadCategoria()
        {

            do
            {
                Console.WriteLine("Digite o nome da categoria a ser cadastrada: ");
                _nome = Console.ReadLine();
                if (_nome.Length <= 0 || _nome.Length > 50 || String.IsNullOrWhiteSpace(_nome))
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");
                  
                }
                if (!Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {

                    Console.WriteLine("Permitido somente o uso de letras");
                }
                


            } while (_nome.Length <= 0 || _nome.Length > 50 || !Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
            String.IsNullOrWhiteSpace(_nome));
            Console.WriteLine("\n* ID: "+ _id + "\n* Categoria: " + _nome  + "\n* Data de criação: " + (DataCad = DateTime.Now) + "\n* Status: " + status);

            categorias.Add(new Categoria(_nome, _id, DataCad));

        }

       
        //EDITAR CATEGORIA 
        public void EditarCategoria()
        {
            do
            {
                Console.WriteLine("Digite o nome da categoria a ser editada");
                _nome = Console.ReadLine();
                if (_nome.Length <= 0 || _nome.Length > 50 || String.IsNullOrWhiteSpace(_nome))
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");
                    
                }
                if (!Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {
                    Console.WriteLine("Permitido somente o uso de letras");
                   
                }
      
            }
            while (_nome.Length <= 0 || _nome.Length > 50 || !Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
            String.IsNullOrWhiteSpace(_nome));


            
            do
            {
                Console.WriteLine("Digite o nome da nova categoria");
                _nome = Console.ReadLine();
                
                if (_nome.Length <= 0 || _nome.Length > 50)
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");
                }
                if (!Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {
                    Console.WriteLine("Permitido somente o uso de letras");
                }
               

            }
            while (_nome.Length <= 0 || _nome.Length > 50 || !Regex.IsMatch(_nome , @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
            String.IsNullOrWhiteSpace(_nome));
            ;
           

            do
            {
                Console.WriteLine("Digite A para ATIVAR ou I para INATIVAR");
                escolha2 = Console.ReadLine();
                switch (escolha2)
                {
                    case "A"  :
                        Console.WriteLine("Status atual: " + status);
                        break;
                    case "a":
                        Console.WriteLine("Status atual: " + status);
                        break;
                    case "I":
                        Console.WriteLine("Status atual: " + edstatus); 
                        break;
                    case "i":
                        Console.WriteLine("Status atual: " + edstatus);
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida..");
                        break;
                }

                
            }
            while (escolha2 != "a" && escolha2 != "i"&& escolha2!="A" && escolha2!="I");
            
            if (escolha2 == "a" || escolha2 == "i"|| escolha2=="A"|| escolha2=="I")
            {
                Console.WriteLine("Categoria editada com sucesso!\n Nome da nova categoria : " + _nome + "\nCriação: " + DataCad + "\nData da edição: " + (DataEd = DateTime.Now)+ "\n");

            }

           categorias.Add(new Categoria(_nome, _id, DataCad));

        }
      
        //LISTAR CATEGORIA
        public void Listar()
        {
            foreach (var c in categorias)
            {
                Console.WriteLine( 
                    "ID: " + c._id + "\nNome: " + c._nome + 
                     "\n----------------------------------------");

            
            }    

        }

        //PESQUISAR CATEGORIA
        public void Pesquisar()
        {
            do
            {

                _nome = Console.ReadLine();
                if (_nome.Length <= 0 || _nome.Length > 50 || String.IsNullOrWhiteSpace(_nome))
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");

                }
                if (!Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ 0-9]*$"))
                {

                    Console.WriteLine("Permitido somente o uso de letras e números");
                }
            } while (_nome.Length <= 0 || _nome.Length > 50 || !Regex.IsMatch(_nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ 0-9]*$") ||
            String.IsNullOrWhiteSpace(_nome));
            var resultado = from categoria in categorias
                                where categoria._nome.ToLower().Substring(0,3) == _nome.ToLower() || categoria._id == _id
                                select categoria;

                foreach (Categoria c in resultado)
                {
                    Console.WriteLine("ID:" + c._id + "\nNome: " + c._nome + "\nData: " + c.DataCad + "\nStatus: " + status);
                }
            
        }   


    }
}



