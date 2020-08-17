using ProvaApisul.Model;
using ProvaApisul.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaApisul.Repository.Implementation
{
    public class VotoRepositoryImplementation : IVotoRepository
    {
        public VotoElevador InsereVoto(VotoElevador voto)
        {
            var dataBase = MemoryDataBase.GetInstance();
            dataBase.ListaVotos.Add(voto);
            return voto;
        }

        public int UsoElevador(char elevador)
        {
            var dataBase = MemoryDataBase.GetInstance();
            return dataBase.ListaVotos.Count(x => x.Elevador == elevador);
        }

        public int UsoAndar(int andar)
        {
            var dataBase = MemoryDataBase.GetInstance();
            return dataBase.ListaVotos.Count(x => x.Andar == andar);
        }

        public int UsoTotal()
        {
            var dataBase = MemoryDataBase.GetInstance();
            return dataBase.ListaVotos.Count();
        }

        public List<int> AndarMenosUtilizado()
        {
            var dataBase = MemoryDataBase.GetInstance();
            var list = from r in dataBase.ListaVotos            
            group r by r.Andar into grp
            select new { andar = grp.Key, total = grp.Count() };

            if (list.Count() == 0)
                return new List<int>();

            list = list.OrderBy(x => x.total);

            var listaRetorno = new List<int>();
            listaRetorno.Add(list.ElementAt(0).andar);

            foreach (var item in list.Skip(1))
            {
                if (item.total == list.ElementAt(0).total)
                    listaRetorno.Add(item.andar);
                else
                    break;
            }

            return listaRetorno;
        }

        public List<char> ElevadorMaisFrequentado()
        {
            var dataBase = MemoryDataBase.GetInstance();
            var list = from r in dataBase.ListaVotos
                       group r by r.Elevador into grp
                       select new { elevador = grp.Key, total = grp.Count() };

            if (list.Count() == 0)
                return new List<char>();

            list = list.OrderByDescending(x => x.total);

            var listaRetorno = new List<char>();
            listaRetorno.Add(list.ElementAt(0).elevador);

            foreach (var item in list.Skip(1))
            {
                if (item.total == list.ElementAt(0).total)
                    listaRetorno.Add(item.elevador);
                else
                    break;
            }

            return listaRetorno;
        }

        public List<char> ElevadorMenosFrequentado()
        {
            var dataBase = MemoryDataBase.GetInstance();
            var list = from r in dataBase.ListaVotos
                       group r by r.Elevador into grp
                       select new { elevador = grp.Key, total = grp.Count() };

            if (list.Count() == 0)
                return new List<char>();

            list = list.OrderBy(x => x.total);

            var listaRetorno = new List<char>();
            listaRetorno.Add(list.ElementAt(0).elevador);

            foreach (var item in list.Skip(1))
            {
                if (item.total == list.ElementAt(0).total)
                    listaRetorno.Add(item.elevador);
                else
                    break;
            }

            return listaRetorno;
        }

        public List<char> PeriodoMaiorFluxoElevadorMaisFrequentado()
        {
            var elevadoresMaisFrequentados = ElevadorMaisFrequentado();

            var dataBase = MemoryDataBase.GetInstance();
            var list = from r in dataBase.ListaVotos
                       where elevadoresMaisFrequentados.Contains(r.Elevador)
                       group r by r.Turno into grp
                       select new { periodo = grp.Key, total = grp.Count() };

            if (list.Count() == 0)
                return new List<char>();

            list = list.OrderByDescending(x => x.total);

            var listaRetorno = new List<char>();
            listaRetorno.Add(list.ElementAt(0).periodo);

            foreach (var item in list.Skip(1))
            {
                if (item.total == list.ElementAt(0).total)
                    listaRetorno.Add(item.periodo);
                else
                    break;
            }

            return listaRetorno;
        }

        public List<char> PeriodoMaiorUtilizacaoConjuntoElevadores()
        {
            var dataBase = MemoryDataBase.GetInstance();
            var list = from r in dataBase.ListaVotos
                       group r by r.Turno into grp
                       select new { periodo = grp.Key, total = grp.Count() };

            if (list.Count() == 0)
                return new List<char>();

            list = list.OrderByDescending(x => x.total);

            var listaRetorno = new List<char>();
            listaRetorno.Add(list.ElementAt(0).periodo);

            foreach (var item in list.Skip(1))
            {
                if (item.total == list.ElementAt(0).total)
                    listaRetorno.Add(item.periodo);
                else
                    break;
            }

            return listaRetorno;
        }

        public List<char> PeriodoMenorFluxoElevadorMenosFrequentado()
        {
            var elevadoresMenosFrequentados = ElevadorMenosFrequentado();

            var dataBase = MemoryDataBase.GetInstance();
            var list = from r in dataBase.ListaVotos
                       where elevadoresMenosFrequentados.Contains(r.Elevador)
                       group r by r.Turno into grp
                       select new { periodo = grp.Key, total = grp.Count() };

            if (list.Count() == 0)
                return new List<char>();

            list = list.OrderBy(x => x.total);

            var listaRetorno = new List<char>();
            listaRetorno.Add(list.ElementAt(0).periodo);

            foreach (var item in list.Skip(1))
            {
                if (item.total == list.ElementAt(0).total)
                    listaRetorno.Add(item.periodo);
                else
                    break;
            }

            return listaRetorno;
        }
    }
}
