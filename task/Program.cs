/*

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”, “Denmark”, “Kazan”] → []

*/

Console.Write("Укажите длинну массива: ");
int userNumberLength = Convert.ToInt32(Console.ReadLine());

string[] GetRandomArray(int userLength) {
    string[] array = new string[userLength];

    for (int i = 0; i < array.Length; i++) {
        Console.Write("Заполните массив: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
        Console.Write($"{array[i]}");
        } else {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine("]");
}

string[] ConvertUserArray(string[] array) {
    string[] converArray = new string[0];
    int count = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            Array.Resize(ref converArray, converArray.Length + 1);
            converArray[count] = array[i];
            count++;
        }
    }
    return converArray;
}

string[] userArray = GetRandomArray(userNumberLength);
PrintArray(userArray);
string[] convertUserArray = ConvertUserArray(userArray);
PrintArray(convertUserArray);