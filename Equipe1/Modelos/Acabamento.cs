namespace Modelos
{
public class Acabamento
{
    string Quantidade;
    string Aviamentos;
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
public void SetAviamentos (string Aviamentos)
{
    this.Aviamentos = Aviamentos;
}
public string GetAviamentos()
{
    return Aviamentos;
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