using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Categoria_Sub
{
    public class SubCategoria : Categoria
    {
        public SubCategoria() { }
        public string nomeSub { get; set; }

        public int idS { get; set; }

        public DateTime DataSub { get; set; }


     



        public SubCategoria(string nome, int id, DateTime dataSub)
        {
            nomeSub = nome;
            idS = id;
            DataSub = DateTime.Now;
        }
        List<SubCategoria> subcategoria = new List<SubCategoria>();
        
        //CADASTRAR SUBCATEGORIA
        public void Subcategoria()
        {
            do
            {
                Console.WriteLine("Digite o nome da subcategoria a ser cadastrada: ");
                nomeSub = Console.ReadLine();
                if (nomeSub.Length <= 0 || nomeSub.Length > 50 || String.IsNullOrWhiteSpace(nomeSub))
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");

                }
                if (!Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {

                    Console.WriteLine("Permitido somente o uso de letras");

                }



            } while (nomeSub.Length <= 0 || nomeSub.Length > 50 || !Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
           String.IsNullOrWhiteSpace(nomeSub));
            Console.WriteLine("* ID: " + idS + "\n* Nome: " + nomeSub + "\n* Data de criação: " +(DataSub = DateTime.Now) + "\n* Status: " + status);
            subcategoria.Add(new SubCategoria(nomeSub, idS, DataSub));
        }


        //EDITAR SUBCATEGORIA
        public void EditarSub()
        {
            do
            {
                Console.WriteLine("Digite o nome da subcategoria a ser editada");
                nomeSub = Console.ReadLine();
                if (nomeSub.Length <= 0 || nomeSub.Length > 50 || String.IsNullOrWhiteSpace(nomeSub))
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");

                }
                if (!Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {
                    Console.WriteLine("Permitido somente o uso de letras");

                }
                else
                {
                    subcategoria.Remove(new SubCategoria(nomeSub, idS, DataSub));
                }


            }
            while (nomeSub.Length <= 0 || nomeSub.Length > 50 || !Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
            String.IsNullOrWhiteSpace(nomeSub));

            do
            {
                Console.WriteLine("Digite o nome da nova subcategoria");
                nomeSub = Console.ReadLine();
                if (nomeSub.Length <= 0 || nomeSub.Length > 50)
                {
                    Console.WriteLine("Por favor digite de 01 a 50 caracteres");
                }
                if (!Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {
                    Console.WriteLine("Permitido somente o uso de letras");
                }


            }
            while (nomeSub.Length <= 0 || nomeSub.Length > 50 || !Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
            String.IsNullOrWhiteSpace(nomeSub));

            do
            {
                Console.WriteLine("Digite A para ATIVAR ou I para INATIVAR");
                escolha2 = Console.ReadLine();
                switch (escolha2)
                {
                    case "A":
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
            while (escolha2 != "a" && escolha2 != "i" && escolha2 != "A" && escolha2 != "I");

            if (escolha2 == "a" || escolha2 == "i" || escolha2 == "A" || escolha2 == "I")
            {
                Console.WriteLine("Subcategoria editada com sucesso!\n Nome da nova subcategoria : " + nomeSub + "\nCriação: " + DataSub + "\nData da edição: " + (DataSub = DateTime.Now) + "\n");

            }
            subcategoria.Add(new SubCategoria(nomeSub, idS, DataSub));

        }

        //LISTAR SUBCATEGORIA
        public void ListarSub()
        {
            foreach (var s in subcategoria)
                Console.WriteLine(
                     "ID: " + s.idS + "\nNome: " + s.nomeSub +
                     "\n----------------------------------------");

        }
        //PESQUISAR SUBCATEGORIA
        public void PesquisarSub()
        {
            do 
            { 
            nomeSub = Console.ReadLine();
            if (nomeSub.Length <= 0 || nomeSub.Length > 50 || String.IsNullOrWhiteSpace(nomeSub))
            {
                Console.WriteLine("Por favor digite de 01 a 50 caracteres");

            }
            if (!Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ 0-9]*$"))
            {

                Console.WriteLine("Permitido somente o uso de letras e números");
            }
        } while (nomeSub.Length <= 0 ||nomeSub.Length > 50 || !Regex.IsMatch(nomeSub, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ 0-9]*$") && _nome==_nome||
            String.IsNullOrWhiteSpace(nomeSub)&& nomeSub!=nomeSub);
            var resultado = from subcategoria in subcategoria
                            where subcategoria.nomeSub.ToLower().Substring(0,3) == nomeSub || subcategoria.idS== idS
                            select subcategoria;

            foreach (SubCategoria c in resultado)
            {

                Console.WriteLine("ID:" + c.idS + "\nNome: " + c.nomeSub + "\nData: " + c.DataSub+ "\nStatus: " + status);
            }

        }

    }


    
}
