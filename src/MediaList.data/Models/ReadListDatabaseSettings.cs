namespace MediaList.Data.Models
{
    public class MediaListDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string GenreCollectionName { get; set; } = null!;

        public string MediaTypeCollectionName { get; set; } = null!;

        public string MangaCollectionName { get; set; } = null!;
    }
}
