using Eurosong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eurosong.Data
{
    public class EurosongDataList : IEurosongDataContext
    {
        List<Song> songList = new List<Song>();

        public void AddArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public void AddSong(Song song)
        {
            songList.Add(song);
        }

        public void AddVote(Vote vote)
        {
            throw new NotImplementedException();
        }

        public void DeleteArtist(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteSong(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteVote(int id)
        {
            throw new NotImplementedException();
        }

        public Artist GetArtist(int id)
        {
            throw new NotImplementedException();
        }

        public string GetArtistPicture(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Artist> GetArtists()
        {
            throw new NotImplementedException();
        }

        public int GetPointsBySongID(int id)
        {
            throw new NotImplementedException();
        }

        public Song GetSong(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetSongs()
        {
            return songList;
        }

        public IEnumerable<Song> GetSongs(string word)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Song> GetSongsByArtistID(int id)
        {
            throw new NotImplementedException();
        }

        public Vote GetVote(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vote> GetVotes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vote> GetVotesBySongID(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateArtist(Artist artist, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateSong(Song song, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVote(Vote vote, int id)
        {
            throw new NotImplementedException();
        }
    }
}
