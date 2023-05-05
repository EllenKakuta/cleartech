using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Sprint;
using Cadastro;

namespace Cadastro_Sprint
{
    public class Categoria
    {

        public string nomeCat;
        public bool status;
        public DateTime DataInclusao;
        public string nome;
        public string finalizacao;
        public int tentativas = 0;

        public Categoria()
        {
            DateTime dataInclusao = DateTime.Now;
            status = true;
            nomeCat = "Digite o nome da categoria";
            //nome = "";
            finalizacao = "Cadastrada com sucesso!\n" + "status: " + status + "\nCriação: " + DateTime.Now;    
        }
        
        public void CadCategoria()
        {
            do
            {
                Console.WriteLine(nomeCat);
                nome = Console.ReadLine();
                if (nome.Length <= 0 || nome.Length > 10)
                Console.WriteLine("Digite de 1 a 128 caracteres, apenas de letras");
                tentativas++;
               

            } while (nome.Length <= 0 || nome.Length > 10);
            //Console.Clear();
            Console.WriteLine("Categoria: " + nome);
            Console.WriteLine(finalizacao);
            
        }

        public virtual string GetNovaCategoria
        {
            get { return nome; }
            set { nome = value; }
        }
        }
       
        
    }   

    




