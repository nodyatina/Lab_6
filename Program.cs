using System;

    namespace Patterns{
        class Program
        {
            static void Main()
            {
                var submarine = new Submarine();
                
                while (true)
                {
                    Console.Write("Введите положение подлодки (surface/submerged): ");
                    var position = Console.ReadLine();
                    
                switch (position.ToLower()) 
                    {
                case "surface":
                    submarine.SetState(new SurfaceState());
                    break;
                case "submerged":
                    submarine.SetState(new SubmergedState());
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    continue;
            }

            Console.WriteLine($"Текущая скорость: {submarine.GetSpeed()} узлов");
        }
            Console.ReadKey();
    }
}
    }
