using System.Threading.Channels;

namespace GestaoDeEquipamentos.ConsoleApp
{
   public class TelaEquipamento
    {

        public Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos = 0;
        public string ApresentarMenu()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Cadastrar novo equipamento: ");
            Console.WriteLine("2 - Editar equipamento: ");
            Console.WriteLine("3 - Excluir equipamento: ");
            Console.WriteLine("4 - Visualizar equipamento: ");
            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;
        }

        public void CadastrarEquipamento()
        {
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
        }

        public void EditarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------");
            Console.WriteLine();

            Console.WriteLine("Editando equipamento...");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            VisualizarEquipamentos(false);
            Console.Write("Digite o ID do equipamento que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a fabricante do produto: ");
            string fabricante = Console.ReadLine();

            Console.Write("Digite o preço de aquisição do produto: R$ ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do produto (MM/dd/yyyy): ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);

            bool conseguiuEditar = false;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;

                else if (equipamentos[i].Id == idSelecionado)
                {
                    equipamentos[i].Nome = novoEquipamento.Nome;
                    equipamentos[i].Fabricante = novoEquipamento.Fabricante;
                    equipamentos[i].PrecoAquisicao = novoEquipamento.PrecoAquisicao;
                    equipamentos[i].DataFabricacao = novoEquipamento.DataFabricacao;

                    conseguiuEditar = true;
                }
            }

            if (!conseguiuEditar)
            {
                Console.WriteLine("Houve um erro durante a edição de um registro...");
                return;
            }

            Console.WriteLine("O equipamento foi editado com sucesso.");

        }

        public void ExcluirEquipamento()
        {
            throw new NotImplementedException();
        }

        public void VisualizarEquipamentos(bool exibirTitulo)
        {

            if (exibirTitulo)
            {
                Console.Clear();
                Console.WriteLine("----------------------");
                Console.WriteLine("Gestão de Equipamentos");
                Console.WriteLine("----------------------");
                Console.WriteLine();

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Visualização de equipamento equipamento...");
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine();

            Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -15} | {4, -15} | {5, -10}",
                              "Id", "nome", "Núm. Série", "Fabricante", "Preço", "Data de fabricação");

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento eSelecionado = equipamentos[i];
                if (eSelecionado == null) continue;

                Console.WriteLine("{0, -10} | {1, -15} | {2, -15} | {3, -15} | {4, -15} | {5, -10}",
                eSelecionado.Id, eSelecionado.Nome, eSelecionado.ObterNumeroSerie(), eSelecionado.Fabricante, eSelecionado.PrecoAquisicao.ToString("C2"), eSelecionado.DataFabricacao.ToShortDateString());
            }
        }


    }
}
