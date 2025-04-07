namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
       static Equipamento[] equipamentos = new Equipamento[100];
       static int contadorEquipamentos = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Gestão de Equipamentos");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar novo equipamento: ");
                Console.WriteLine("4 - Visualizar equipamento: ");
                string opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida)

                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Gestão de Equipamentos");
                        Console.WriteLine("----------------------");
                        Console.WriteLine();

                        Console.WriteLine("Cadastrando equipamento...");
                        Console.WriteLine("--------------------------");

                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a fabricante do produto: ");
                        string fabricante = Console.ReadLine();

                        Console.Write("Digite o preço de aquisição do produto: R$ ");
                        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Digite a data de fabricação do produto (MM/dd/yyyy): ");
                        DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                        Equipamento novoEquipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);

                        equipamentos[contadorEquipamentos++] = novoEquipamento;

                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Gestão de Equipamentos");
                        Console.WriteLine("----------------------");
                        Console.WriteLine();

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Visualização de equipamento equipamento...");
                        Console.WriteLine("------------------------------------------");

                        Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -15} | {4, -15} | {5, -10}",
                                          "Id", "nome", "Núm. Série", "Fabricante", "Preço", "Data de fabricação");

                        for (int i = 0; i < equipamentos.Length; i++)
                        {
                            Equipamento eSelecionado = equipamentos[i];
                            if (eSelecionado == null) continue;

                            Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -15} | {4, -15} | {5, -10}",
                            eSelecionado.Id, eSelecionado.Nome, eSelecionado.ObterNumeroSerie(), eSelecionado.Fabricante, eSelecionado.PrecoAquisicao.ToString("C2"), eSelecionado.DataFabricacao);
                        }
                        break;


                    default:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }


                Console.ReadLine();
            }

        }
    }
}
