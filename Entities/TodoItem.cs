using MongoDB.Bson.Serialization.Attributes;

namespace Todo_List_Manager___BE.Entities
{
    public class TodoItem
    {
        [BsonId]
        [BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Title"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string? Title { get; set; }
        [BsonElement("IsCompleted"), BsonRepresentation(MongoDB.Bson.BsonType.Boolean)]
        public bool IsCompleted { get; set; }
    }
}
