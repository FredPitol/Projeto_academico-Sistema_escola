using System;

namespace Escola
{
	public class Disciplina
	{
        // Campos
		private string _nome { get; set; }
        private int? _cargaHoraria { get; set; } = null; 

        // Propriedades
        public string Nome
        {
            get => _nome;

            set => _nome = value;
        }
            //Carga horaria só pode ser 40 ou 80 horas 
        public int? CargaHoraria
        {
            get => _cargaHoraria;
            set
            {
                // Verdadeiro caso seja diferente de 40 ou 80
                bool V1 = value != 40;
                bool V2 = value != 80;

                if (V1 || V2)
                {
                    Console.WriteLine("Só existem disciplinas com " +
                        "40 ou 80 aulas\n" +
                        "Favor inserir um valor válido\n");
                }
                else
                {
                    CargaHoraria = value;
                }
            }
        }

        //Construtor
        public Disciplina(string nome)
		{
            Console.WriteLine("Criando estãncia de disciplina...\n");
            _nome = nome;
            Console.WriteLine($"Disciplina criada: \n" +
                $" Nome: {_nome}\n");
        }
    }
}

