

static string[] FreeArray()
{
    string[] arrayM = new string[] {"1" , "12", "365", "3652", "Jan", "Feb", "Marth", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "December"};
    string[] array = new string[6];
    int m;
    int j = 0;
    for (int i = 0; i < 6; i++)
    {
        m = new Random().Next(0, 15);
        Console.Write(arrayM[m]);
        Console.Write(" ");
    }
    Console.WriteLine();
    return array;
}    