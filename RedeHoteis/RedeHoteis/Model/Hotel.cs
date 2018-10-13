using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedeHoteis.Model
{
    public class Hotel
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public float Diaria { get; set; }
        public int Estrelas { get; set; }
        public Cidade Cidade { get; set; }
    }
}