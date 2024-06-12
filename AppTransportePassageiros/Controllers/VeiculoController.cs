using Repository.Models;
using Repository;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Controllers
{
    public class VeiculoController
    {
        readonly VeiculoRepository _veiculoRepository = new VeiculoRepository();

        public void CreateVeiculo(Veiculo veiculo)
        {
            _veiculoRepository.Create(veiculo);
        }

        public List<Veiculo> GetAllVeiculo()
        {
            return _veiculoRepository.Get().ToList();
        }

        public Veiculo GetVeiculo(string placa)
        {
            return _veiculoRepository.Get(placa);
        }

        public void UpdateVeiculo(Veiculo veiculo)
        {
            _veiculoRepository.Update(veiculo);
        }

        public void DeleteVeiculo(string placa)
        {
            _veiculoRepository.Delete(placa);
        }
    }
}
