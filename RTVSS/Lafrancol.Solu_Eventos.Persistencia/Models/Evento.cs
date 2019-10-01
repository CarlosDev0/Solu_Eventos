using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lafrancol.Solu_Eventos.Persistencia.Models
{
    public class Evento
    {
        public long idEvento { get; set; }
        public string nombre { get; set; }
        public DateTime fecha { get; set; }
        public string ciudad { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }
        
    }
}
