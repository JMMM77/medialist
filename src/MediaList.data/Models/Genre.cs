using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Data.Models
{
    public class Genre : Item
    {
        /// <summary>
        /// ID of the Item
        /// </summary>
        public override string? Id { get; set; }
    }
}
