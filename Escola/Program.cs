using Escola;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {











        ////TESTES

        ////INSTÂNCIA
        //Aluno a1 = new("Frederico");
        //Disciplina d1 = new("POO2", 30);

        //// Métod getter
        //Console.WriteLine("Metodo Getter classe disciplina");
        //Console.WriteLine(d1.GetSetNome);
       
        ////ERRO DE PROCESSAMENTO CalcMed()
        //double? teste = a1.CalcMed();

        ////RETORNO CalcMed()
        //Console.WriteLine("Retorno da função CalcMed()");
        //Console.WriteLine(teste);
        //Console.WriteLine();

        ////ATRIBUIR NOTA
        //a1.AtriNota2(2.0);
        //a1.AtriNota1(3.0);

        ////ATRIBUIR NOTA TRATAMENTO DE EXCEÇÃO - Nº acima do permitido e negativos
        //a1.AtriNota1(10.1);
        //a1.AtriNota2(-0.1);

        //teste = a1.CalcMed();
        //Console.WriteLine($"Média: {teste}");
        //Console.WriteLine();




    }

    //todo
    public void CriarDisciplina() {

        Console.WriteLine("Digite o nome da disciplina");
        string n = Console.ReadLine();

        Console.WriteLine("Digite a quantidade aulas que possui esse disciplina");
        RecebeCargaHoraria(Console.ReadLine());
        
        
        


        ////Tentativa de convesão para int
        //if (int.TryParse(A, out int numero))
        //{
        //    Console.WriteLine($"Número digitado: {numero}");
        //}
        //else
        //{
        //    Console.WriteLine("Entrada inválida. Digite um número inteiro válido.");
            
        //}
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

}
//didatica flexivel 