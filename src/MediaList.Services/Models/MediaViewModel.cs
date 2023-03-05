using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Services.Models
{
    public class MediaViewModel : ItemViewModel
    {
        /// <summary>
        /// Alias of the Media
        /// </summary>
        [BsonElement("Alias")]
        public string Alias { get; set; } = null!;

        /// <summary>
        /// The Media Type
        /// </summary>
        [BsonElement("Type")]
        public MediaTypeViewModel Type { get; set; } = null!;

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
        public GenreViewModel[] Genres { get; set; } = null!;

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
