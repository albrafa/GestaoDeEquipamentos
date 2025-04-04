namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipamento equipamentoUm = new Equipamento();
            equipamentoUm.Id = 0001;
            equipamentoUm.Nome = "Laptop";
            equipamentoUm.Fabricante = "Asus";
            equipamentoUm.PrecoAquisicao = 3800;
            equipamentoUm.DataFabricacao = new DateTime(2024,08,11);

            Console.WriteLine(equipamentoUm.Id);
            Console.WriteLine(equipamentoUm.Nome);
            Console.WriteLine(equipamentoUm.Fabricante);
            Console.WriteLine(equipamentoUm.PrecoAquisicao);
            Console.WriteLine(equipamentoUm.DataFabricacao);
            Console.WriteLine(equipamentoUm.ObterNumeroSerie());


            Console.ReadLine();
        }
    }
}
