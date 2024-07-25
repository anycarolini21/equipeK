namespace Modelos
{
public class Almoxarifado
{
    string Quantidade;
    string MateriaisEnvio;
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
public void SetMateriaisEnvio (string MateriaisEnvio)
{
    this.MateriaisEnvio = MateriaisEnvio;
}
public string GetMateriaisEnvio()
{
    return MateriaisEnvio;
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