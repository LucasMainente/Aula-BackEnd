﻿        
        int[] NumeroPar = new int[6];
        int[] NumeroImpar = new int[6];
        int[] numeros = new int[6];

        int Pares = 0, Impares = 0;
        

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Escreva o {i + 1} º número: ");
            int numeroDigitado = int.Parse(Console.ReadLine()!);
            numeros[i] = numeroDigitado;

            if (numeroDigitado % 2 == 0)
            {   
             Pares++;
            }
            else
            {   
            Impares++; 
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {Pares}");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0);
            {
        Console.WriteLine($"Números pares: {numeros[i]}"); 

            }
        }



        Console.WriteLine($"Quantidade de números ímpares: {Impares}");
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] % 2 ==1)
        {
        Console.WriteLine($"Números impares: {numeros[i]}"); 

        }
    }
 
 