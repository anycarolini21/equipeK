namespace Modelos
{
public class Pedidos
{
    string Nome;
    string Endereco;
    string Email;
    string Telefone;
    string Produto;
    string ValorUnidade;
    string Quantidade;
    decimal ValorTotal;
    Int64 id;

public void SetNome (string Nome )
{
    this.Nome  = Nome ;
}
public string GetNome ()
{
    return Nome ;
}
public void SetEndereco (string Endereco)
{
    this.Endereco = Endereco;
}
public string GetEnderecoo()
{
    return Endereco;
}
public void SetEmail (string Email)
{
    this.Email = Email;
}
public string GetEmail()
{
    return Email;
}
public void SetTelefone(string Telefone)
{
    this.Telefone = Telefone;
}
public string GetTelefone (string Telefone)
{
    return Telefone;
}
public void SetProduto (string Produto)
{
    this.Produto = Produto;
}
public string GetProduto()
{
    return Produto;
}
public void SetValorUnidade (string ValorUnidade)
{
    this.ValorUnidade = ValorUnidade;
}
public string GetValorUnidade()
{
    return ValorUnidade;
}
public void SetQuantidade (string Quantidade)
{
    this.Quantidade = Quantidade;
}
public string GetQuantidade()
{
    return Quantidade;
}
public void SetValorTotal (decimal ValorTotal)
{
    this.ValorTotal = ValorTotal;
}
public decimal GetValorTotal()
{
    return ValorTotal;
}

}
}