using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna.classes
{
    public class Candidatos
    {
        public int Numero { get; set; }
        public string Candidato { get; set; }

        public string NomePopular { get; set; }

        public Image Foto{ get; set; }
    }
}