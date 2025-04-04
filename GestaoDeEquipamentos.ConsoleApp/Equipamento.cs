namespace GestaoDeEquipamentos.ConsoleApp
{
    public class Equipamento
    {
        public int Id;
        public string Nome;
        public string Fabricante;
        public decimal PrecoAquisicao;
        public DateTime DataFabricacao;


        public string ObterNumeroSerie()
        {
            string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper();
            return $"{tresPrimeirosCaracteres}-{Id}";
        }
    }
}


