
        
        string senhaCorreta = "1234";
        
       
        Console.Write("Digite a senha: ");
        string senhaInserida = Console.ReadLine();
        
     
        if (senhaInserida == senhaCorreta)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }
    