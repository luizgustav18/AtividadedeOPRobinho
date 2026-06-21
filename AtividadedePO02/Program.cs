using AtividadedePO02;

class Program
{
    static void Main()
    {
        Pagamentos _pagamento = Pagamentos.EscolherPagamento();
        _pagamento.ReceberDados();
        if (_pagamento != null)
        {
            _pagamento.MetododePagamento();
        }
        _pagamento.ProcessarPagamento();
        _pagamento.mostrarDados();
    }
}