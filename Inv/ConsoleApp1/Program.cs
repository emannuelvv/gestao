using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario

{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;


        Gotinho:

            Console.Clear();

            Console.WriteLine("Digite a opção: 1 Para equipamentos /2 para chamados /3 para sair");

            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)/*equip*/
            {
                Console.Clear();

                DateTime[] data = new DateTime[300];
                string[] nome = new string[300], fabricante = new string[300];
                int contadorId = 0;
                double[] preco = new double[300];
                int[] serie = new int[300];

                Console.Clear();

                while (true)
                {
                    Console.Clear();

                    int opcaoEquipamento;
                    Console.WriteLine("Digite a opção: 1 Para adicionar /2 para editar /3 para deletar /4 para vizualizar /5 para sair");

                    opcaoEquipamento = Convert.ToInt32(Console.ReadLine());

                    if (opcaoEquipamento == 1)/*add*/
                    {
                        Console.Clear();

                        Console.WriteLine("Digite NS: ");
                        serie[contadorId] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite nome do produto: ");
                        nome[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite fabricante do produto: ");
                        fabricante[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite preço: ");
                        preco[contadorId] = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("Digite data:(YYYY,MM,DD)");
                        data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                        contadorId++;/*alimentando ID*/

                    }


                    if (opcaoEquipamento == 2)/*edit*/

                    {
                        Console.Clear();

                        Console.WriteLine("Digite o ID do produto para editar: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < contadorId; i++)
                        {
                            if (serie[i] == serieBusca)
                            {
                                Console.WriteLine("Digite NS: ");
                                serie[i] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Digite nome do produto: ");
                                nome[i] = Console.ReadLine();

                                Console.WriteLine("Digite fabricante do produto: ");
                                fabricante[i] = Console.ReadLine();

                                Console.WriteLine("Digite preço: ");
                                preco[i] = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Digite data:(YYYY,MM,DD)");
                                data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                            }
                        }

                    }

                    if (opcaoEquipamento == 3)/*delete*/

                    {
                        Console.Clear();

                        Console.WriteLine("Digite ID do produto para edição: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < contadorId; i++)

                        {
                            if (serie[i] == serieBusca)
                            {

                                serie[i] = 0;
                                nome[i] = "";
                                fabricante[i] = "";

                                preco[i] = 0;


                                data[i] = Convert.ToDateTime("0000,00,00");
                            }
                        }
                    }

                    if (opcaoEquipamento == 4)/*vizu*/

                    {
                        for (int i = 0; i < contadorId; i++)
                        {
                            Console.WriteLine($"ID:{serie[i]} nome: {nome[i]} fabricante: {fabricante[i]} preco: {preco[i]} data: {data[i]}");
                        }
                        Console.ReadLine();
                    }

                    else if (opcaoEquipamento == 5)/*opções*/

                    {
                        goto Gotinho;/*goto sair do loop*/
                    }

                }
            }

            if (opcao == 2)/*chamados*/

            {
                Console.Clear();

                DateTime[] data = new DateTime[300];
                string[] nome = new string[300], descricao = new string[100], equipamentos = new string[300];
                int contadorId = 0;
                Console.Clear();

                while (true)

                {
                    Console.Clear();

                    int opcaoChamado;
                    Console.WriteLine("Digite a opção: 1 Para criar /2 para editar /3 para excluir /4 para listar /5 para voltar");
                    opcaoChamado = Convert.ToInt32(Console.ReadLine());

                    if (opcaoChamado == 1)/*add*/

                    {
                        Console.Clear();

                        Console.WriteLine("Digite um título para o chamado : ");
                        nome[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite descricao do produto: ");
                        descricao[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite qual equipamento: ");
                        equipamentos[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite data:(YYYY,MM,DD)");
                        data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                        contadorId++;

                    }

                    if (opcaoChamado == 2)/*edit*/

                    {
                        Console.Clear();

                        Console.WriteLine("Digite a titulo do chamado para editar: ");
                        string titulo = Console.ReadLine();

                        for (int i = 0; i < contadorId; i++)

                        {
                            if (nome[i] == titulo)
                            {
                                Console.Clear();

                                Console.WriteLine("Digite título do chamado: ");
                                nome[i] = Console.ReadLine();

                                Console.WriteLine("Digite descricao do produto: ");
                                descricao[i] = Console.ReadLine();

                                Console.WriteLine("Digite equipamento: ");
                                equipamentos[i] = Console.ReadLine();

                                Console.WriteLine("Digite data:(YYYY,MM,DD)");
                                data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                            }
                        }

                    }

                    if (opcaoChamado == 3)/*delete*/

                    {
                        Console.Clear();

                        Console.WriteLine("Digite a titulo para deletar: ");
                        string titulo = Console.ReadLine();

                        for (int i = 0; i < contadorId; i++)

                        {
                            if (nome[i] == titulo)
                            {

                                nome[i] = "";
                                descricao[i] = "";
                                equipamentos[i] = "";
                                data[i] = Convert.ToDateTime("0000,00,00");
                            }
                        }

                    }

                    if (opcaoChamado == 4)/*vizu*/

                    {

                        for (int i = 0; i < contadorId; i++)

                        {
                            string diasDif = (DateTime.Now - data[i]).ToString("dd");
                            Console.WriteLine($"Título:{nome[i]} descrição: {descricao[i]} equipamento: {equipamentos[i]} dias em aberto: {diasDif}");
                        }
                        Console.ReadLine();
                    }

                    else if (opcaoChamado == 5)/*opções*/

                    {
                        goto Gotinho;/*goto sair do loop*/
                    }
                }
            }

            if (opcao == 3)

            {
                Environment.Exit(0);
            }

        }
    }
}
