using System;
using System.Collections.Generic;

namespace Escola
{
	public class Aluno
	{      
        private string Nome { get; set; }
        private double? Nota1 { get; set; }
        private double? Nota2 { get; set; }
		private string Status  { get; set; }
        private bool SemestreFinalizado { get; set; }
        private int Faltas { get; set; }

        public Aluno(
                    string nome,
                    double? nota1 = null,
                    double? nota2 = null,
                    string status = "Indefinido",
					bool isSemestreFinalizado = false,
                    int faltas = 0
                    )
		{
			Console.WriteLine("Criando estância de aluno...\n");
			Nome = nome;
			Nota1 = nota1;
			Nota2 = nota2;
			Status = status;
			SemestreFinalizado = isSemestreFinalizado;
            Faltas = faltas;
        }



		public void AtriNota1(double N)
		{
			if(N < 0.0 || N > 10.0)
			{
                Console.WriteLine("ERRO - Nota inválida\n");
            }
				
			else
			{
                Nota1 = N;
                Console.WriteLine($"Nota 1 - Valor: {N.ToString("00.00")} \nAdicionada com sucesso!\n");
            }
			
		}

		public void AtriNota2(double N)
		{
            if (N < 0.0 || N > 10.0)
            {
                Console.WriteLine("ERRO - Nota inválida\n");
            }

            else
            {
                Nota2 = N;
                Console.WriteLine($"Nota 2 - Valor: {N.ToString("00.00")} \nAdicionado com sucesso!\n");
            }
        }

		// Calcula média do aluno nota1 * nota2 / 2

        public double? CalcMed()
        {
			// Caso uma das notas não for adicionada, printa msg de erro e retorna 0.
            if (Nota1.Equals(null))
            {
				Console.WriteLine("ERRO DE PROCESSAMENTO: Insira nota 1 do aluno\n");
                return 0.0;
            }
            else if (Nota2.Equals(null))
            {
                Console.WriteLine("ERRO DE PROCESSAMENTO: Insira nota 2 do aluno\n");
				return 0.0;
            }

			// Caso exista os dois valores de nota retorna valor calculado
            else
            {
                double? v = (Nota1 + Nota2) / 2;
                return v;
            }
        }

		// + 1 na contagem de faltas 
        public void AtribFalta()
		{
			Faltas++;
            Console.WriteLine("Falta atribuida\n");
        }

		// - 1 na contagem de faltas
		public void AbonaFalta()
		{
			Faltas--;
			Console.WriteLine("Falta abonada\n");
		}

        public void VerificaStatus(Disciplina D)
        {
            if (SemestreFinalizado)
            {
                if (D.GetCargaHoraria == null)
                {
                    Console.WriteLine("Carga horária não adicionada na disciplina");
                }
                else
                {
                    // Recebe carga horaria em formato double
                    double V1 = (double)D.GetCargaHoraria;

                    // Calcula 25% da quantidade de presenças obrigatórias da disciplina 
                    double V2 = V1 * 0.25;

                    // Recebe média do aluno
                    double V3 = (double)CalcMed();

                    if (Faltas <= V2 && V3 >= 7)
                    {
                        Status = "Aprovado";
                        Console.WriteLine($"O aluno{Nome} está {Status} " +
                            $"Na disciplina{D.GetSetNome}");
                    }
                    else
                    {
                        Status = "Reprovado";
                    }
                }
            }
            else
            {
                Console.WriteLine("Semestre não finalizado");
            }
        }

        //todo
        public double? GetNota1()
        {
            return Nota1;
        }


    }

}