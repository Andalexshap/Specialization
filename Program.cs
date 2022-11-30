Console.WriteLine("Программа примет данные и выдаст в резальтате только те, которые соответствуют условию.");

int number = InputNumber("Введите количество строк, которое необходимо принять:");

string[] inputData = InputStringToArray(number);

string[] selectingInputDataByLenght = SelectingElementsByLength(inputData, 3);


#region Methods
int InputNumber(string message, bool number = false)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine(), out int value);

        if (!result)
        {
            Console.WriteLine($"Введены некоректные данные. {message} еще раз!");
            Thread.Sleep(1500);
            Console.Clear();

            continue;
        }

        return value;
    }
}

string[] InputStringToArray(int size)
{
    string[] inputData = new string[size];
    for (int i = 0; i < size; i++)
    {
        inputData[i] = Console.ReadLine() ?? "null";
    }

    return inputData;
}

string[] SelectingElementsByLength(string[] array, int lenght)
{
    string[] selectingArray = array.Where(x => x.Length <= lenght).ToArray();
    return selectingArray;
}
#endregion