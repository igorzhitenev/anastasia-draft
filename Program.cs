// int SumOfDigits (int num){
//     if (num==0){
//         return 0;
//     }
//     int sum = num%10 + SumOfDigits(num/10);
//     return sum;
// } 
// Console.Write(SumOfDigits(123));

// void PrintNumbers(int num)
// {
//     if (num == 0)
//     {
//         return;
//     }
//     PrintNumbers(num - 1);

//     Console.Write($"{num} ");
// }
// PrintNumbers(5);

//  void GetOnlySoglLetters(string letters)
//  {
//     string glasniye = "euioay";

//     if (letters.Length < 1)
//     {
//         return;
//     }
 
//     if(char.IsLetter (letters[0]) && !glasniye.Contains(char.ToLower(letters[0])))
//     {
//         Console.Write($"{letters[0]} ");
//     }
//     GetOnlySoglLetters(letters.Substring(1));
//  }

// string letters = Console.ReadLine();

// GetOnlySoglLetters(letters);

// void PrintRange(int m, int n)
// {
//     if (m > n)
//     {
//         return;
//     }
//     Console.Write(m);
//     PrintRange(m + 1, n);
// }

// int m = 1;
// int n = 5;

//     PrintRange(m, n);

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     return Ackermann(m - 1, Ackermann(m, n - 1));
// }

// int m = 3;
// int n = 2;
// Console.WriteLine(Ackermann(m, n));

void PrintReverse(int[] array)
{
    if (array.Length == 0)
    {
        return;
    }
    Console.Write(array[array.Length - 1] + " ");
    PrintReverse(array.Take(array.Length - 1).ToArray());
}

int[] array = new int[] { 1 , 2 , 5 , 0 , 10 , 34  };
PrintReverse(array);