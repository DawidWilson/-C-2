internal class Program
{
    private static void Main(string[] args)
    {
    string firstWord = "Добиться успеха легко,";
    string secondWord = "познать смысл - вот проблема";

    string union = firstWord + " " + secondWord;
    string sentence = string.Concat(union, "!!!");
    //string cutSentence = sentence.Substring(2);
    string cutSentence = sentence.Substring(0, 8);

        Console.WriteLine(union);
        Console.WriteLine($"{firstWord} {secondWord}");
        Console.WriteLine(sentence);
        Console.WriteLine(cutSentence);

        firstWord = firstWord.Insert(8,secondWord);
        Console.WriteLine(firstWord);
    }
    
}

