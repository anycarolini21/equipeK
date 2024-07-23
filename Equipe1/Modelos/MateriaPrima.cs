namespace Modelos
{
public class MateriaPrima
{
    string Nome;
    string Tipo;
    decimal Valor;
    string Unidade;
    int IdMateria;
    Int64 id;

public void SetNome (string Nome)
{
    this.Nome = Nome;
}
public string GetNome()
{
    return Nome;
}
public void SetValor (decimal Valor)
{
    this.Valor = Valor;
}
public decimal GetValor()
{
    return Valor;
}
public void SetUnidade (string Unidade)
{
    this.Unidade = Unidade;
}
public string GetUnidade()
{
    return Unidade;
}
public void SetIdMateria (int IdMateria)
{
    this.IdMateria = IdMateria;
}
public int GetIdMateria()
{
    return IdMateria;
}
}

}