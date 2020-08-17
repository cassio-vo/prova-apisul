using ProvaApisul.Model;
using ProvaApisul.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProvaApisul.Util;

namespace ProvaApisul.Bussiness.Implementation
{
    public class ElevadorBusinessImplementation : IElevadorBusiness
    {
        IVotoRepository _votoRepository;

        public ElevadorBusinessImplementation(IVotoRepository votoRepository)
        {
            _votoRepository = votoRepository;
        }

        public VotoElevador InsereVoto(char elevador, int andar, char turno)
        {
            if (!(elevador.ToUpperChar().Equals('A') ||
                elevador.ToUpperChar().Equals('B') ||
                elevador.ToUpperChar().Equals('C') ||
                elevador.ToUpperChar().Equals('D') ||
                elevador.ToUpperChar().Equals('E')))
            {
                throw new Exception("Não existe o elevador");
            }

            if (!(turno.ToUpperChar().Equals('M') ||
                turno.ToUpperChar().Equals('V') ||
                turno.ToUpperChar().Equals('N')))
            {
                throw new Exception("Não existe o turno");
            }

            if (andar <0 || andar > 15)
            {
                throw new Exception("Não existe o andar");
            }

            var voto = new VotoElevador {
                Andar = andar,
                Elevador = elevador.ToUpperChar(),
                Turno = turno.ToUpperChar()
            };

            return _votoRepository.InsereVoto(voto);
        }

        public float PercentualDeUsoElevadorA()
        {
            return Utilidades.CalculaPorcentagem(_votoRepository.UsoElevador('A'),
                                                 _votoRepository.UsoTotal());
        }

        public float PercentualDeUsoElevadorB()
        {
            return Utilidades.CalculaPorcentagem(_votoRepository.UsoElevador('B'),
                                                 _votoRepository.UsoTotal());
        }

        public float PercentualDeUsoElevadorC()
        {
            return Utilidades.CalculaPorcentagem(_votoRepository.UsoElevador('C'),
                                                 _votoRepository.UsoTotal());
        }

        public float PercentualDeUsoElevadorD()
        {
            return Utilidades.CalculaPorcentagem(_votoRepository.UsoElevador('D'),
                                                 _votoRepository.UsoTotal());
        }

        public float PercentualDeUsoElevadorE()
        {
            return Utilidades.CalculaPorcentagem(_votoRepository.UsoElevador('E'),
                                                 _votoRepository.UsoTotal());
        }

        public List<int> AndarMenosUtilizado()
        {
            return _votoRepository.AndarMenosUtilizado();
        }

        public List<char> ElevadorMaisFrequentado()
        {
            return _votoRepository.ElevadorMaisFrequentado();
        }

        public List<char> ElevadorMenosFrequentado()
        {
            return _votoRepository.ElevadorMenosFrequentado();
        }

        public List<char> PeriodoMaiorFluxoElevadorMaisFrequentado()
        {
            return _votoRepository.PeriodoMaiorFluxoElevadorMaisFrequentado();
        }

        public List<char> PeriodoMaiorUtilizacaoConjuntoElevadores()
        {
            return _votoRepository.PeriodoMaiorUtilizacaoConjuntoElevadores();
        }

        public List<char> PeriodoMenorFluxoElevadorMenosFrequentado()
        {
            return _votoRepository.PeriodoMaiorUtilizacaoConjuntoElevadores();
        }

        public int TotalUso()
        {
            return _votoRepository.UsoTotal();
        }
    }
}
