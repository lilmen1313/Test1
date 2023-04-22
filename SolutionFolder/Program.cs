int sizeArray = Input("Введите размер массива: ");
string[] arrayNew = CreateArrayStr(sizeArray);
PrintArrayStr(arrayNew);



string[] CreateArrayStr (int size)
{
    string[] arr = new string[size];
   
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива №{i+1}: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArrayStr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"``{arr[i]}``, ");
        else Console.Write($"``{arr[i]}``");
    }
    Console.WriteLine("]");
}

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}