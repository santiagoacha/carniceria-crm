﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarniceriaCRM.BE
{
    public class Categoria : DigitVerifierBase
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}