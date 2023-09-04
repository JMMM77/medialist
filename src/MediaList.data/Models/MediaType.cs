using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MediaList.Data.Models
{
    /// <summary>
    /// Used to represent the diffrent types of media
    /// </summary>
    public class MediaType : Item
    {
        /// <summary>
        /// ID of the Item
        /// </summary>
        public override string? Id { get; set; }
    }
}
