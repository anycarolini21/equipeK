using LiteDB;

namespace Modelos
{
public class Fornecedor : Registro
{
     [BsonId]
public string Nome {get; set;}
public string Endereco {get; set;}
public string Email {get; set;}
public string Telefone {get; set;}
public string TipoDeMateria {get; set;}
public decimal NomeDeMateria {get; set;}
public decimal ValorDeMateria {get; set;}

}
}