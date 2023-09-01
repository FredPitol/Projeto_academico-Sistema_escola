using Escola;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new Aluno("Frederico");
        a1.Nota1 = 10;
        Console.WriteLine(a1.Nota1);


    

    }
<<<<<<< Updated upstream
    //todo
    public void CriarDisciplina() {

        Console.WriteLine("Digite o nome da disciplina");
        string n = Console.ReadLine();

        Console.WriteLine("Digite a quantidade aulas que possui esse disciplina");
        RecebeCargaHoraria(Console.ReadLine());
        
    }
    public int RecebeCargaHoraria(string input)
    {
        bool nvalido = false;
        
        while (!nvalido)
        {
            Console.Write("Digite um número inteiro: ");
            string i = Console.ReadLine();

            if (int.TryParse(input, out int numero))
            {
                Console.WriteLine($"Número digitado: {numero}");  
                nvalido = true;  
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro válido.");
            }
            
        }
        return int.Parse(input);
    }

=======
>>>>>>> Stashed changes
}