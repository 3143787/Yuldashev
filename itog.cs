// See https://aka.ms/new-console-template for more informatio

string[] array=GetMasiv();



string[] GetMasiv()
{
int n = GetNumberFromUser("Количество элементов массива= ", "ошибка ввода");
string[] array = new string [n];
Console.Write("Введити строки масива, для прекращения ввода введите q \n");
for (int i = 0; i < n; i++)

{     string a =Console.ReadLine();
    if (a == "q") break;
    array[i]=a;

}
return array;
}



int GetNumberFromUser(string message, string errorMessage)  //проверяет число
{
    while(true)
     {
         Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber); 
        if(isCorrect)
             return userNumber;
        Console.WriteLine(errorMessage);
    }
}

