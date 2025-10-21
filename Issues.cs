Console.WriteLine("Podaj współrzędne (x, y) lub dodaj 'f' aby oznaczyć flagą (np. 2 3 f): ");
string[] input = Console.ReadLine().Split(' ');

if (input.Length >= 2 && int.TryParse(input[0], out int x) && int.TryParse(input[1], out int y))
{
    bool isFlag = input.Length == 3 && input[2].ToLower() == "f";

    if (x >= 0 && x < width && y >= 0 && y < height)
    {
        if (isFlag)
        {
            displayBoard[y, x] = '⚑';
        }
        else
        {

        }
    }
}
