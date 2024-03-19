internal class Program
{
    private static void Main(string[] args)
    {
        string CharacterName = "George";
        int CharacterAge = 75;

        /*
        * Character age can be written as
        * int CharacterAge = 70;
        *
        * or as
        *
        * int CharacterAge;
        * CharacterAge = 70
        */


        Console.WriteLine("There once was a man named " + CharacterName);
        Console.WriteLine("His age was " + CharacterAge + " years old");

        CharacterName = "Tom";
        CharacterAge = 90;

        /* By Changing the Character name mid program, earlier statment ie. Console.WriteLine("There once was a man named " + CharacterName);
         * will show the name before the line which in this instance is George but the next statement where CharacterName is used will show the updated
         * name since the value to the variable CharacterName is changed before the statement. Similarly, if the value in the variable CharacterAge is changed
         * at any point in the program, any statement where the variable is used after the value is changed will show the changed value.
         */

        Console.WriteLine("He really liked the name " + CharacterName);
        Console.WriteLine("But did not like being " + CharacterAge);

        Console.ReadLine();
    }
}