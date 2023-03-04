namespace ReadList.Data.Models
{
    public class ReadListDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string MangaCollectionName { get; set; } = null!;
    }
}
