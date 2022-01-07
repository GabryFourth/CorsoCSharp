## Recoursive Fibonacci
```csharp
using System;
namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Length of the Fibonacci Series : ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);

            Console.ReadKey();
        }

        public static void FibonacciSeries(int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write(firstNumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number);
            }
        }
    }
}


/// MODO SEMPLICE
int res = 1;
int cane = 1;
int gatto = 0;

int Fibonacci(int nIterazioni)
{
    gatto = cane;// verde freccia
    cane = res; //freccia blu
    res = cane + gatto; // freccia viola

    if(nIterazioni == 0)
    {
        return res;
    } else
    {
        return Fibonacci(nIterazioni - 1);
    }
}

// vogliamo passsare il numero di iterazioni che deve fare
int risultato = Fibonacci(3);
Console.WriteLine(risultato);

```

---
## Matrice Trasposta
```csharp
public double[,] Transpose(double[,] matrix)
{
    int w = matrix.GetLength(0);
    int h = matrix.GetLength(1);

    double[,] result = new double[h, w];

    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            result[j, i] = matrix[i, j];
        }
    }

    return result;
}
```

---
## Matrice Triangolare Inferiore
```csharp

```

---
## Matrice Triangolare Superiore
```csharp
   
```

---
