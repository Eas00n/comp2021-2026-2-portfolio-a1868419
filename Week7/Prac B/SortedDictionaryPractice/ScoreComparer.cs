var sortedScores2 = new SortedDictionary<ScoreEntry, Player>(new ScoreComparer());

var players = new List<Player>
{
    new("Yuchen"),
    new("Jun"),
    new("Anon"),
    new("Shanice"),
    new("Ecclesiasticalot"),
    new("Mark"),
    new("Annalie"),
    new("Melissa"),
    new("Askey"),
    new("Alex")
};

public class ScoreComparer : IComparer<ScoreEntry>
{
    public int Compare(ScoreEntry? x, ScoreEntry? y)
    {
        if (x == null || y == null)
        {
            return 0;
        }

        int scoreCompare = x.Score.CompareTo(y.Score);

        if (scoreCompare != 0)
        {
            return scoreCompare;
        }

        return x.StageReached.CompareTo(y.StageReached);
    }
}