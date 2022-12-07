// Написать программу, которая выводит элементы массива длиной меньше чем 3 символа
Console.WriteLine("How many words would you like to enter?");
int n = Convert.ToInt32(Console.ReadLine());
string [] array = new string[n];
string [] b = new string[n];
for (int i =0 ; i< array.Length; i++ )
{
    array[i]=Console.ReadLine();
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i != array.Length-1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");
int j = 0;
for (int i =0 ; i< array.Length; i++ )
{
    if (array[i].Length<=3)
    {
        b[j] = array[i];
        j++;
    }
}
Console.Write("[");
for (int i = 0; i < j; i++)
{
    Console.Write(b[i]);
    if (i != j-1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");

