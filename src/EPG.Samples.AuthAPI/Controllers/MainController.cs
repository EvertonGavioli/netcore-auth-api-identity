using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;

namespace EPG.Samples.AuthAPI.Controllers
{
    [ApiController]    
    public abstract class MainController : Controller
    {
        protected ICollection<string> Erros = new List<string>();

        protected ActionResult GerarResposta(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(result);
            }

            var resultErros = new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Mensagens", Erros.ToArray() }
            });

            return BadRequest(resultErros);
        }

        protected ActionResult GerarResposta(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                AdicionarErro(erro.ErrorMessage);
            }

            return GerarResposta();
        }

        protected bool OperacaoValida()
        {
            return !Erros.Any();
        }

        protected void AdicionarErro(string erro)
        {
            Erros.Add(erro);
        }

        protected void LimparErros()
        {
            Erros.Clear();
        }
    }
}
