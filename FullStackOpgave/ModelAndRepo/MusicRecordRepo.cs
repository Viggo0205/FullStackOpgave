public class MusicRecordRepo
{
    private readonly List<MusicRecord> musicRecords = new List<MusicRecord>();

    private int _nextid;

    public MusicRecordRepo()
    {
        MusicRecord record1 = new MusicRecord
        {
            Id = 1,
            Title = "The Dark Side of the Moon",
            Artist = "Pink Floyd",
            Duration = 2900,
            PublicationYear = 1973
        };

        MusicRecord record2 = new MusicRecord
        {
            Id = 2,
            Title = "Abbey Road",
            Artist = "The Beatles",
            Duration = 2900,
            PublicationYear = 1969
        };

        MusicRecord record3 = new MusicRecord
        {
            Id = 3,
            Title = "The Wall",
            Artist = "Pink Floyd",
            Duration = 2900,
            PublicationYear = 1979
        };

        Add(record1);
        Add(record2);
        Add(record3);
    }

    public MusicRecord Add(MusicRecord record)
    {
        record.ValidateAll();
        record.Id = _nextid++;
        musicRecords.Add(record);
        return record;
    }

    public List<MusicRecord> GetAll()
    {
        return musicRecords;
    }



}

