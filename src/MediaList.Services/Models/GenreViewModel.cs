using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Services.Models
{
    public class GenreViewModel : ItemViewModel
    {
        /// <summary>
        /// ID of the Item
        /// </summary>
        public override string? Id { get; set; }
    }
}
