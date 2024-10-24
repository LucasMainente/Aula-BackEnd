

Console.WriteLine(@"
                   +----------------------------------------------+
                   |                 Menu de opcoes               |
                   +----------------------------------------------+
                   |- 01 - Cadastrar Cliente                      |
                   |- 02 - Cadastrar produto                      |
                   |- 03 - Imprimir relatorio de clientes         |
                   |- 50 - Exibir o menu de opcoes                |
                   |- 99 - Sair do programa                       |
                   |----------------------------------------------|");


                   Console.WriteLine($"Ola escolha a opção que deseja");
                   
                   String Cadastrar = Console.ReadLine();

                   Console.WriteLine($"Voce escolheu cadastro Realize-o");

                   Console.WriteLine($"Digite seu nome");
                   String nome = Console.ReadLine();

                   

                  

                   Console.WriteLine($"Em que ano voce nasceu");
                   
                     int anoNascimento = int.Parse(Console.ReadLine());
                     int anoAtual = DateTime.Now.Year;
                    int idade = anoAtual - anoNascimento;

                  Console.WriteLine($"Informe seu email");
                  String Email = Console.ReadLine();

                 Console.WriteLine($"Informe seu telefone");
                string telefone = Console.ReadLine();

                 Console.WriteLine($"Cpf");
                 string cpf = Console.ReadLine();

                 Console.WriteLine($"Informe seu estado civil");
                 String estadoCivil = Console.ReadLine();



                

                Console.WriteLine($"Voce concluiu o cadastro suas informacoes sao : \n");

                 Console.WriteLine($"Nome:{nome}");
                 Console.WriteLine($"   ");
                 Console.WriteLine($"Idade:{idade}");
                  Console.WriteLine($"   ");
                 Console.WriteLine($"Email:{Email}");
                  Console.WriteLine($"   ");
                 Console.WriteLine($"Telefone:{telefone}");
                  Console.WriteLine($"   ");
                 Console.WriteLine($"CPF:{cpf}");
                  Console.WriteLine($"   ");
                 Console.WriteLine($"EstadoCivil:{estadoCivil}");
                 

                 Console.WriteLine($"Ola {nome} Qual seu sobrenome :");
                 String sobrenome = Console.ReadLine();
                 
                 Console.WriteLine($"Ola {nome} {sobrenome}");
                
               