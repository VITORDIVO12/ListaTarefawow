
using ListaTarefawow.models;

bool continuar = true;
Tarefa tarefa = new Tarefa();

while (continuar)
{
    tarefa.carregardojson();
    Console.Clear();   
    Console.WriteLine("== Sistema de tarefas - Turma 3B ==");
    Console.WriteLine("1 - Cadastrar tarefa");
    Console.WriteLine("2 - Listar Tarefas");
    Console.WriteLine("3 - Consultar tarefa");
    Console.WriteLine("4 - Remover tarefa");
    Console.WriteLine("0 - Sair");

    string op = Console.ReadLine();

    if (op == "1")
    {
        // Cadastrar tarefa

        Console.WriteLine("Digite o titulo da tarefa");
        string titulo = Console.ReadLine();
        Console.WriteLine("Digite a descrição da tarefa");
        string descricao = Console.ReadLine();

       // Tarefa novaTarefa = new Tarefa();
        tarefa.CadastrarTarefa(titulo, descricao);
    }

    else if (op == "2")
    {
        //listagem de tarefa

        tarefa.ListarTarefa();
    }

    else if (op == "3")
    {
        // concluir tarefa

        tarefa.ConcluirTarefa(1);
    }

    else if (op == "4")
    {
        // remover tarefa

        tarefa.RemoverTarefa(1);
    }
}
