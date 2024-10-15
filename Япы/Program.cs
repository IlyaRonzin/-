using System;

public class MathProcessor
{   
    public double fraction(double x)//Задание 1.1
    {
        return x - (int)x;
    }
    public int charToNum(char x)//Задание 1.3
    {
        return x - '0';
    }
    public bool is2Digits(int x)//Задание 1.5
    {
       return x/10!=0 && x/100==0; 
    }
    public bool isInRange(int a, int b, int num)//Задание 1.7
    {
        return (num<=a && num>=b)||(num<=b && num>=a);
    }
    public bool isEqual(int a, int b, int c)//Задание 1.9
    {
        return a == b && b==c;
    }
    public int abs(int x)//Задание 2.1
    {
        if (x >= 0)
            return x;
        else
            return x * (-1);
    }
    public bool is35(int x)//Задание 2.3
    {
        if (x % 15 == 0)
            return false;
        else if (x%3!=0 && x%5!=0)
            return false;
        return true;
    }
    public int max3(int x, int y, int z)//Задание 2.5
    {
        int max = x;
        if(max<y)
            max = y;
        if(max<z)
            max = z;
        return max;
    }
    public int sum2(int x, int y)//Задание 2.7
    {
        int sum = x+y;
        if (sum>=10 && sum<=19)
            return 20;
        return sum;
    }
    public String day(int x)//Задание 2.9
    {
        switch(x)
        {
            case 1:
                return "Понедельник";
            case 2:
                return "Вторник";
            case 3:
                return "Среда";
            case 4:
                return "Четверг";
            case 5:
                return "Пятница";
            case 6:
                return "Суббота";
            case 7:
                return "Воскресенье";
            default:
                return "это не день недели";
        }
    }
    public String listNums(int x)//Задание 3.1
    {
        String result = "";
        for(int i = 0; i <= x; i++)
            result = result + i.ToString() + " ";
        return result;
    }
    public String chet(int x)//Задание 3.3
    {
        string result = "";
        for (int i = 0; i <= x; i=i+2)
            result = result + i.ToString() + " ";
        return result;
    }
    public int numLen(long x)//Задание 3.5
    {
        int len = 0;
        while (x > 0)
        {
            x/=10;
            len++;
        }
        return len;
    }
    public void square(int x)//Задание 3.7
    {
        for (int i = 1; i <= x; i++)
        {
            string sqr = "";
            for (int j = 1; j <= x; j++)
                sqr += "*";
            Console.WriteLine(sqr);
        }  
    }
    public void rightTriangle(int x)//Задание 3.9
    {
        for (int i = 1; i <= x; i++)
        {
            string sqr = "";
            for (int j = 1; j <= x-i; j++)
                sqr += " ";
            for (int k = 1; k <= i; k++)
                sqr += "*";
            Console.WriteLine(sqr);
        }
    }
    public int findFirst(int[] arr, int x)//Задание 4.1
    {
        for(int i=0; i<arr.Length;i++)
            if(arr[i] == x)
                return i;
        return -1;
    }
    public int maxAbs(int[] arr)//Задание 4.3
    {
        int max = arr[0];
        for(int i=1; i<arr.Length; i++)       
            if (abs(arr[i]) > abs(max))
                max = arr[i];
        return max;
    }
    public int[] add(int[] arr, int[] ins, int pos)//Задание 4.5
    {
        int[] newArr = new int[ins.Length+arr.Length];
        for(int i = 0; i < pos; i++)
            newArr[i] = arr[i];
        for (int i = 0; i < ins.Length; i++)
            newArr[pos + i] = ins[i];
        for (int i = pos; i < arr.Length; i++)
            newArr[ins.Length + i] = arr[i];
        return newArr;
    }
    public int[] reverseBack(int[] arr)//Задание 4.7
    {
        int[] newArr = new int[arr.Length];
        for(int i = 0; i<arr.Length; i++)
            newArr[i] = arr[arr.Length-1-i];
        return newArr;
    }
    public int[] findAll(int[] arr, int x)//Задание 4.9
    {
        List<int> indices = new List<int>();
        for(int i = 0;i<arr.Length;i++)
            if(arr[i] == x)
                indices.Add(i);

        return indices.ToArray();
    }
    public void PrintIntegerArray(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
            Console.Write(" ");
        }
        Console.WriteLine("");
    }
    public int[] InputIntegerArrayWithValidation(string s, int left, int right)
    {
        Console.WriteLine(s);
        int len = InputIntegerWithValidation("Введите длинну массива", 1, int.MaxValue);
        int[] numbers = new int[1];
        Array.Resize(ref numbers, len);
        Console.WriteLine("Вводите элементы массива через enter");
        for (int i = 0; i < len; i++)
        {
            numbers[i] = InputIntegerWithValidation("", left, right);
        }
        return numbers;
    }
    public int InputIntegerWithValidation(string s, int left, int right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        int a;
        do
        {
            if (s != "") Console.WriteLine(s); // да блен, переписывать 3/4 лабы, поскольку можно реализовать значение по умолчанию.. не
            ok = int.TryParse(Console.ReadLine(), out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        return a;
    }

    public char InputIntegerCharWithValidation(string s, int left, int right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        int a;
        string input;
        char output;
        do
        {
            if (s != "") Console.WriteLine(s); // да блен, переписывать 3/4 лабы, поскольку можно реализовать значение по умолчанию.. не
            input = Console.ReadLine();
            ok = int.TryParse(input, out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        output = Convert.ToChar(input);
        return output;
    }

    public long InputLongWithValidation(string s, long left, long right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        long a;
        do
        {
            Console.WriteLine(s);
            ok = long.TryParse(Console.ReadLine(), out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        return a;
    }

    public double InputDoubleWithValidation(string s, double left, double right) // Ввод целого числа с проверкой правильности ввода, в том числе принадлежности к указанному диапазону.                                                                                         
    {
        bool ok;
        double a;
        do
        {
            Console.WriteLine(s);
            ok = double.TryParse(Console.ReadLine(), out a);
            if (ok)
                if (a < left || a > right)
                    ok = false;
            if (!ok)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nВведенные данные имеют неверный формат или не принадлежат диапазону [{left}; {right}]");
                Console.WriteLine("Повторите ввод\n");
                Console.ForegroundColor = tmp;
            }
        } while (!ok);
        return a;
    }
}
class Program
{
    static void Main()
    {
        int number_q;
        bool end_programm = false;
        int num_debug = 0;// 0 - обычное выполнение программы, иначе от 1 до 20 номер задания, которое будет выполнялся бесконечно
        MathProcessor foo = new MathProcessor();
        /*
        Console.WriteLine(foo.charToNum('3'));
        int output = foo.InputIntegerWithValidation("Введите число от 0 до 3", 0, 3);
        Console.WriteLine(output);
        */
        Console.WriteLine("Лабораторная работа №1\nБлоки по 5 заданий\nМой вариант нечетный\nДля выхода введите 0");
        while (!end_programm)
        {
            if (num_debug == 0)
            {
                number_q = foo.InputIntegerWithValidation("Введите номер задания от 1 до 20", 0, 20);
            }
            else
            {
                number_q = num_debug;
            }
            switch (number_q)
            {
                case 0:
                    Console.WriteLine("Завершение программы");
                    end_programm = true;
                    break;
                case 1:
                    /*
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                    */
                    Console.WriteLine("\nДробная часть");
                    Console.WriteLine(foo.fraction(foo.InputDoubleWithValidation("Введите любое рациональное число", double.MinValue, double.MaxValue)));
                    break;
                case 2:
                    Console.WriteLine("\nСимвол в число");
                    Console.WriteLine(foo.charToNum(foo.InputIntegerCharWithValidation("Введите число от 0 до 9", 0, 9)));
                    break;
                case 3:
                    Console.WriteLine("\nДвузначное");
                    Console.WriteLine(foo.is2Digits(foo.InputIntegerWithValidation("Введите целое число", int.MinValue, int.MaxValue)));
                    break;
                case 4:
                    Console.WriteLine("\nДиапазон");
                    Console.WriteLine(foo.isInRange(foo.InputIntegerWithValidation("Введите целое число a", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число b", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число num", int.MinValue, int.MaxValue)));
                    break;
                case 5:
                    Console.WriteLine("\nРавенство");
                    Console.WriteLine(foo.isEqual(foo.InputIntegerWithValidation("Введите целое число a", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число b", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число c", int.MinValue, int.MaxValue)));
                    break;
                case 6:
                    Console.WriteLine("\nМодуль числа");
                    Console.WriteLine(foo.abs(foo.InputIntegerWithValidation("Введите целое число", int.MinValue, int.MaxValue)));
                    break;
                case 7:
                    Console.WriteLine("\nТридцать пять");
                    Console.WriteLine(foo.is35(foo.InputIntegerWithValidation("Введите целое число", int.MinValue, int.MaxValue)));
                    break;
                case 8:
                    Console.WriteLine("\nТройной максимум");
                    Console.WriteLine(foo.max3(foo.InputIntegerWithValidation("Введите целое число x", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число y", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число z", int.MinValue, int.MaxValue)));
                    break;
                case 9:
                    Console.WriteLine("\nДвойная сумма");
                    Console.WriteLine(foo.sum2(foo.InputIntegerWithValidation("Введите целое число x", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число y", int.MinValue, int.MaxValue)));
                    break;
                case 10:
                    Console.WriteLine("\nДень недели");
                    Console.WriteLine(foo.day(foo.InputIntegerWithValidation("Введите целое число от 1 до 7", int.MinValue, int.MaxValue)));
                    break;
                case 11:
                    Console.WriteLine("\nЧисла подряд");
                    Console.WriteLine(foo.listNums(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue)));
                    break;
                case 12:
                    Console.WriteLine("\nЧетные числа");
                    Console.WriteLine(foo.chet(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue)));
                    break;
                case 13:
                    Console.WriteLine("\nДлина числа");
                    Console.WriteLine(foo.numLen(foo.InputLongWithValidation("Введите целое число", long.MinValue, long.MaxValue)));
                    break;
                case 14:
                    Console.WriteLine("\nКвадрат");
                    foo.square(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue));
                    break;
                case 15:
                    Console.WriteLine("\nПравый треугольник");
                    foo.rightTriangle(foo.InputIntegerWithValidation("Введите натуральное число", 0, int.MaxValue));
                    break;
                case 16:
                    Console.WriteLine("\nПоиск первого значения");
                    Console.WriteLine(foo.findFirst(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число, вхождение которого будет искаться", int.MinValue, int.MaxValue)));
                    break;
                case 17:
                    Console.WriteLine("\nПоиск максимального");
                    Console.WriteLine(foo.maxAbs(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue)));
                    break;
                case 18:
                    Console.WriteLine("\nДобавление массива в массив");
                    int[] arr1 = foo.InputIntegerArrayWithValidation("Элементы 1 массива - целые числа", int.MinValue, int.MaxValue);
                    foo.PrintIntegerArray(foo.add(arr1, foo.InputIntegerArrayWithValidation("Элементы 2 массива - целые числа", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите натуральное число - индекс для вставки", 0, arr1.Length)));
                    break;
                case 19:
                    Console.WriteLine("\nВозвратный реверс");
                    foo.PrintIntegerArray(foo.reverseBack(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue)));
                    break;
                case 20:
                    Console.WriteLine("\nВсе вхождения");
                    foo.PrintIntegerArray(foo.findAll(foo.InputIntegerArrayWithValidation("Элементы массива - целые числа", int.MinValue, int.MaxValue), foo.InputIntegerWithValidation("Введите целое число, вхождение которого будет искаться", int.MinValue, int.MaxValue)));
                    break;
                default:
                    break;
            }
        }
    }
}