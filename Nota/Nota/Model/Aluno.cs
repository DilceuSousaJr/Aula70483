﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota.Model
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }

        public string Status { get { return Resultado(); } }

        public string Resultado()
        {
            var media = (Nota1 + Nota1 + Nota3) / 3;

            if (media >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
