using GerenciadorDeTarefas.Communication.Enums;
using GerenciadorDeTarefas.Communication.Response;
using TaskManager.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.GetById;

public class GetByIdTaskUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Gabriel Peloso",
            Description = "Conserto notebook",
            Priority = Communication.Enums.PriorityTask.high,
            LimitDate = DateTime.Now,
            Status = Communication.Enums.StatusTask.InProgress
        };
    }
}