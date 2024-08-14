using LiteDB;

namespace Modelos
{
public class Almoxarifado : Registro
{
     [BsonId]
public string Quantidade { get; set;}
public string MateriaisEnvio { get; set;}
public string NumeroOp { get; set;}

}
}