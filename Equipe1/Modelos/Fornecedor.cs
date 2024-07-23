namespace Modelos
{
public class Fornecedor
{
    string nome;
    string endereco;
    string email;
    string telefone;
    string tipodemateria;
    string nomedemateria;
    decimal valordemateria;
    Int64 id;

public void Setnome (string nome)
{
    this.nome = nome;
}
public string Getnome()
{
    return nome;
}
public void Setendereco (string endereco)
{
    this.endereco = endereco;
}
public string Getendereco()
{
    return endereco;
}
public void Setemail (string email)
{
    this.email = email;
}
public string Getemail()
{
    return email;
}
public void Settelefone (string telefone)
{
    this.telefone;
}
public string Gettelefone()
{
    return telefone;
}
public void Settipodemateria (string tipodemateria)
{
    this.tipodemateria = tipodemateria;
}
public string Gettipodemateria()
{
    return tipodemateria;
}
public void Setnomedemateria (string nomedemateria)
{
    this.nomedemateria = nomedemateria;
}
public decimal Getnomedemateria()
{
    return nomedemateria;
}
public void Setvalordemateria (decimal valordemateria)
{
    this.valordemateria = valordemateria;
}
public decimal Getvalordemateria()
{
    return valordemateria;
}

}
}