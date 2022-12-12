

string[] array=GetMasiv();

string[] array2= chengearray(array);

PrintArray(array2);



string[] GetMasiv()   \\ задаём первый массив
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



string[] chengearray(string[] array)   \\ создём массив из трёхсимвольных элементов
{ int m=0;
   string[] array2=new string[array.GetLength(m)];
for (int i = 0; i < array.GetLength(0); i++)
{  
   if (array[i].Length<=3)
   {array2[m]=array[i];
 m++;
   }

}
return array2;
}





void PrintArray(string[] result )  // пишет масивx
{


for (int i = 0; i < result.GetLength(0) ; i++)
{
 
 
  Console.Write($"   {result[i]}   ");
}
}
 
