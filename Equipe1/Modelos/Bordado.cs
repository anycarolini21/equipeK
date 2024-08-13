using LiteDB;

namespace Modelos
{
public class Bordado
{
     [BsonId]
public string Quantidade { get; set;}
public string Linhas { get; set;}
public string NumeroOp { get; set;}

}
}