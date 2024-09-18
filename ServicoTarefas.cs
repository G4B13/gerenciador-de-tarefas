using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GerenciadorTarefas
{
    public class ServicoTarefas
    {
        private const string CaminhoArquivo = "tarefas.json";

        public List<ItemTarefa> CarregarTarefas()
        {
            if (!File.Exists(CaminhoArquivo))
            {
                return new List<ItemTarefa>();
            }

            var json = File.ReadAllText(CaminhoArquivo);
            return JsonSerializer.Deserialize<List<ItemTarefa>>(json);
        }

        public void SalvarTarefas(List<ItemTarefa> tarefas)
        {
            var json = JsonSerializer.Serialize(tarefas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(CaminhoArquivo, json);
        }
    }
}
