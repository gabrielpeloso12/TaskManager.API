using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.Update;

public class UpdateTaskUseCase
{
    public ResponseUpdateTaskJson Execute(int id, RequestRegisterTaskJson request)
    {
        return new ResponseUpdateTaskJson();
    }
}
