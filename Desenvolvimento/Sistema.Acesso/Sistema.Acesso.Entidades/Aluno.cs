﻿
namespace Sistema.Acesso.Entidades
{
    public class Aluno : PessoaFisica
    {
        /*propriedades*/
        public int idAluno { get; set; }
        public string contato1 { get; set; }
        public string contato2 { get; set; }
        public string responsavel1 { get; set; }
        public string responsavel2 { get; set; }
        public Prontuario prontuario { get; set; }
    }
}
