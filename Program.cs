int array_length = 8;

int[] array_8 = new int[array_length];
for (int i =0;i<array_length;i++)
{
    Random random = new Random();
    int a = random.Next(0, 2);
    array_8[i] = a;
}

//Вывод массива без цикла в виде строки
var str = string.Join(" ", array_8);
Console.WriteLine(str);

//Вывод массива в цикле

for (int i =0;i<array_length;i++)
{
    Console.Write(array_8[i] + " ");
}