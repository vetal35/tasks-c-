Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
 if (number[0]==number[4] || number[1]==number[3]){ //использую логическое сокращённое или  если одно из условий true , то палиндром  иначе нет //
 Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
 else Console.WriteLine("Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){ // ограничиваю чтоб пятизначное вводил//
 CheckingNumber(number);
} else Console.WriteLine("Введи правильное число");

