internal class Program
{
    private static void Main(string[] args)
    {
            float width = Convert.ToSingle(Console.ReadLine()); //the width of the rectangle
            float height = Convert.ToSingle(Console.ReadLine()); //the height of the rectangle

            Console.WriteLine(width * height); //do the width x the height for the area
    }
}