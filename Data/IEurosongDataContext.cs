using Eurosong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eurosong.Data
{
    public interface IEurosongDataContext
    {
        // Songs
        void AddSong(Song song);
        IEnumerable<Song> GetSongs();
        Song GetSong(int id);
        IEnumerable<Song> GetSongs(string word);
        IEnumerable<Vote> GetVotesBySongID(int id);
        int GetPointsBySongID(int id);
        void UpdateSong(Song song, int id);
        void DeleteSong(int id);

        // Votes
        IEnumerable<Vote> GetVotes();
        Vote GetVote(int id);
        void AddVote(Vote vote);
        void UpdateVote(Vote vote, int id);
        void DeleteVote(int id);

        // Artists
        IEnumerable<Artist> GetArtists();
        void AddArtist(Artist artist);
        Artist GetArtist(int id);
        IEnumerable<Song> GetSongsByArtistID(int id);
        void UpdateArtist(Artist artist, int id);
        void DeleteArtist(int id);
        string GetArtistPicture(int id);

    }
}
