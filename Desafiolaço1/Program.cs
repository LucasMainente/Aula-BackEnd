
        int totalSim = 0;
        int totalNao = 0;
        int totalMulheresSim = 0;
        int totalHomens = 0;
        int totalHomensNao = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Entrevista {i + 1}:");
            Console.Write("Informe o sexo (M/F): ");
            float sexo = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); 
            Console.Write("Gostou do produto? (S/N): ");
            float resposta = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); 

          
            if (resposta == 'S')
            {
                totalSim++;
                if (sexo == 'F')
                {
                    totalMulheresSim++;
                }
            }
            else if (resposta == 'N')
            {
                totalNao++;
                if (sexo == 'M')
                {
                    totalHomensNao++;
                }
            }

           
            if (sexo == 'M')
            {
                totalHomens++;
            }
        }

        
        float porcentagemHomensNao = totalHomens > 0 ? (float)totalHomensNao / totalHomens * 100 : 0;

        
        Console.WriteLine($"\nNúmero de pessoas que responderam SIM: {totalSim}");
        Console.WriteLine($"Número de pessoas que responderam NÃO: {totalNao}");
        Console.WriteLine($"Número de mulheres que responderam SIM: {totalMulheresSim}");
        Console.WriteLine($"Porcentagem de homens que responderam NÃO: {porcentagemHomensNao:F2}%");
