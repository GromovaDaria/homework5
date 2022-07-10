//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*List<int> GetNumbers(int numberOfNumbers) {
    var list = new List<int>();
    var random = new Random();

    for(var i = 0; i < numberOfNumbers; i++) list.Add(random.Next(100, 999));
    
    return list;
}

Console.Write("How many random numbers do you want to generate? Write here: ");
var amountOfNumbers = Console.ReadLine();

if (Int32.TryParse(amountOfNumbers, out var parsedAmountOfNumbers) && parsedAmountOfNumbers > 0) {
    var numberList = GetNumbers(parsedAmountOfNumbers);
    var amountOfEvenNumbers = 0;

    Console.WriteLine("Numbers generated are: ");
    foreach (var number in numberList) {
        if (number%2 == 0) amountOfEvenNumbers++;

        Console.WriteLine(number);
    }

    Console.WriteLine($"There are {amountOfEvenNumbers} even numbers.");
}

else {
    Console.WriteLine("Number is not in correct format");
}
*/

//Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*List<int> GetNumbers(int numberOfNumbers) {
    var list = new List<int>();
    var random = new Random();

    for(var i = 0; i < numberOfNumbers; i++) list.Add(random.Next(100, 999));
    
    return list;
}

Console.Write("How many random numbers do you want to generate? Write here: ");
var amountOfNumbers = Console.ReadLine();

if (Int32.TryParse(amountOfNumbers, out var parsedAmountOfNumbers) && parsedAmountOfNumbers > 0) {
    var numberList = GetNumbers(parsedAmountOfNumbers);
    var sumOfElementsInOddPositions = 0;

    Console.WriteLine("Numbers generated are: ");

    for (var i = 0; i < numberList.Count; i++) {
        if (i%2 != 0) sumOfElementsInOddPositions += numberList[i];

        Console.WriteLine(numberList[i]);
    }

    Console.WriteLine($"The sum of odd position numbers are {sumOfElementsInOddPositions}.");
}

else {
    Console.WriteLine("Number is not in correct format");
}
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
List<int> GetNumbers(int numberOfNumbers) {
    var list = new List<int>();
    var random = new Random();

    for(var i = 0; i < numberOfNumbers; i++) list.Add(random.Next(1, 999));
    
    return list;
}

Console.Write("How many random numbers do you want to generate? Write here: ");
var amountOfNumbers = Console.ReadLine();

if (Int32.TryParse(amountOfNumbers, out var parsedAmountOfNumbers) && parsedAmountOfNumbers > 0) {
    var numberList = GetNumbers(parsedAmountOfNumbers);
    var differenceOfMinAndMax = numberList.Max() - numberList.Min();

    Console.WriteLine("Numbers generated are: ");
    foreach (var number in numberList) {
        Console.WriteLine(number);
    }

    Console.WriteLine($"The difference between min number and max number is {differenceOfMinAndMax}.");
}

else {
    Console.WriteLine("Number is not in correct format");
}