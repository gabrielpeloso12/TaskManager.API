using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefa.Register;

public class RegisterTaskUseCase 
{
    public ResponseRegisterTaskJson Execute(RequestRegisterTaskJson request)
    {
        return new ResponseRegisterTaskJson();
    }
}
