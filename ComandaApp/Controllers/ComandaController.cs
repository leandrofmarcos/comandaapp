using ComandaMVC.Models;
using ComandaMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ComandaMVC.Controllers
{
    public class ComandaController : Controller
    {
        private ComandaService comandaService;

        public ComandaController(ComandaService comandaService)
        {
            this.comandaService = comandaService;
        }

        public IActionResult Index()
        {

            var comandas = this.comandaService.GetAllComandas();

            return View(comandas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Create(ComandaModel comanda)
		{
            comandaService.Create(comanda);

			return RedirectToAction("Index");
		}

		public IActionResult Detalhe(int id)
        {
			ViewBag.Produtos = Produto.GetProdutosFake();

			ComandaModel comanda = comandaService.FindById(id);

            return View(comanda);
        }

        [HttpPost]
        public IActionResult AdcionarProduto(Produto produto, int comandaId)
        {
            Produto founded = Produto.GetProdutosFake().Where(a => a.Id == produto.Id).FirstOrDefault();
            ComandaModel comandaModel = comandaService.FindById(comandaId);
            comandaModel.AddProduto(founded);

            return RedirectToAction("Detalhe", new {id = comandaId});
        }

	}
}
