using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Sprint;
using System.Text.RegularExpressions;

namespace Cadastro_Sprint
{
    public class Editar : Categoria
    {
        public string edCat;
        public string ednome;
        public bool edstatus;
        public DateTime dataedicao;
        public string novaCat;
        public string final;
        public int tentativas = 0;
        public string mensagem;
        public string mensagemStatus;
        public string escolha;


        public Editar()
        {
            edCat = "Digite a categoria a ser editada";
            dataedicao = DateTime.Now;
            edstatus = false;
            novaCat = "Digite o nome da nova categoria";
            final = "Categoria Editada com sucesso!\n" + "\nModificação: " + DateTime.Now;
            mensagem = "Digite de 1 a 128 caracteres, apenas de letras";
            mensagemStatus = "Digite A para ATIVAR ou I para INATIVAR:";
        }

        public void EdCategoria()
        {
        

            do
            {
                
                Console.WriteLine(edCat);
                nome = Console.ReadLine();
                if (nome.Length <= 0 || nome.Length > 10 ||!Regex.IsMatch(nome, @"^[a-z A-Z çÇ)*$"))
                {
                    Console.WriteLine(mensagem);
                }
                //tentativas++;
            }
            while (nome.Length <=0|| nome.Length > 10 || !Regex.IsMatch(nome, @"^[a-z A-Z çÇ)*$"));
            
            do
            {
                Console.WriteLine(novaCat);
                nome = Console.ReadLine();
                if (nome.Length <= 0 || nome.Length > 10 ||!Regex.IsMatch(nome, @"^[a-z A-Z çÇ)*$"))
                {
                    Console.WriteLine(mensagem);
                }                
                //tentativas++;
            }
            while (nome.Length <= 0 || nome.Length > 10 || !Regex.IsMatch(nome, @"^[a-z A-Z çÇ)*$"));
            
            do
            {
                Console.WriteLine(mensagemStatus);
                escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "a":
                        Console.WriteLine(edstatus = true);
                        break;
                    case "i":
                        Console.WriteLine(edstatus = false);
                        break;
                    default: Console.WriteLine("Digite uma opção válida..");
                        break;
                }
               
            }
            while (escolha != "a" && escolha !="i");
           if (escolha == "a" || escolha == "i")
            {
                Console.WriteLine(final);
            }
                
        }
        

        public override string GetNovaCategoria
        {
            get => base.GetNovaCategoria;
            set => base.GetNovaCategoria = value;
        }
    }
}