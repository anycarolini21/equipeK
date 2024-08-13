using LiteDB;

namespace Modelos
{
public class Costura
{
     [BsonId]
public string Quantidade {get; set;}
public string Aviamentos {get; set;}
public string NumeroOp {get; set;}

}
}