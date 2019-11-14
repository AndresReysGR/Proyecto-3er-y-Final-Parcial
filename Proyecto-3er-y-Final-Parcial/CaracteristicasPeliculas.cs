using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_3er_y_Final_Parcial
{
    class CaracteristicasPeliculas
    {
        public string TituloP { get; set; }
        public int AñoP { get; set; }
        public string GeneroP { get; set; }
        public string DirectorP { get; set; }
        public string SinopsisP { get; set; }
        public int RatingP { get; set;}

        public CaracteristicasPeliculas(string titulop, int añop, string generop, string directorp, string sinopsisp, int ratingp)
        {
            this.TituloP = titulop;
            this.AñoP = añop;
            this.GeneroP = generop;
            this.DirectorP = directorp;
            this.SinopsisP = sinopsisp;
            this.RatingP = ratingp;
        }

        public override string ToString()
        {
            return this.TituloP + "(" + this.AñoP + ")";
        }
    }
}
