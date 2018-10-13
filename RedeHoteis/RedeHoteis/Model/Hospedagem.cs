using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedeHoteis.Model
{
    public class Hospedagem
    {
        public int Id { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime PrevistaSaida { get; set; }
        public Reserva Reserva { get; set; }
    }
}