//Task-1
//static bool IsPowerOfTwo(int number)
//{
//    if (number <= 0)
//        return false;

//    while (number > 1)
//    {
//        if (number % 2 != 0)
//            return false;
//        number /= 2;
//    }
//    return true;
//}
//Console.Write("Reqem daxil edin: ");
//int sayi = int.Parse(Console.ReadLine());

//if (IsPowerOfTwo(sayi))
//    Console.WriteLine(sayi + " 2'nin quvvetidir.");
//else
//    Console.WriteLine(sayi + " 2'nin quvveti deyildir.");


//Task-2
//static int totalDigits(int n)
//{
//    int digits = 0;

//    for (int i = 1; i <= n; i *= 10)
//        digits += (n - i + 1);

//    return digits;
//}
//int n = 15;

//Console.WriteLine(totalDigits(n));

//Task-3
//Console.Write("Bir ədəd daxil edin: ");
//int eded = Convert.ToInt32(Console.ReadLine());

//bool netice = MukemmelEdedYoxla(eded);

//Console.WriteLine(netice);
//static bool MukemmelEdedYoxla(int eded)
//{
//    int bolenler = 0;

//    for (int i = 1; i <= eded / 2; i++)
//    {
//        if (eded % i == 0)
//        {
//            bolenler += i;
//        }
//    }

//    return bolenler == eded;
//}

//Task-4
//Console.Write("Bir say daxil edin: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//string ikilik = DecimalToBinary(sayi);

//Console.WriteLine($"Sayının ikilik qarsiligi: {ikilik}");
//static string DecimalToBinary(int say)
//{
//    if (say == 0)
//        return "0";

//    string binary = "";
//    while (say > 0)
//    {
//        int kalan = say % 2;
//        binary = kalan + binary;
//        say /= 2;
//    }

//    return binary;
//}

//Task-5 YAZA BILMEDIM


//Task-6
//Console.Write("Pattern uzunluğunu (N) daxil edin: ");
//int N = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= N; i++)
//{
//    for (int j = 0; j < N - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write("* ");
//    }

//    Console.WriteLine();
//}

//Console.ReadLine();