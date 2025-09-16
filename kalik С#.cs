using System;
class Program
{
    static void Main()
    {
        double memory = 0;
        Console.Write("При использовании калькулятора нельзя делить на 0, нельзя вписывать не числа, нельзя чтоб корень был из отрицательного числа ");
        Console.Write("\nВвод первого числа : ");
        string ChA = Console.ReadLine();
        double a;
        if (!double.TryParse(ChA, out a))
        {
            Console.WriteLine("Некорректное число.");
            return;
        }
        Console.Write("Выбор оператора: ");
        string z = Console.ReadLine();
        Console.Write("Ввод второго числа : ");
        string ChB = Console.ReadLine();
        int b;
        if (!int.TryParse(ChB, out b))
        {
            Console.WriteLine("Некорректное число.");
            return;
        }
        string[] validOperators = { "+", "-", "*", "/", "1/a", "**", "корень(a)", "M+", "M-", "MR", "1" };
        if (Array.IndexOf(validOperators, z) == -1)
        {
            Console.WriteLine("Неподдерживаемый оператор.");
            return;
        }
        if (z == "+")
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        else if (z == "-")
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        else if (z == "*")
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        else if (z == "/")
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль недопустимо.");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
        }
        else if (z == "1/a")
        {
            if (a == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль недопустимо для функции 1/a.");
            }
            else
            {
                Console.WriteLine($"1 / {a} = {1 / a}");
            }
        }
        else if (z == "**")
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }
        else if (z == "корень(a)")
        {
            if (a < 0)
            {
                Console.WriteLine("Ошибка. Корень из отрицательного числа недопустим.");
            }
            else
            {
                Console.WriteLine($"√{a} = {Math.Sqrt(a)}");
            }
        }
        else if (z == "M+")
        {
            memory += a;
            Console.WriteLine("Память: " + memory);
        }
        else if (z == "M-")
        {
            memory -= a;
            Console.WriteLine("Память: " + memory);
        }
        else if (z == "MR")
        {
            Console.WriteLine("Из памяти: " + memory);
        }
        else if (z == "1")
        {
            Console.WriteLine("Ошибка. Неподдерживаемый оператор.");
        }
        else
        {
            Console.WriteLine("Ошибка. вы не соблюдали правила!");
        }
    }
}
