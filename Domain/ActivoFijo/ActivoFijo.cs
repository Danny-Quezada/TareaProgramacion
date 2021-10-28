using Domain.ActivoFijo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ActivoFijo
{
    public class ActivoFijo
    {

        public string Nombre { get; set; }
        public int Id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }

        public decimal ValorActivo { get; set; }

        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaDeAdquisicion { get; set; }

        public EnumsTipoActivo TipoActivo { get; set; }
        public Depreciacion depreciacion { get; set; }

        public String toString()
        {

            return $"Nombre: {Nombre}       codigo: {codigo}    ID: {Id}    descripcion: {descripcion}      Vida Util: {VidaUtil}  " +
                $" Depreciacion: {Environment.NewLine}";
        }




    }
}
