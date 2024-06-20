using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppSQL
{
    internal class AlbumsDOA
    {
        string connectionString = 
            "datasource=localhost;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=music2;";
        public List<Album> albums = new List<Album>();

        public List<Album> getAllAlbums()
        {
            List<Album> albums = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand commnad = new MySqlCommand("SELECT ID," +
                "ALBUM_TITLE," +
                "ARTIST," +
                "YEAR," +
                "IMAGE_NAME," +
                "DESCRIPTION FROM ALBUMS", connection);

            using (MySqlDataReader reader = commnad.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    //album.Tracks = getTracksForAlbum(album.ID);
                    albums.Add(album);
                }
            }
            connection.Close();
            return albums;
        }

        public List<Album> searchTitles(string param)
        {
            List<Album> albums = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string wilcardSearch = "%" + param + "%";
            MySqlCommand commnad = new MySqlCommand("SELECT ID," +
                "ALBUM_TITLE," +
                "ARTIST," +
                "YEAR," +
                "IMAGE_NAME," +
                "DESCRIPTION " +
                "FROM ALBUMS " +
                "WHERE ALBUM_TITLE LIKE @search");
            commnad.Parameters.AddWithValue("@search", wilcardSearch);
            commnad.Connection = connection;
            using (MySqlDataReader reader = commnad.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album album = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5),
                    };
                    albums.Add(album);
                }
            }
            connection.Close();
            return albums;
        }

        internal int addOneAlbum(Album album)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM_TITLE`, " +
                "`ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) " +
                "VALUES (@albumTitle, @artist, @year, @imageURL, @description)", connection);
            command.Parameters.AddWithValue("@albumTitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        public List<Track> getTracksForAlbum(int albumID)
        {
            List<Track> tracks = new List<Track>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define SQL Statemnet
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            // Get Data
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track track = new Track
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4)
                    };
                    tracks.Add(track);
                }
            }
            connection.Close();
            return tracks;
        }

        public List<JObject> getTracksUsingJoin(int albumID)
        {
            List<JObject> tracks = new List<JObject>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define SQL Statemnet
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT tracks.ID, albums.ALBUM_TITLE, track_title, " +
                "number, video_url, lyrics, albums_ID FROM tracks JOIN albums " +
                "ON albums_ID = albums.ID WHERE albums.ID = @albumid";
            command.Parameters.AddWithValue("@albumid", albumID);
            command.Connection = connection;

            // Get Data
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    JObject track = new JObject();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        track.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                    }
                }
            }
            connection.Close();
            return tracks;
        }

        internal int deleteTrack(int trackID)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("DELETE FROM tracks WHERE tracks.ID = @trackID", connection);
            command.Parameters.AddWithValue("@trackID", trackID);
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
