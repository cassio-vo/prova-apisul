using ProvaApisul.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaApisul.Bussiness
{
    public interface IElevadorBusiness
    {
        /// <summary> Insere o voto </summary>
        //feito
        VotoElevador InsereVoto(char elevador, int andar, char turno);

        /// <summary> Deve retornar uma List contendo o(s) andar(es) menos utilizado(s). </summary> 
        List<int> AndarMenosUtilizado();

        /// <summary> Deve retornar uma List contendo o(s) elevador(es) mais frequentado(s). </summary> 
        List<char> ElevadorMaisFrequentado();

        /// <summary> Deve retornar uma List contendo o período de maior fluxo de cada um dos elevadores mais frequentados (se houver mais de um). </summary> 
        List<char> PeriodoMaiorFluxoElevadorMaisFrequentado();

        /// <summary> Deve retornar uma List contendo o(s) elevador(es) menos frequentado(s). </summary> 
        List<char> ElevadorMenosFrequentado();

        int TotalUso();

        /// <summary> Deve retornar uma List contendo o período de menor fluxo de cada um dos elevadores menos frequentados (se houver mais de um). </summary> 
        List<char> PeriodoMenorFluxoElevadorMenosFrequentado();

        /// <summary> Deve retornar uma List contendo o(s) periodo(s) de maior utilização do conjunto de elevadores. </summary> 
        List<char> PeriodoMaiorUtilizacaoConjuntoElevadores();

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador A em relação a todos os serviços prestados. </summary> 
        //feito
        float PercentualDeUsoElevadorA();

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador B em relação a todos os serviços prestados. </summary> 
        //feito
        float PercentualDeUsoElevadorB();

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador C em relação a todos os serviços prestados. </summary> 
        //feito
        float PercentualDeUsoElevadorC();

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador D em relação a todos os serviços prestados. </summary> 
        //feito
        float PercentualDeUsoElevadorD();

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador E em relação a todos os serviços prestados. </summary> 
        //feito
        float PercentualDeUsoElevadorE();
    }
}
