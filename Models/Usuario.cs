using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMock
{
    public class Usuario
    {
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Regras { get; set; }
        public string Status { get; set; }
    }
}
