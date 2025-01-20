using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExamenNarvaezEsteban.Models;
namespace ExamenNarvaezEsteban.Services
{
    public interface IConsultaService
    {
      Task<Consulta> Obtener(String Nombre);
    }
}
