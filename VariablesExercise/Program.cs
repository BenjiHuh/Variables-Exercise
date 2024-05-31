namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Benjamin";
            int age = 18;
            char favoriteChar = 's';
            bool isFullstack = true;
            double pi = 3.14;
            decimal longerPi = 3.14159265358979323856264338m;
            Console.WriteLine("Hello, World!" + $" \n My name is {name} and I am {age} years old.\n");
            Console.WriteLine($"My favorite letter is {favoriteChar}");
            Console.WriteLine($"It is {isFullstack} that I am currently bootcamping for the summer of 2024, to which I have " +
                $"learned to print {pi} using string-interpolation and declare decimals like {longerPi} in addition to floats and doubles.");      
        }
    }
}
