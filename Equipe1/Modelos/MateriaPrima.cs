using LiteDB;

namespace Modelos
{
public class MateriaPrima : Registro
{
     [BsonId] 
public string Nome {get; set;}
public decimal Valor {get; set;}
public string Unidade {get; set;}
public int IdMateria {get; set;}

}

}