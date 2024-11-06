using GerenciadorDeTarefas.Communication.Enums;

namespace TaskManager.Communication.Response;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityTask Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public StatusTask Status { get; set; }
}
