using System;
using System.Collections.Generic;
using Series.Entities.Interface;

namespace Series.Entities
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int Proximo()
        {
            throw new NotImplementedException();
        }

        public Serie RetornarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}