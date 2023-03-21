class Song
{
    public string title;
    public string artist;
    private int duration;
    public static int songCount = 0; //Sample of Static Class Attribute


    public Song(string aTitle, string aArtist, int aDuration)
    {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;
        songCount++; // Every song is created, songCount value increments.
    }

    public int getSongCount()
    {
        return songCount;
    }

}