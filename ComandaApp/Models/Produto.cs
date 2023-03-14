using System.Collections.Generic;
using System.Linq;

namespace ComandaMVC.Models
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public decimal Preco { get; set; }


		public static List<Produto> GetProdutosFake()
		{
			return new List<Produto>()
			{
				new Produto() { Id = 1, Nome = "Refrigerante", Preco = 500 },
				new Produto() { Id = 2, Nome = "Salgadinho", Preco = 255 },
				new Produto() { Id = 3, Nome = "Pinga", Preco = 22 },
				new Produto() { Id = 4, Nome = "Cerveja", Preco = 11 },
				new Produto() { Id = 5, Nome = "Vodka", Preco = 50 },
				new Produto() { Id = 6, Nome = "Produto1", Preco = 55 },
				new Produto() { Id = 7, Nome = "Sabao", Preco = 55 },
				new Produto() { Id = 8, Nome = "Acucar", Preco = 55 },
				new Produto() { Id = 9, Nome = "Feijao", Preco = 55 },

			};
		}

		public static Produto GetFakeProduto(int id)
		{
			return GetProdutosFake().Where(a => a.Id == id).FirstOrDefault();
		}
	}
}
