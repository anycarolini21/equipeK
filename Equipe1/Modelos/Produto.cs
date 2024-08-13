using LiteDB;

namespace Modelos
{
public class Produto
{
     [BsonId]
public string NumeroDaOp {get; set;}
public string NomeDoTecido {get; set;}
public string QuantidadeDoTecido {get; set;}
public string Preco {get; set;}
public string Linhas {get; set;}
public string Aviamentos {get; set;}
public string Cortador {get; set;}
public string Estampas {get; set;}
public string Grade {get; set;}

}
}
