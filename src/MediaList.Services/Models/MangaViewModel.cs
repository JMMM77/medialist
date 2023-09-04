using MongoDB.Bson.Serialization.Attributes;

namespace MediaList.Services.Models
{
    public class MangaViewModel : MediaViewModel
    {
        /// <summary>s
        /// How many chapters the Manga currently has
        /// </summary>
        public int Chapters { get; set; } = 0;

        /// <summary>
        /// How many volumes the Manga currently has
        /// </summary>
        public int Volumes { get; set; } = 0;

        /// <summary>
        /// The last chapter read
        /// </summary>
        public int LastChapterRead { get; set; } = 0;

        /// <summary>
        /// The Last time this manga was read
        /// </summary>
        [BsonDateTimeOptions]
        public DateTime LastRead { get; set; } = DateTime.Now;

        /// <summary>
        /// What other shows is it linked to
        /// </summary>
        public string LinkedTo { get; set; } = string.Empty;
    }
}
