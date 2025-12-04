namespace Task5;

public class Music
{
    public string songName;
    public string songDuration;

    public Music(string songName, string songDuration)
    {
        this.songName = songName;
        this.songDuration = songDuration;
    }

    public override string ToString()
    {
        return $"{songName} ({songDuration})";
    }
}