using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedeHoteis.Model
{
    public class Cidade
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int DDD { get; set; }
        public Estado Estado { get; set; }
        public Endereco Endereco { get; set; }
    }
}