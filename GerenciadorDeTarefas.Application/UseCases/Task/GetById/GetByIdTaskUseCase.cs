using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.GetById;

public class GetByIdTaskUseCase
{
    public ResponseShortTaskJson Execute(int id)
    {
        return new ResponseShortTaskJson();
    }
}
