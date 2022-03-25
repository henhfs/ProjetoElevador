using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador //Classe Elevador e definição de propriedades
    {
        int qtdeAndares;
        int maxPessoas;
        int andarAtual;
        int qtdePessoas;

        public Elevador() //Construtor
        {
            andarAtual = 0; //O elevador inicia no térreo = 0
            qtdePessoas = 0; //O elevador inicia vazio
        }

        public void Inicializar() 
        {
            qtdeAndares = 10; //Quantidade de andares já está definida na inicialização do programa
            maxPessoas = 5;   //Capacidade máxima de pessoas no elevador já definida na inicialização do programa

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Bem vindo(a) ao Projeto Elevador");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Considere que o Prédio possui {0} andares sendo que o Térreo é 0.",qtdeAndares);
            Console.WriteLine("É permitido no máximo {0} pessoas dentro do elevador.",maxPessoas);

        }

        public void Entrar() //Esse método inclui uma pessoa no elevador e verifica se o elevador está cheio 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (qtdePessoas < maxPessoas)
            {
                qtdePessoas++;
                Console.WriteLine("Uma pessoa Entrou! \n\nAndar atual: {0} \n\nPessoas no Elevador: {1}", andarAtual, qtdePessoas);
            }
            else
            {
                
                Console.WriteLine("O Elevador está cheio. Aguarde alguém sair.");
            }
        }

        public void Sair() //Esse método remove uma pessoa do elevador e verifica se o elevador está vazio
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (qtdePessoas > 0)
            {
                qtdePessoas--;
                Console.WriteLine("Uma pessoa Saiu! \n\nAndar atual: {0} \n\nPessoas no Elevador: {1}", andarAtual, qtdePessoas);
            }
            else
            {
                
                Console.WriteLine("O Elevador já está vazio.");
            }
        }

        public void Subir() //Esse método sobe um andar por vez e verifica se o elevador já chegou no último andar
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (andarAtual < qtdeAndares)
            {
                andarAtual++;
                Console.WriteLine("O Elevador subiu um Andar \n\nAndar atual: {0} \n\nPessoas no Elevador: {1}", andarAtual, qtdePessoas);
            }
            else
            {
                
                Console.WriteLine("O Elevador já está no último andar.");
            }
        }

        public void Descer() //Esse método desce um andar por vez e verifica se o elevador já está no térreo
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (andarAtual > 0)
            {
                andarAtual--;
                Console.WriteLine("O Elevador desceu um Andar \n\nAndar atual: {0} \n\nPessoas no Elevador: {1}", andarAtual, qtdePessoas);
            }
            else
            {
                
                Console.WriteLine("O Elevador já está no térreo.");
            }
        }
    }
}















