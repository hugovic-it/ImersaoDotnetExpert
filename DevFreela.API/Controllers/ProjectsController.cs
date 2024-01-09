using DevFreela.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        // api/projects?query=netcore
        [HttpGet]
        public IActionResult Get(string query)
        {
            //Busco todos os projetos
            return Ok();
        }
        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            //Busco um projeto
            //return NotFound()
            return Ok();
            
        }
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            //Cadastrar o projeto
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id}, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            //Atualizo um projeto
            if (updateProject.Description.Length > 50)
            {
                return BadRequest();
            }
            return NoContent();
        }

        // api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, retorna NotFound

            //Remover

            return NoContent();
        }

    }
}
