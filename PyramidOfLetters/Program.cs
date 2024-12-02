using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        Console.WriteLine("Please input a letter.");

        char userInput = Console.ReadKey().KeyChar;
        userInput = char.ToLower(userInput);

        int pyramidMaxLenght = alphabet.Substring(0, alphabet.IndexOf(userInput) + 1).Length;

        string padding = string.Empty;

        for (int i = 0; i <= pyramidMaxLenght; i++)
        {
            padding = new string(' ', pyramidMaxLenght - i);
            string layer = alphabet.Substring(0, i);
            if (layer.Length > 1)
            {
                var leyarLenght = layer.Length;
                var incrementWith = 1;
                for (int j = 0; j < leyarLenght; j++)
                {

                    layer = layer.Insert(j + incrementWith++, " ");
                }
            }
            Console.WriteLine(padding + layer);
        }
    }
}