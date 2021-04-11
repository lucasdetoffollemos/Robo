using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxX, maxY, x, y;
            string posicao, parada;
           
            
            Console.WriteLine("Digite a coordenada x do canto superior direito da tela: ");
            maxX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a coordenada y do canto superior direito da tela: ");
            maxY = Convert.ToInt32(Console.ReadLine());


            while (true)
            {


                Console.WriteLine("Digite P se quiser parar de inserir robos, se quiser inseir robos aperte enter.");
                Console.WriteLine("");
                parada = Console.ReadLine();
                
                if(parada.Equals("p", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }


                Console.WriteLine("Qual o numero da cooredenada  x do robo: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual o numero coordenada  y do robo: ");
                y = Convert.ToInt32(Console.ReadLine());

                //verifica se as coordeanadas x e y são válidas de acordo com o tamanho mininimo(0, 0) e máximo das coordenadas da área
                if (x > maxX || y> maxY || x < 0 || y < 0)
                {
                    Console.WriteLine("Coordenada inválida para  o tamanho da área");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Qual posição o robo se encontra: ");
                posicao = Console.ReadLine();

                //verifica se as posicoes sao válidas
                if(!posicao.Equals("n", StringComparison.OrdinalIgnoreCase)  && !posicao.Equals("l", StringComparison.OrdinalIgnoreCase) && !posicao.Equals("s", StringComparison.OrdinalIgnoreCase) && !posicao.Equals("o", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Opção inválida tente novamente");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }


                Console.Clear();


                string opcao = "";

                do
                {
                    Console.WriteLine("Opções robo");
                    Console.WriteLine("");
                    Console.WriteLine("Clique na letra 'm' para mover o robo");
                    Console.WriteLine("");
                    Console.WriteLine("Clique na letra 'd' para direcionar o robo a direita");
                    Console.WriteLine("");
                    Console.WriteLine("Clique na letra 'e' para direcionar o robo a esquerda");
                    Console.WriteLine("");
                    Console.WriteLine("Clique em 'p'  para o robo para de se movimentar");

                    opcao = Console.ReadLine();

                    //verificando se a opcao é válida
                    if (!opcao.Equals("m", StringComparison.OrdinalIgnoreCase) && !opcao.Equals("d", StringComparison.OrdinalIgnoreCase) && !opcao.Equals("e", StringComparison.OrdinalIgnoreCase) && !opcao.Equals("p", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Opção inválida tente novamente");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    

                    //caso o usuario vire para direita
                    if (opcao.Equals("d", StringComparison.OrdinalIgnoreCase) && posicao.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "l";

                    }
                    else if (opcao.Equals("d", StringComparison.OrdinalIgnoreCase) && posicao.Equals("l", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "s";

                    }
                    else if (opcao.Equals("d", StringComparison.OrdinalIgnoreCase) && posicao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "o";

                    }
                    else if (opcao.Equals("d", StringComparison.OrdinalIgnoreCase) && posicao.Equals("o", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "n";

                    }

                    //caso o usuario vire para esquerda
                    else if (opcao.Equals("e", StringComparison.OrdinalIgnoreCase) && posicao.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "o";

                    }
                    else if (opcao.Equals("e", StringComparison.OrdinalIgnoreCase) && posicao.Equals("o", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "s";

                    }
                    else if (opcao.Equals("e", StringComparison.OrdinalIgnoreCase) && posicao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "l";

                    }
                    else if (opcao.Equals("e", StringComparison.OrdinalIgnoreCase) && posicao.Equals("l", StringComparison.OrdinalIgnoreCase))
                    {
                        posicao = "n";

                    }

                    //caso o usuario se mova
                    else if (opcao.Equals("m", StringComparison.OrdinalIgnoreCase) && posicao.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        y++;

                    }
                    else if (opcao.Equals("m", StringComparison.OrdinalIgnoreCase) && posicao.Equals("l", StringComparison.OrdinalIgnoreCase))
                    {
                        x++;

                    }
                    else if (opcao.Equals("m", StringComparison.OrdinalIgnoreCase) && posicao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    {
                        y--;

                    }
                    else if (opcao.Equals("m", StringComparison.OrdinalIgnoreCase) && posicao.Equals("o", StringComparison.OrdinalIgnoreCase))
                    {
                        x--;

                    }

                    //verifica se as coordeanadas x e y são válidas de acordo com o tamanho mininimo(0,0) e máximo das coordenadas da área
                    if (x > maxX || y > maxY || x < 0 || y < 0)
                    {
                        Console.WriteLine("Coordenada inválida para  o tamanho da área");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                    Console.Clear();

                } while (!opcao.Equals("p", StringComparison.OrdinalIgnoreCase));


                //se alguma coredenada for maior ou menor(0,0) que a área nao mostra essa mensagem
                if (x > maxX || y > maxY || x < 0 || y < 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("O usuário esta na posicão " + x + " " + y + " " + posicao);
                    Console.ReadLine();
                    Console.Clear();
                }
                

            }


           

        }
    }
}
