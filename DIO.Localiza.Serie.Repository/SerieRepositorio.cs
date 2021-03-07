using DIO.Localiza.Serie.Domain.Interfaces;
using System.Collections.Generic;

namespace DIO.Localiza.Serie.Repository
{
    public class SerieRepositorio : IRepositorio<Domain.Classes.Serie>
    {
		private List<Domain.Classes.Serie> listaSerie = new List<Domain.Classes.Serie>();
		public void Atualiza(int id, Domain.Classes.Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Domain.Classes.Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Domain.Classes.Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Domain.Classes.Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
	}
}
