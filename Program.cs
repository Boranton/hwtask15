// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели цифрой: ");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay == 6) {
Console.WriteLine("да");
}
else if (numDay == 7) {
Console.WriteLine("да");
}
else if (numDay > 7) {
Console.WriteLine("В неделе 7 дней");
}

else 
 {
Console.WriteLine("нет");
}
