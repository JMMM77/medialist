using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ReadList.Data.Models
{
    public class Manga
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; } = null!;
    }
}
