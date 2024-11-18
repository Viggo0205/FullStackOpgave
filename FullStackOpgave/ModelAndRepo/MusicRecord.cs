
public class MusicRecord
{

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }
    public int Duration { get; set; }
    public int PublicationYear { get; set; }
    public MusicRecord() { }


    public void ValidateTitle()
    {
        if (Title.Length < 2 || Title.Length > 100)
        {
            throw new ArgumentOutOfRangeException("Title must be between 2 and 100 characters long");
        }

    }

    public void ValidateArtist()
    {
        if (Artist.Length < 2 || Artist.Length > 100)
        {
            throw new ArgumentOutOfRangeException("Artist must be between 2 and 100 characters long");
        }
    }

    public void ValidateDuration()
    {
        if (Duration < 1 || Duration > 6000)
        {
            throw new ArgumentOutOfRangeException("Duration must be between 1 and 6000 seconds");
        }
    }

    public void ValidatePublicationYear()
    {
        if (PublicationYear < 1940 || PublicationYear > 2024)
        {
            throw new ArgumentOutOfRangeException("Publication year must be between 1900 and 2024");
        }
    }

    public void ValidateAll()
    {
        ValidateTitle();
        ValidateArtist();
        ValidateDuration();
        ValidatePublicationYear();
    }
}

