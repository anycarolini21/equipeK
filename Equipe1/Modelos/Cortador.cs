using LiteDB;

namespace Modelos
{
public class Cortador : Registro
{
     [BsonId]
public string Nome {get; set;}

    
}
}