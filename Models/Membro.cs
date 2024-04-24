using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Membro
    {
        public Guid id{ get; set; } = Guid.NewGuid();
        public string name { get; set;}
        public int contato { get; set; }
        public DateOnly datanascimento{ get; set; }
        public string estadocivil{ get; set; }
        public string email { get; set;}
        public string endereco { get; set;}
        public string complementoendereco { get; set;}
        public string numeroendereco { get; set;}
    }
}