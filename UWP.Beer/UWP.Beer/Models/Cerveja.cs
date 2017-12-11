using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Beer.Models
{
    public class Cerveja
    {
        public int IdCerveja { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public string Ano { get; set; }
        public string Preco { get; set; }

    }
}
