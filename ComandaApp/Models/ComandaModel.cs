using System.Collections.Generic;
using System.Linq;

namespace ComandaMVC.Models
{
	public class ComandaModel
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int Mesa { get; set; }
		public string Status { get; set; }
		public decimal Total
		{
			get
			{
				return this.Produtos.Sum(a => a.Preco);
			}
		}

		public List<Produto> Produtos { get; private set; }

		public ComandaModel()
		{
			this.Produtos = new List<Produto>();
		}

		public void AddProduto(Produto produto)
		{
			this.Produtos.Add(produto);
		}
	}
}
