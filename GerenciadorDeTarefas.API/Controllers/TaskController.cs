using GerenciadorDeTarefas.Application.UseCases.Tarefa.Delete;
using GerenciadorDeTarefas.Application.UseCases.Tarefa.GetAll;
using GerenciadorDeTarefas.Application.UseCases.Tarefa.GetById;
using GerenciadorDeTarefas.Application.UseCases.Tarefa.Register;
using GerenciadorDeTarefas.Application.UseCases.Tarefa.Update;
using GerenciadorDeTarefas.Communication.Request;
using GerenciadorDeTarefas.Communication.Response;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Communication.Response;

namespace GerenciadorDeTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsTaskJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var response = new RegisterTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {

        var useCase = new GetByIdTaskUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsTaskJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsTaskJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        var useCase = new DeleteTaskByIdUseCase();
        useCase.Execute(id);
        return NoContent();
    }
}
