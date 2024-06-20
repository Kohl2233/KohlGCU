using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MusicAppSQL
{
    internal class Track
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TrackTitle { get; set; }
        public int Number { get; set; }
        public string VideoURL { get; set; }
        public string Lyrics {  get; set; }

        public Track() 
        {
            this.Id = ObjectId.GenerateNewId().ToString();
        }
    }
}