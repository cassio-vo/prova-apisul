using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvaApisul.Bussiness;
using ProvaApisul.Model;

namespace ProvaApisul.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevadorController : ControllerBase
    {

        private IElevadorBusiness _elevadorBusiness;

        public ElevadorController(IElevadorBusiness elevadorBusiness)
        {
            _elevadorBusiness = elevadorBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Iniciado.");
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<VotoElevador> votos)
        {
            if (votos == null)
                return NotFound();

            foreach (var voto in votos)
                _elevadorBusiness.InsereVoto(voto.Elevador, voto.Andar, voto.Turno);

            var totalUso = _elevadorBusiness.TotalUso();

            var andarMenosUtilizado = _elevadorBusiness.AndarMenosUtilizado();

            var elevadorMaisFrequentado = _elevadorBusiness.ElevadorMaisFrequentado();

            var periodoMaiorFluxoElevadorMaisFrequentado = _elevadorBusiness.PeriodoMaiorFluxoElevadorMaisFrequentado();

            var elevadorMenosFrequentado = _elevadorBusiness.ElevadorMenosFrequentado();

            var periodoMenorFluxoElevadorMenosFrequentado = _elevadorBusiness.PeriodoMenorFluxoElevadorMenosFrequentado();

            var periodoMaiorUtilizacaoConjuntoElevadores = _elevadorBusiness.PeriodoMaiorUtilizacaoConjuntoElevadores();

            var percentualDeUsoElevadorA = _elevadorBusiness.PercentualDeUsoElevadorA();

            var percentualDeUsoElevadorB = _elevadorBusiness.PercentualDeUsoElevadorB();

            var percentualDeUsoElevadorC = _elevadorBusiness.PercentualDeUsoElevadorC();

            var percentualDeUsoElevadorD = _elevadorBusiness.PercentualDeUsoElevadorD();

            var percentualDeUsoElevadorE = _elevadorBusiness.PercentualDeUsoElevadorE();

            return new ObjectResult(votos);
        }

    }
}
