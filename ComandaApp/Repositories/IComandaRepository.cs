using ComandaMVC.Models;
using System.Collections.Generic;

namespace ComandaMVC.Repositories
{
    public interface IComandaRepository
    {
        List<ComandaModel> GetAll();
        ComandaModel GetById(int id);
        void Create(ComandaModel model);
    }
}
