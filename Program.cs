//Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
//2. Exibir as notas e calcular a média.
//3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).

string[] aluno = new string[1];
double[] nota = new double[5];
double cont = 0;
double somarNotas = 0.0;
//bool repetirNotas = false; 
int menu = 0;


do
{
    Console.WriteLine("=== Gerenciador de Notas ===");
    Console.WriteLine("1. Adicionar aluno");
    Console.WriteLine("2. Listar alunos");
    Console.WriteLine("3. Estatísticas");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1: 
                try
                {
                    for (int i = 0; i < aluno.Length; i++)
                    {
                        Console.Write("Digite o nome do aluno: ");
                        aluno[0] = Console.ReadLine();
                        for (int j = 0; j < nota.Length; j++)
                        {
                            //do
                            // {
                            Console.Write($"Digite a {j + 1}ª nota: ");
                            nota[j] = Double.Parse(Console.ReadLine());
                            if (nota[j] < 0 || nota[j] > 10)
                            {
                                //repetirNotas = true;
                                throw new ArgumentOutOfRangeException("Informe notas entre 0 e 10");

                            }
                            else
                            {
                                somarNotas += nota[j];
                                cont++;
                            }
                            //  }while (repetirNotas = true);
                        }
                    }
                  
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Dados invalidos, inserir somente numeros!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Informe notas entre 0 e 10");
                }
            break;
        case 2:
            
            Console.WriteLine("Notas do aluno: " + aluno[0]);
            for (int i = 0; i < nota.Length; i++)
            {
                Console.Write($"{nota[i]} ");
            }
            Console.WriteLine("");
            break;
        case 3:
            Console.WriteLine("");
            Console.WriteLine("Media: " + somarNotas / cont);
            break;
        case 4:
            if (somarNotas / cont >= 7)
            {
                Console.WriteLine("O aluno foi APROVADO! ");
            }
            else
                Console.WriteLine("O aluno foi REPROVADO!");
            break;
        default: Console.WriteLine("Opcao invalida! ");
            break ;
    }

} while (menu != 4);



