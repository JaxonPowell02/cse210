using System;

class Reference
{
    private static string[] scripture = new string[]
    {
        "For behold, again I say unto you that if ye will enter in by the way,\n and receive the Holy Ghost, it will show unto you all things what ye should do.",
        "And by the power of the Holy Ghost ye may know the truth of all things."
    };

    private static string[] reference = new string[]
    {
        "2 Nephi 32:5",
        "Moroni 10:6"
    };

    public string GetReferenceAndScripture()
    {
        Random random = new Random();
        int randomNum = random.Next(scripture.Length);
        return $"{reference[randomNum]}  {scripture[randomNum]}";
    }

}