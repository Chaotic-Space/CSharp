internal class Program
{
    private static void Main(string[] args)
    {
        string Phrase_1 = "Anime is";
        string Phrase_2 = " super amazing";
        string Phrase_3 = " and entertaining";
        string Phrase_4 = Phrase_1 + Phrase_2 + Phrase_3;                           //using Phrase_1 + Phrase_2 + Phrase_3, we can add different phrases to a single new Phrase
        int Phrase_4_length = Phrase_4.Length;                                      //.Length is used to calculate length of a phrase

        Console.WriteLine(Phrase_1 + Phrase_2 + Phrase_3);                        //using Phrase_1 + Phrase_2 + Phrase_3, we can write contents of 3 phrases in a single Console.WriteLine
        Console.WriteLine(Phrase_4);
        Console.WriteLine(Phrase_1.ToLower() + Phrase_2.ToUpper() + Phrase_3);      //using .ToLower or .ToUpper we can change the case of a phrase to lower or upper case while printing it
        Console.WriteLine(Phrase_4.Contains("Anime"));                              //using .Contains we can check whether a string contains the specified string. It showes true if the string is present or false if absent. Case sensitive
        Console.WriteLine(Phrase_4.Contains("AnIme"));
        Console.WriteLine(Phrase_4_length);
        Console.WriteLine(Phrase_4[0]);                                             //[] is used to find character at a given index number.
        Console.WriteLine(Phrase_4.IndexOf("super"));                               //.IndexOf is used to find the index of the first char of the specified string
        Console.WriteLine(Phrase_4.Substring(23));                                  //.Substring is used to print the phrase after the specified index number.
        Console.WriteLine(Phrase_4.Substring(9,13));                                //We can also specify a part of the phrase we want to print using .Substring by giving the starting index number and number of characters following it


        Console.ReadLine();
    }
}