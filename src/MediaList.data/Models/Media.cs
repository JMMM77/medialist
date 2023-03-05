using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Data.Models
{
    public class Media : Item
    {
        /// <summary>
        /// ID of the Item
        /// </summary>
        [BsonRepresentation(BsonType.ObjectId)]
        public override string? Id { get; set; } = ObjectId.GenerateNewId().ToString();

        /// <summary>
        /// Alias of the Media 
        /// </summary>
        [BsonElement("Alias")]
        public string Alias { get; set; } = null!;

        /// <summary>
        /// The Media Type Id
        /// </summary>
        [BsonElement("Type")]
        public string Type { get; set; } = null!;

        /// <summary>
        /// The file location of the cover image
        /// </summary>
        [BsonElement("Cover Image")]
        public string CoverImage { get; set; } = null!;

        /// <summary>
        /// The main Author of the Media
        /// </summary>
        [BsonElement("Author")]
        public string Author { get; set; } = null!;

        /// <summary>
        /// The main Author of the Media
        /// </summary>
        [BsonElement("Genres")]
        public string[] Genres { get; set; } = null!;

        /// <summary>
        /// When the Media was release
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime Released { get; set; } = DateTime.Today.Date;

        /// <summary>
        /// The Last time this record was updated
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}
