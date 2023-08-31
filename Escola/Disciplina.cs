using System;

namespace Escola
{
	public class Disciplina
	{

		private string Nome { get; set; }
        private List<Aluno> AlunosMatriculados { get; set;}
        private int? CargaHoraria { get; set; } //Quantidade de aulas

        public Disciplina(string nome,
							int? cargahoraria = null
                            )
		{
            Console.WriteLine("Criando estãncia de disciplina...\n");
            Nome = nome;
			CargaHoraria = cargahoraria;
            AlunosMatriculados = new List<Aluno>();
            
        }

        //Adiciona aluno a disciplina
        public void AddAluno(Aluno A)
        {
            AlunosMatriculados.Add(A);
        }

        //Sobreescrita de métodos getters e setters
        public int? GetCargaHoraria
        {
            get
            {
                if (CargaHoraria.Equals(null))
                {
                    Console.WriteLine("ERRO DE PROCESSAMENTO: " +
                        "Carga horária não atribuida a disciplina\n");
                    return null;
                }
                else
                {
                    return CargaHoraria;
                }
            }
            set
            {
                bool V1 = value != 40;
                bool V2 = value != 80;
                if (V1 || V2)
                {
                    Console.WriteLine("Só existem disciplinas com 40 ou 80 aulas\n" +
                        "Favor inserir um valor válido\n");
                }
                else
                {
                    CargaHoraria = value;
                }
            }
        }
        public string GetSetNome
        {
            get => Nome;

            set => Nome = value;
        }
    }
}

