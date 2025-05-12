namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"32 degrees celsius is {TempConverter.CelsiusToFahrenheit(32)} degrees fahrenheit.");
            Console.WriteLine($"89.6 degrees fahrenheit is {TempConverter.FahrenheitToCelsius(89.6)} degrees celsius.");
        }
    }
}
