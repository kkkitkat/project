using AiwProj;

var ac = new AirConditioner(20, 5);

while (true)
{


    Console.WriteLine($"Текущая температура: {ac.Temperature}°C");
    Console.WriteLine($"Текущая интенсивность вентилятора: {ac.FanIntensity}");

    Console.WriteLine("\nВыберите действие:");
    Console.WriteLine("0. Выход");
    Console.WriteLine("1. Увеличить температуру");
    Console.WriteLine("2. Уменьшить температуру");
    Console.WriteLine("3. Увеличить интенсивность вентилятора");
    Console.WriteLine("4. Уменьшить интенсивность вентилятора");


    int choice = GetChoice(-1);
    Console.Clear();

    switch (choice)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            ac.IncreaseTemperature();
            break;
        case 2:
            ac.DecreaseTemperature();
            break;
        case 3:
            ac.IncreaseFanIntensity();
            break;
        case 4:
            ac.DecreaseFanIntensity();
            break;
        default:
            Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 5\n");
            break;
    }
}

static int GetChoice(int defaultValue)
{
    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
    {
        return defaultValue;
    }
    return choice;
}