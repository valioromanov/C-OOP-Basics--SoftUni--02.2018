using System;

namespace ClassBox
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                var box = new Box(lenght, width, height);

                var volume = box.Volume(lenght, height, width);
                var surfaceArea = box.Surface(lenght, height, width);
                var lateralSurfaceArea = box.LateralSurface(lenght, height, width);
                Console.WriteLine($"Surface Area - {surfaceArea:F2}");
                Console.WriteLine($"Lateral SurfaceArea - {lateralSurfaceArea:F2}");
                Console.WriteLine($"Volume - {volume:F2}");
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);                   
            }
        }
    }
}
