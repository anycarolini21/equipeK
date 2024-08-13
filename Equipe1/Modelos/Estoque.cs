using LiteDB;

namespace Modelos
{
public class Estoque
{
     [BsonId]
public string Quantidade {get; set;}
public string Aviamentos {get; set;}
public string NumeroOp {get; set;}

}
}