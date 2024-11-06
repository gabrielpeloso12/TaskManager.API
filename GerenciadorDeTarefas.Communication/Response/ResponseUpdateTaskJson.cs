using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Response;

public class ResponseUpdateTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime LimitDate { get; set; }
}
