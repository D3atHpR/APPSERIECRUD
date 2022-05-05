using System;
using System.Collections.Generic;
using APPSERIES.Interfaces;
using APPSERIES.Classes;



namespace APPSERIES
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualizar(int id, Series objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaSerie;
        }

        public int Proximo()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listaSerie.Cout;
        }

        public Series RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}