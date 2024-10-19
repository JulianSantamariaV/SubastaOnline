using WebApplication1.Models;

namespace WebApplication1.Services
{

    public interface ISubastaRepositorio
    {
        List<SubastaDTO> ObtenerProyecto();
    }
    public class SubastaRepositorio : ISubastaRepositorio
    {
        public List<SubastaDTO> ObtenerProyecto()
        {
            return new List<SubastaDTO>()
            {
                new SubastaDTO
            {
                Titulo = "Maquina de escribir",
                Descripcion = "Maquina marca Roche del año 1983",
                ImgUrl = ""
            },

                new SubastaDTO
                {
                    Titulo = "Lote en Santa Elena",
                    Descripcion = "Area de 100m cuadrados con sendero ecologico",
                    ImgUrl = ""
                },

                new SubastaDTO
                {
                    Titulo = "Sandero",
                    Descripcion = "68.000km, vehiculo del 2018, transito de Sabaneta, nunca chocado, unico dueño",
                    ImgUrl = ""
                },

                new SubastaDTO
                {
                    Titulo = "Balon",
                    Descripcion = "Balon firmado por Ronaldo en el mundial de Francia",
                    ImgUrl = ""
                },

                new SubastaDTO
                {
                    Titulo = "Perrito",
                    Descripcion = "Pastor Aleman con 2 años, sabe dar la patita y hace del 2 en el baño",
                    ImgUrl = ""
                },

                new SubastaDTO
                {
                    Titulo = "Computador",
                    Descripcion = "Portatil con WOW instalado",
                    ImgUrl = ""
                },
            };
        }
    }
}
