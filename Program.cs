// Zahid Afsar
// 9/10/23
// Mini Challenge 4
// Ask the user for 2 numbers and than say if they are greater than, equal to, or less than eachother
// Peer reviewed by : Leo Garcia       Peer Comment: I like how it goes 'firstNum is _____ than secondNum' and vice versa. Nothing to add so far.

Console.Clear();

Console.WriteLine("Please enter first number");

int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your first number is {firstNum}");

Console.WriteLine("Please enter second number");

int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your second number is {secondNum}");

if( firstNum > secondNum){
    Console.WriteLine($"{firstNum} is greater than {secondNum}");
}else if(firstNum < secondNum){
    Console.WriteLine($"{firstNum} is less than {secondNum}");
}else{
    Console.WriteLine("Your first number is equal to your second");
}

if( firstNum < secondNum){
    Console.WriteLine($"{secondNum} is greater than {firstNum}");
}else if(firstNum > secondNum){
    Console.WriteLine($"{secondNum} is less than {firstNum}");
}else{
    Console.WriteLine("Your second number is equal to your first");
}