Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1= number/10000;
int number5= number%10;
int number2 = (number/1000)%10;
int number4 = (number%100)/10;

if(number>99999||number<10000)
{
Console.WriteLine("Введено не пятизначное число, попробуйте снова: ");
return;
}

if(number4==number2&&number1==number5)
Console.WriteLine("Число является Палиндормом");
else
Console.WriteLine("Число не является Палиндормом");