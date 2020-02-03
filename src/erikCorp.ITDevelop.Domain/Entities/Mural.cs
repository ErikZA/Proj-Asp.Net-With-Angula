using System;

namespace erikCorp.ITDevelop.Domain.Entities
{
    public class Mural
    {
        public int muralId { get; set; }
        public DateTime Data { get; set; }
        public string titulo { get; set; }
        public string aviso { get; set; }
        public string autor { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return this.aviso + "-" + this.autor;
        }

    }
}
