int sizeArray = Input("Введите размер массива: ");
string[] array = CreateArrayStr(sizeArray);
PrintArrayStr(array);

int quantityChar = Input("Введите кол-во символов и получите новый массив из строк, длина которых не будет превышать это кол-во: ");
string[] newArrStr = ArraySortingStr(array, quantityChar);
PrintArrayStr(newArrStr);


string[] ArraySortingStr(string[] array, int lengt) // метод, который формирует новый массив из строк, длина которых <= lengt
{
    string[] arrNew = new string[AmountOfElements(array, lengt)];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengt) arrNew[count++] = array[i];
    }
    return arrNew;
}

int AmountOfElements(string[] arr1, int leng) // метод, который подсчитывает кол-во строк в массиве, длина которых <= leng
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= leng) count++;
    }
    return count;
}

string[] CreateArrayStr(int size) // создание нового массива, элементы которого являются строками (заполнение с клавиатуры)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        do
        {
            Console.Write($"Введите элемент массива №{i + 1}: ");
            arr[i] = Console.ReadLine();
        }
        while (arr[i].Length == 0);
    }
    Console.WriteLine("");
    return arr;
}

void PrintArrayStr(string[] arr) // печать массива (вывод на экран)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"``{arr[i]}``, ");
        else Console.Write($"``{arr[i]}``");
    }
    Console.WriteLine("]");
    Console.WriteLine("");
}

int Input(string text) // запрос на ввод
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}