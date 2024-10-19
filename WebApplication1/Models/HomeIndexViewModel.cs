using WebApplication1.Models;

namespace SubastaOnline.Models
{
    public class HomeIndexViewModel
    {
        private IEnumerable<SubastaDTO> subastas;

        public IEnumerable<SubastaDTO> Subastas { get => subastas; set => subastas = value; }
    }
}
