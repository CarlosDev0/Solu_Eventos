using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lafrancol.Solu_Eventos.Persistencia.Models
{
    public class Participante
    {
        public long idParticipante { get; set; }
        public string nombre { get; set; }
        public virtual Evento Evento { get; set; }
    }
}
