namespace Modelos
{
public class Bordado
{
    string Quantidade;
    string Linhas;
    string NumeroOp;
    
    Int64 id;

public void SetQuantidade (string Quantidade )
{
    this.Quantidade  = Quantidade ;
}
public string GetQuantidade ()
{
    return Quantidade ;
}
public void SetLinhas (string Linhas)
{
    this.Linhas = Linhas;
}
public string GetLinhas()
{
    return Linhas;
}
public void SetNumeroOp (string NumeroOp)
{
    this.NumeroOp = NumeroOp;
}
public string GetNumeroOp()
{
    return NumeroOp;
}

}
}