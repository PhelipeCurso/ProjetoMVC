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
        public string address { get; set;}
        public int contato { get; set; }
        
        
    }
}