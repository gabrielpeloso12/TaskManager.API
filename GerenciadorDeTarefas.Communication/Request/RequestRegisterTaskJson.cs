using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Request;

public class RequestRegisterTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description {  get; set; } = string.Empty;
    public PriorityTask Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public StatusTask Status { get; set; }
}
