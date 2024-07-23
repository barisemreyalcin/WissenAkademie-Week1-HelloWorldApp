// See https://aka.ms/new-console-template for more information

int number;
int sqrNumber;

Console.Write("Karesini almak istediğiniz sayıyı giriniz: ");
string strNumber = Console.ReadLine();

//number = Convert.ToInt32(strNumber);
number = int.Parse(strNumber);

sqrNumber = number * number;

Console.WriteLine("Girdiğiniz sayının karesi: " + sqrNumber);
Console.ReadLine(); // Uygulamayı durdurmak için