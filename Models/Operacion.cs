using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PC1.Models
{
   public class Operacion
    {
        
    public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public List<string>? InstrumentosSelec { get; set; }
        public decimal MontoAbonar { get; set; }
        public decimal IGV;
        public decimal Comision { get; set; }
        public decimal TotalAPagar { get; set; }

        public void TotalInversion()
        {
            IGV = 0M;
            foreach (var instrumento in InstrumentosSelec)
            {
                decimal montoInstrumento = instrumento switch
                {
                    "SP500" => 500M,
                    "DowJones" => 300M,
                    "BonosUS" => 120M,
                    _ => 0M
                };
                IGV += montoInstrumento * 0.18M;
            }

            Comision = MontoAbonar > 300 ? 1M : 3M;
            TotalAPagar = MontoAbonar + IGV + Comision;
        }
    }
}