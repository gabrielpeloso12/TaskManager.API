using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Test",
                    Priority = Communication.Enums.PriorityTask.high
                },
                new ResponseShortTaskJson
                {
                    Id = 2,
                    Name = "Test2",
                    Priority = Communication.Enums.PriorityTask.low

                }
            }
        };
    }
}
