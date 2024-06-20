using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppSQL
{
    internal class AlbumDatabaseService
    {
        string mongoString = "mongodb+srv://Kohl2233:SaltLakeCity2233!@myatlasclusteredu.imodyvo.mongodb.net/?retryWrites=true&w=majority&appName=myAtlasClusterEDU";

        private const string DATABASENAME = "musicDatabase";
        private const string ALBUMCOLLECTION = "albums";

        private MongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Album> albumCollection;

        public AlbumDatabaseService()
        {
            client = new MongoClient(mongoString);
            database = client.GetDatabase(DATABASENAME);
            albumCollection = database.GetCollection<Album>(ALBUMCOLLECTION);
        }

        public List<Album> getAllAlbums()
        {
            var results = albumCollection.Find(x => true).ToList();
            return results;
        }

        public Album getOne(string id)
        {
            Album result = albumCollection.Find(x => x.Id == id).First();
            return result;
        }
        public List<Album> searchTitles(string param)
        {
            List<Album> results = albumCollection.Find(x => x.Title.ToLower().Contains(param.ToLower())).ToList();
            return results;
        }

        public void addOneAlbum(Album album)
        {
            albumCollection.InsertOne(album);
        }


        public int delteOne(string itemNumber)
        {
            long results = albumCollection.DeleteOne(x => x.Id == itemNumber).DeletedCount;
            return (int)results;
        }

        public Album addTrackToAlbum(Album album, Track track)
        {
            if (album.Tracks == null) { album.Tracks = new List<Track>(); }
            album.Tracks.Add(track);
            albumCollection.FindOneAndReplace(a => a.Id == album.Id, album);
            return album;
        }

        public bool deleteOneTrack(Album album, Track track)
        {
            Track foundTrack = album.Tracks.Find(x => x.Id == track.Id);
            bool result = album.Tracks.Remove(foundTrack);
            albumCollection.FindOneAndReplace(a => a.Id == album.Id, album);
            return result;
        }
    }
}
