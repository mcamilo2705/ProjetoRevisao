//Vamos criar um programa que gerencie uma **lista de notas de alunos** e calcule a média. O usuário poderá:

//1.Inserir as notas de um aluno. (Cada aluno tem 5 notas)
//2. Exibir as notas e calcular a média.
//3. Verificar se o aluno foi aprovado ou reprovado (média >= 7 para aprovação).

string[] aluno = new string[1];
double[] nota = new double[5];
double cont = 0;
double somarNotas = 0.0;

try
{
    for (int i = 0; i < aluno.Length; i++)
    {
        Console.Write("Digite o nome do aluno: ");
        aluno[0] = Console.ReadLine();
        for (int j = 0; j < nota.Length; j++)
        {
            Console.Write($"Digite a {j + 1}ª nota: ");
            nota[j] = Double.Parse(Console.ReadLine());
            if (nota[j] < 0 || nota[j] > 10)
            {
                throw new ArgumentOutOfRangeException("Informe notas entre 0 e 10");
            }
            else 
            { 
                somarNotas += nota[j];
                cont++;
            }
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Notas do aluno: " + aluno[0]);
    for (int i = 0; i < nota.Length; i++)
    {
        Console.Write($"{nota[i]} ");
    }

    Console.WriteLine("");
    Console.WriteLine("Media: " + somarNotas / cont);

    if (somarNotas / cont >= 7)
    {
        Console.WriteLine("O aluno foi APROVADO! ");
    }
    else
        Console.WriteLine("O aluno foi REPROVADO!");
}
catch (FormatException ex)
{
    Console.WriteLine("Dados invalidos, inserir somente numeros!");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Informe notas entre 0 e 10");
}

