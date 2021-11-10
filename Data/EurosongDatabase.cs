using Eurosong.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eurosong.Data
{
    public class EurosongDatabase : IEurosongDataContext
    {
        LiteDatabase database = new LiteDatabase(@"data.db");

        // Songs
        public void AddSong(Song song)
        {
            database.GetCollection<Song>("Songs").Insert(song);
        }

        public Song GetSong(int id)
        {
            return database.GetCollection<Song>("Songs").FindById(id);
        }

        public IEnumerable<Song> GetSongs()
        {
            return database.GetCollection<Song>("Songs").FindAll();
        }

        public IEnumerable<Song> GetSongs(string word)
        {
            return database.GetCollection<Song>("Songs").Find(s => s.Title.Contains(word));
        }

        public IEnumerable<Vote> GetVotesBySongID(int id)
        {
            return database.GetCollection<Vote>("Votes").Find(s => s.SongID.Equals(id));
        }
        public int GetPointsBySongID(int id)
        {
            List<Vote> collection = database.GetCollection<Vote>("Votes").Find(s => s.SongID.Equals(id)).ToList();
            return collection.Sum(c => c.Points);
        }
        public void UpdateSong(Song song, int id)
        {
            database.GetCollection<Song>("Songs").Update(id, song);
            
        }
        public void DeleteSong(int id)
        {
            database.GetCollection<Song>("Songs").Delete(id);
        }

        // Votes
        public IEnumerable<Vote> GetVotes()
        {
            return database.GetCollection<Vote>("Votes").FindAll();
        }

        public void AddVote(Vote vote)
        {
            database.GetCollection<Vote>("Votes").Insert(vote);
        }

        public Vote GetVote(int id)
        {
            return database.GetCollection<Vote>("Votes").FindById(id);
        }

        public void UpdateVote(Vote vote, int id)
        {
            database.GetCollection<Vote>("Votes").Update(id, vote);
        }

        public void DeleteVote(int id)
        {
            database.GetCollection<Vote>("Votes").Delete(id);
        }

        // Artists
        public IEnumerable<Artist> GetArtists()
        {
            return database.GetCollection<Artist>("Artists").FindAll();
        }

        public void AddArtist(Artist artist)
        {
            database.GetCollection<Artist>("Artists").Insert(artist);
        }

        public Artist GetArtist(int id)
        {
            return database.GetCollection<Artist>("Artists").FindById(id);
        }

        public IEnumerable<Song> GetSongsByArtistID(int id)
        {
            return database.GetCollection<Song>("Songs").Find(s => s.ArtistID.Equals(id));
        }

        public void UpdateArtist(Artist artist, int id)
        {
            database.GetCollection<Artist>("Artists").Update(id, artist);
        }

        public void DeleteArtist(int id)
        {
            database.GetCollection<Artist>("Artists").Delete(id);
        }

        public string GetArtistPicture(int id)
        {
            Artist entity = database.GetCollection<Artist>("Artists").Find(a => a.ID.Equals(id)).First();
            return entity.Picture;
        }
    }
}
