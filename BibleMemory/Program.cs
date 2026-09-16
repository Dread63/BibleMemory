using System.Text.RegularExpressions;

class BibleMemory
{
    static void Main(string[] args)
    {


        String[] verses = { "John 1:1-5", "Matthew 2:6-10", "Psalm 4", "Proverbs 2:5-10" };
        Regex multiVersePattern = new Regex(@":\d[-]\d");
        
        IEnumerable<String> verseQuery =
            from verse in verses
            where multiVersePattern.IsMatch(verse)
            select verse;
        
        foreach (String verse in verseQuery)
        {
            Console.Out.WriteLine(verse);
        }
    }
}

