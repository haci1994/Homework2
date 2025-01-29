////1. Massivin cəmini tapın.

//Console.WriteLine("MASSIVIN CEMINI HESABLAYAN PROQRAM");

//Console.Write("Massiviniz neche elementden ibaretdir? ");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;

//Console.WriteLine($"{n} sayda eded daxil edin:");

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Eded {i + 1}:");
//    int a = int.Parse(Console.ReadLine());
//    sum += a;
//}

//Console.WriteLine($"Massive daxil etdiyiniz ededlerin cemi = {sum}");


////1.1 Massiv üsulu

//Console.Write("Massiviniz neche elementden ibaretdir? ");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//int[] nums = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Eded {i + 1}:");
//    int a = int.Parse(Console.ReadLine());
//    nums[i] = a;
//};

//for (int i = 0;i < n; i++)
//{
//    sum += nums[i];
//};

//Console.WriteLine($"Massive daxil etdiyiniz ededlerin cemi");

//Console.WriteLine("---------------------");

//2.Massivin elementləri arasında ortalamasını tapın.

//Console.WriteLine("MASSIVIN ELEMENTLERI ARASINDA ORTALAMANI TAPAN PROQRAM");

//Console.Write("Massiviniz neche elementden ibaret olacaq? :");
//int n = int.Parse(Console.ReadLine());
//double sum = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{n}. eded:");
//    int a = int.Parse(Console.ReadLine());
//    sum += a;
//};

//Console.WriteLine($"Massivinizin ortalamasi = {sum/n}");

////2.1 Massiv üsulu

//Console.WriteLine("MASSIVIN ELEMENTLERI ARASINDA ORTALAMANI TAPAN PROQRAM");

//Console.Write("Massiv neche elementden ibaret olacaq?");
//int n = int.Parse(Console.ReadLine());
//double sum = 0;
//int[] mass = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{i + 1}. ededi daxil edin:");
//    int a = int.Parse(Console.ReadLine());
//    sum += a;
//    mass[i] = a;
//};

//Console.WriteLine($"Daxil edilen ededlerin ededi ortasi: {sum / n}");

//Console.WriteLine("---------------------");

