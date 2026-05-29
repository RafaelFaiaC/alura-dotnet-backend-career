using ScreenSound;

/* Commenting this code to test the "challenge" of the course, podcast and episode classes.
Artist queen = new Artist("Queen");

Album QueenAlbum = new Album ("A night at the opera");

Music music1 = new Music (queen, "Love of my life", 216, true);
Music music2 = new Music (queen, "Bohemian Rhapsody", 355, false);

QueenAlbum.AddMusic(music1);
QueenAlbum.AddMusic(music2);

queen.AddAlbum(QueenAlbum);

queen.DisplayArtistAlbums();
Console.WriteLine();
QueenAlbum.DisplayAlbumMusics();
Console.WriteLine();
music1.DisplayMusicDetails();
*/

Episode episode1 = new Episode(2, "The History of Music", 3600);
episode1.AddGuest("Laís");

Episode episode2 = new Episode(1, "The Evolution of Music in Movies", 2700);
episode2.AddGuest("Marilda");

Podcast podcast = new Podcast("Screen Sound", "Rafael");
podcast.AddEpisode(episode1);
podcast.AddEpisode(episode2);
podcast.DisplayPodcastDetails();