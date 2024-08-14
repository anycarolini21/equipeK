using LiteDB;

namespace Modelos
{
    public class Acabamento : Registro
    {
        [BsonId]
        public int Id { get; set; }

        public string Quantidade { get; set; }

        public string Aviamentos { get; set; }

        public string NumeroOp { get; set; }

    }
}