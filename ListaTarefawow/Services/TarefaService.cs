
using ListaTarefawow.models;

namespace ListaTarefawow.Services;

public class TarefaService
{
    private Tarefa tarefa1 = new Tarefa();
    private Tarefa tarefa2 = new Tarefa();
    private Tarefa tarefa3 = new Tarefa();

    private string caminhoTarefa1 = "Tarefa1.Json";
    private string caminhoTarefa2 = "Tarefa2.Json";
    private string caminhoTarefa3 = "Tarefa3.Json";

    public void CadastrarTarefa(String titulo, string descricao)
    {

        Tarefa tarefa = new Tarefa();
        tarefa.Titulo = titulo;
        tarefa.Descrição = descricao;
        tarefa.Concluida = false;
    }
}
