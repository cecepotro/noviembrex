﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noviembrex.Core.Entidades {
    public class Modulo {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Horario { get; set; }
        public string Referencias { get; set; }
        public Municipio Municipio { get; set; }

    }
}
