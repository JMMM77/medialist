using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Data.Models
{
    /// <summary>
    /// Used to represent a generic object
    /// </summary>
    public abstract class Item
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
