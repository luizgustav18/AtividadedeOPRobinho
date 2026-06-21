using AtividadedePO03;
class Program
{
    static void Main()
    {
        Veiculos _veiculos = Veiculos.EscolherVeiculo();
        _veiculos.ReceberDados();
        if(_veiculos != null)
        {
            _veiculos.CalcularManutencao();
        }
        _veiculos.MostrarDados();
    }
}