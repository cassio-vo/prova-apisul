using ProvaApisul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaApisul.Repository
{
    public interface IVotoRepository
    {
        VotoElevador InsereVoto(VotoElevador voto);

        /// <summary> Deve retornar uma List contendo o(s) andar(es) menos utilizado(s). </summary> 
        List<int> AndarMenosUtilizado();

        /// <summary> Deve retornar uma List contendo o(s) elevador(es) mais frequentado(s). </summary> 
        List<char> ElevadorMaisFrequentado();

        /// <summary> Deve retornar uma List contendo o período de maior fluxo de cada um dos elevadores mais frequentados (se houver mais de um). </summary> 
        List<char> PeriodoMaiorFluxoElevadorMaisFrequentado();

        /// <summary> Deve retornar uma List contendo o(s) elevador(es) menos frequentado(s). </summary> 
        List<char> ElevadorMenosFrequentado();

        /// <summary> Deve retornar uma List contendo o período de menor fluxo de cada um dos elevadores menos frequentados (se houver mais de um). </summary> 
        List<char> PeriodoMenorFluxoElevadorMenosFrequentado();

        /// <summary> Deve retornar uma List contendo o(s) periodo(s) de maior utilização do conjunto de elevadores. </summary> 
        List<char> PeriodoMaiorUtilizacaoConjuntoElevadores();

        int UsoTotal();

        int UsoElevador(char elevador);

        int UsoAndar(int andar);
    }
}
