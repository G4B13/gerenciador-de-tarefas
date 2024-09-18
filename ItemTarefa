using System;

namespace GerenciadorTarefas
{
    public class ItemTarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        
        public ItemTarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}\nDescrição: {Descricao}\nCriado em: {DataCriacao}\n";
        }
    }
}
