static void Main(string[] args)
{
    string answer;

    float height;
    float width;
    float radius;

    float result;

    Console.WriteLine("What shape would you like to find the area of? Please enter 'R' for rectangle or any other key for circle.");

    answer = Console.ReadLine();

    if (answer == "R")
    {
        Console.WriteLine("Please enter the height of the rectangle.");
        height = float.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the width of the rectangle.");
        width = float.Parse(Console.ReadLine());

        result = height * width;
    }
    else
    {
        Console.WriteLine("Please enter the radius of the circle.");
        radius = float.Parse(Console.ReadLine());

        result = (float)Math.PI * (radius * radius);
    }

    Console.WriteLine("The result is " + result);

    Console.ReadKey();
}