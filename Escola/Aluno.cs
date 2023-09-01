using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Escola
{
    public class Aluno
    {
        // Campos
        private string? _nome { get; set; }
        private double? _nota1 { get; set; } = null;
        private double? _nota2 { get; set; } = null;
        private string? _status { get; set; } = "Indefinido";
        private bool _semestreFinalizado { get; set; } = false;
        private int _faltas { get; set; } = 0;
        private Disciplina? _disciplina { get; set; }

        // Propriedades
        public string String
        {
            get => _nome;
            set => _nome = value;
        }

        public double? Nota1
        {
            get => _nota1;

            set
            {
                if (value < 0.0 || value > 10.0)
                {
                    Console.WriteLine("ERRO - Nota inválida\n");
                }
                else
                {
                    Nota1 = value;
                    Console.WriteLine($"Nota 1 - Valor: {Nota1} \nAdicionada com sucesso!\n");
                }

            }
        }

        public double? Nota2
        {
            get => _nota1;

            set
            {
                if (value < 0.0 || value > 10.0)
                {
                    Console.WriteLine("ERRO - Nota inválida\n");
                    return;
                }
                Nota2 = value;
                Console.WriteLine($"Nota 1 - Valor: {Nota2} \n" +
                    $"Adicionada com sucesso!\n");
            }

        }

        public string? Status => _status;



        // Retorna True ou False caso tenha as duas notas inseridas
        public bool SemestreFinalizado
        {
            get
            {
                if (_nota1.HasValue && _nota2.HasValue)
                {
                    _semestreFinalizado = true;
                    return true;
                }
                return false;
            }

        }

        // Acréscimo ou decrésimo de falta (Inserir Nº Positivo ou negativo)
        public int Faltas
        {
            get => _faltas;
            set => _faltas += value;
        }

        public Disciplina? Disciplina
        {
            get => _disciplina;
            set => _disciplina = value;
        }

        // Construtor
        public Aluno(string nome)
        {
            Console.WriteLine("Criando estância de aluno...\n");
            _nome = nome;
        }

        
    }
}