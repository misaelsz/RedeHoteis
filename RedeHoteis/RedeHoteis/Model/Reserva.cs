using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedeHoteis.Model
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime ChegadaPrevista { get; set; }
        public DateTime SaidaPrevista { get; set; }
        public int QuantidadeApartamentos { get; set; }
        public Hotel Hotel { get; set; }
        public Hospede Hospede { get; set; }
    }
}