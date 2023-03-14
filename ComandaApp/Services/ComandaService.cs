using ComandaMVC.Models;
using ComandaMVC.Repositories;
using System.Collections.Generic;

namespace ComandaMVC.Services
{
    public class ComandaService
    {
        private IComandaRepository comandaRepository;

        public ComandaService(IComandaRepository comandaRepository)
        {
            this.comandaRepository = comandaRepository;
        }

        public List<ComandaModel> GetAllComandas()
        {
            return this.comandaRepository.GetAll();
        }

        public ComandaModel FindById(int id)
        {
            return this.comandaRepository.GetById(id);
        }

        public void Create(ComandaModel model)
        {
            model.Status = "aberta";
            
            comandaRepository.Create(model);
		}
	}
}
