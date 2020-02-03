using System;
using System.Collections.Generic;
using System.Text;

namespace erikCorp.ITDevelop.Domain.Entities
{
    public class Paciente
    {
        public Paciente() {
            this.id = Guid.NewGuid();
        }
           
        public Guid  id { get; set; }

        public int idade { get; set; }

        public string name { get; set; }

    }
}
