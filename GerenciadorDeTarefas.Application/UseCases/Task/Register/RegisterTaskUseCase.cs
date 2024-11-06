using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;
using TaskManager.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.Register;

public class RegisterTaskUseCase 
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = 13,
            Description = request.Description,
            LimitDate = request.LimitDate,
            Name = request.Name,
            Priority = request.Priority,
            Status = request.Status
        };
    }
}
