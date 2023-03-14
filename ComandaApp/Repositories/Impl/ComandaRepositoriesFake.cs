using ComandaMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace ComandaMVC.Repositories.Impl
{
	public class ComandaRepositoriesFake : IComandaRepository
	{

		private List<ComandaModel> comandas;

		public ComandaRepositoriesFake()
		{
			this.comandas = new List<ComandaModel>();
			FillFakeInitial();
		}

		public void Create(ComandaModel model)
		{
			this.comandas.Add(model);
		}

		public List<ComandaModel> GetAll()
		{

			return comandas.OrderBy(x => x.Id).ToList();
		}

		public ComandaModel GetById(int id)
		{
			return this.comandas.Where(a => a.Id == id).FirstOrDefault();
		}

		private void FillFakeInitial()
		{
			var usuario1 = new ComandaModel() { Id = 1, Mesa = 1, Nome = "Usuario1", Status = "aberta" };
			usuario1.AddProduto(Produto.GetFakeProduto(1));
			usuario1.AddProduto(Produto.GetFakeProduto(2));
			usuario1.AddProduto(Produto.GetFakeProduto(3));

			var usuario2 = new ComandaModel() { Id = 2, Mesa = 2, Nome = "Usuario2", Status = "fechada" };
			usuario2.AddProduto(Produto.GetFakeProduto(4));
			usuario2.AddProduto(Produto.GetFakeProduto(6));
			usuario2.AddProduto(Produto.GetFakeProduto(3));

			var usuario3 = new ComandaModel() { Id = 3, Mesa = 3, Nome = "Usuario3", Status = "aberta" };
			usuario3.AddProduto(Produto.GetFakeProduto(4));
			usuario3.AddProduto(Produto.GetFakeProduto(5));
			usuario3.AddProduto(Produto.GetFakeProduto(6));
			usuario3.AddProduto(Produto.GetFakeProduto(3));
			usuario3.AddProduto(Produto.GetFakeProduto(2));

			comandas.AddRange(new List<ComandaModel>()
			{
				usuario1, usuario2, usuario3
			});
		}
	}
}
