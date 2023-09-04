using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Services.Models
{
    public abstract class ItemViewModel
    {
        /// <summary>
        /// ID of the Item
        /// </summary>
        [BsonId]
        public abstract string? Id { get; set; }

        /// <summary>
        /// Name of the Item
        /// </summary>
        [BsonElement("Name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Item Description
        /// </summary>
        [BsonElement("Description")]
        public string Description { get; set; } = null!;
    }
}
