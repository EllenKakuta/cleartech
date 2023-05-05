using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sprint6
{
    public class Categoria
    {

        public string Nome { get; set; }
        public int Id = 0;
        public DateTime DataCad { get; set; }
        public DateTime DataEd { get; set; }
        public bool _status { get; set; }
        

        public string Status
        {
            get
            {
                if (!_status)
                {
                    return "Inativo";
                }
                return "Ativo";
            }

        }
        public Categoria()
        {

        }
        public Categoria(int id, string nome)
        {
            Nome = nome;
            Id = id;
            DataCad = DateTime.Now;
            _status = true;
        }




        public virtual void Dados()
        {
            string finalizacao = ($"-> Categoria: \n- ID: {Id}\n- Nome: {Nome}\n- Data de criação: {DataCad}\n- Status: {Status}\n");
            if (DataEd != DateTime.MinValue)
            {
                finalizacao += ($"** Data de atualização: {DataEd}\n");
            }
            Console.WriteLine(finalizacao);
            
        }

        public virtual void Cadastrar()
        {

            do
            {
                Console.WriteLine("-> Digite o nome da categoria a ser cadastrada: ");
                Nome = Console.ReadLine();
                if (Nome.Length <= 0 || Nome.Length > 50 || String.IsNullOrWhiteSpace(Nome))
                {
                    Console.WriteLine("** Por favor digite de 01 a 50 caracteres **");

                }
                if (!Regex.IsMatch(Nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$"))
                {

                    Console.WriteLine("** Permitido somente o uso de letras **");
                }



            } while (Nome.Length <= 0 || Nome.Length > 50 || !Regex.IsMatch(Nome, @"^[ÃÕÂÊÔÁÉÍÓÚA-Z ãõâêôáéíóúa-z çÇ]*$") ||
            String.IsNullOrWhiteSpace(Nome));

        }
      

        public virtual void Editar(string nome, bool ativar)
        {
            Nome = nome;
            _status = ativar;
            DataEd = DateTime.Now;
        }          

    }
}


