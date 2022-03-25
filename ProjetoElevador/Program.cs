using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{   
    internal class Program
    { 
        static void Main(string[] args)
        {
            bool continuar = true;
                        
            Elevador controle = new Elevador(); //Instância da classe Elevador

            controle.Inicializar(); //Chama o método que inicializará o programa

            do
            {   Console.ResetColor();
                Console.WriteLine(@"
----------------------------------------------------------------
Escolha uma opção:

1 - Entrar no Elevador
2 - Sair do Elevador
3 - Subir um Andar
4 - Descer um Andar

5 - Finalizar");

                
                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();

                //Mantém a exibição das informações básicas para o usuário após o clear
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Projeto Elevador");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Considere que o Prédio possui 10 andares sendo que o Térreo é 0.");
                Console.WriteLine("É permitido no máximo 5 pessoas dentro do elevador.");
                Console.WriteLine("----------------------------------------------------------------\n");


                //Cada case chamará o método correspondente a opção selecionada no menu
                switch (opcaoEscolhida)
                {
                    case "1": controle.Entrar(); break;
                    case "2": controle.Sair(); break;
                    case "3": controle.Subir(); break;
                    case "4": controle.Descer(); break;
                    case "5": Console.WriteLine("Finalizar o programa. Obrigado por utilizar o Projeto Elevador."); continuar = false; break; 
                    default:  Console.ForegroundColor = ConsoleColor.Yellow;
                              Console.WriteLine("Escolha uma opção válida."); break;
                }
            }

            while (continuar); //Continua executando o programa enquanto "continuar"=true        
        }

    }

    }

