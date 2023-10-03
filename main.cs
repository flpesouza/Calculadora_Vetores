using System;

class Lista4
{
  public static void Main(string[] args)
  {
    int[] x = new int[5];
    int[] y = new int[5];
    int[] resultado = new int[5];
    int[] uniao = new int[10];
    int cont = 0;
    
    for (int i = 0; i < x.Length; i++)
    {
      bool repetido;
    do
    {
      repetido = false;
      Console.Write("Digite o valor de x: ");
      x[i] = int.Parse(Console.ReadLine());
    for (int j = 0; j < i; j++)
    {
    if (x[i] == x[j])
    {
      Console.Write("Elemente repetido! Digite outro valor: ");
      repetido = true;
    break;
    }
    }
    } while (repetido);
    }
    for (int i = 0; i < y.Length; i++)
    {
    bool repetido;
    do
    {
    repetido = false;
    Console.Write("Digite o valor de y: ");
    y[i] = int.Parse(Console.ReadLine());
    for (int j = 0; j < i; j++)
    {
    if (y[i] == y[j])
    {
    Console.Write("Elemente repetido! Digite outro valor: ");
    repetido = true;
    break;
    }
    }
    } while (repetido);
    }
    for(int i=0; i<x.Length; i++)
    {
    resultado[i] = x[i] + y[i];
    Console.WriteLine("Soma da posição "+i+":"+resultado[i]);
    }
    for(int i =0; i < x.Length; i++)
    {
    resultado[i] = x[i] * y[i];
    Console.WriteLine("Produto da posição" + i + ":" + resultado[i]);
    }
    for(int i=0; i<x.Length; i++)
    {
    resultado[i] = x[i] - y[i];
    Console.WriteLine("Diferença da posição " + i + ":" + resultado[i]);
    }
    Console.Write("Elemtos repetidos: ");
    for(int i=0; i < x.Length; i++)
        {
        for(int j=0; j < y.Length; j++)
          {
            if (x[i] == y[j])
            {
              Console.WriteLine(x[i]);
              cont++;
            }
            else
            {
              uniao[i] = x[i];
            }
        }
      }
    for (int i = 0, k = 5; i <y.Length; i++,k++)
      {
        for (int j = 0; j < x.Length; j++)
        {
          if (y[i] != x[j])
          {
            uniao[k] = y[i];
        }
      }
    }
    Console.Write("União: ");
    for(int i=0; i<uniao.Length-cont; i++)
    {
      Console.WriteLine(uniao[i]);
    }
  }
}
