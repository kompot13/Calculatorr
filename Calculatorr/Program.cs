while (true)
{
    Console.Clear();
    double firstValue, secondValue;
    string action;

    try
    {
        Console.WriteLine("Введите первое число");
        firstValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        secondValue = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Ошибка! Попробуйте заново");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Выберите доступную операцию: сложение, вычитание, умножение, деление");
    action = Console.ReadLine();

    switch (action)
    {
        case "+":
            Console.WriteLine(firstValue + secondValue);
            break;

        case "-":
            Console.WriteLine(firstValue - secondValue);
            break;

        case "*":
            Console.WriteLine(firstValue * secondValue);
            break;

        case "/":
            if (secondValue == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(firstValue / secondValue);
            }
            break;
    }

    Console.ReadLine();
}