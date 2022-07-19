//Console.Write("Введите трёхзначное число: ");//
//int threeDigitNumber = Convert.ToInt32(Console.ReadLine());//
//string stringNumber = Convert.ToString(threeDigitNumber);
//Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

//  способ второй чеез массив char



Console.WriteLine("Введите трехзначное число");
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 1000 && inputNumber > 99)
{
char[] numberTwo = inputLine.ToCharArray();
Console.WriteLine(numberTwo[1]);
}
else
{
Console.WriteLine("Число не является  трехзначным ");
}
}






