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

////3. Massivdə müəyyən bir ədədin olub olmadığını yoxlayın.

//Console.WriteLine("MASSIVDE VERILEN ELEMENTIN OLUB OLMAMASINI YOXLAYAN PROQRAM");

//int[] mass = new int[6];

//mass[0] = 1;
//mass[1] = 2;
//mass[2] = 3;
//mass[3] = 5;
//mass[4] = 6;
//mass[5] = 7;

//Console.Write("Yoxlamaq istediniz ededi daxil edin: ");
//int a = int.Parse(Console.ReadLine());

//for (int i = 0; i < mass.Length; i++)
//{
//    if (mass[i] == a)
//    {
//        Console.WriteLine($"{a} massivde var!");
//        break;
//    }
//    else
//    {
//        Console.WriteLine($"{a} massivde yoxdur!");
//        break;
//    }
//}

//Console.WriteLine("---------------------");

////4. Massivdəki ən kiçik və ən böyük ədədləri tapın.

//Console.WriteLine("MASSIVDE EN BOYUK VE EN KICIK EDEDI TAPAN PROQRAM");

//Console.WriteLine("Massivin element sayini daxil edin (en azi iki element olmalidir): ");
//int n = int.Parse(Console.ReadLine());

//int[] mass = new int[n];

//if (n < 2)
//{
//    Console.WriteLine("Massiv elementinin sayi 2-den az ola bilmez!");
//} else
//{
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write($"{i+1}. ededi daxil edin: ");
//        int a = int.Parse(Console.ReadLine());
//        mass[i] = a;
//    }

//    int min = mass[0];
//    int max = mass[1];

//    for (int i = 0; i < n; i++)
//    {
//        if (mass[i] < min)
//        {
//            min = mass[i];
//        }

//        if (mass[i]>max)
//        {
//            max = mass[i];
//        }
//    }

//    Console.WriteLine($"En boyuk eded {max}, en kicik eded {min}.");
//}

//Console.WriteLine("---------------------");

////5. Massivdəki cüt ədədlərin cəmini tapın.

//Console.WriteLine("MASSIVDE CUT EDEDLERIN CEMINI TAPAN PROQRAM");

//Console.Write("Massiv neche elementden ibaret olacaq? ");
//int n = int.Parse(Console.ReadLine());

//int[] mass = new int[n];
//int sum = 0;

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{i + 1}. elementi daxil edin.");
//    int a = int.Parse(Console.ReadLine());
//    mass[i] = a;
//}

//for (int i = 0;i < n; i++)
//{
//    if (mass[i]%2 == 0)
//    {
//        sum += mass[i];
//    }
//}

//Console.WriteLine($"Cut ededlerin cemi: {sum}");

//Console.WriteLine("---------------------");

////6. Massivin tərsinə dövr etməklə yeni massiv yaradın.

//Console.WriteLine("TERS MASSIVDEN MASSIV YARADAN PROQRAM");

//Console.Write("Ilk massivin element sayini daxil edin: ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];
//int[] reversedMass = new int[n];

//for  (int i = 0; i < n; i++)
//{
//    Console.Write($"{i + 1} sayli elementi daxil edin: ");
//    int a = int.Parse(Console.ReadLine());
//    mass[i] = a;
//}

//for  (int i = 0; i<reversedMass.Length; i++)
//{
//    reversedMass[i] = mass[reversedMass.Length - i-1];
//}

//Console.Write($"Çevrilmiş massiv: ");

//for (int i = 0;i < n; i++)
//{
//    Console.Write($"{reversedMass[i]}, ");
//}

//7. Massivdəki ən böyük iki ədədi tapın.

//Console.WriteLine("MASSIVDEKI IKI EN BOYUK EDEDI TAPAN PROQRAM!");

//Console.Write("Massiv neche elementden ibaret olacaq? ");
//int n = int.Parse(Console.ReadLine());
//int[] mass = new int[n];

//int m1 = 0;
//int m2 = 0;

//if (n >= 2) {
//    for (int i = 0; i < n; i++)
//    {
//        Console.Write($"{i + 1}. eded: ");
//        int a = int.Parse(Console.ReadLine());
//        mass[i] = a;
//    }

//    for (int i = 0; i<n; i++)
//    {
//        if (mass[i] > m1)
//        {
//            m1 = mass[i];
//        }
//    }

//    for (int i = 0;i<n; i++)
//    {
//        if (mass[i] != m1 && mass[i]>m2) {
//            m2 = mass[i];
//        } else
//        {
//            m2 = m1;
//        }
//    }
    
//    Console.WriteLine($"En boyuk birinci eded {m1}, en boyuk ikinci eded {m2}.");

//} else
//{
//    Console.WriteLine("Element sayi en azi 2 olmalidir!");
//}

//Console.WriteLine("---------------------");
