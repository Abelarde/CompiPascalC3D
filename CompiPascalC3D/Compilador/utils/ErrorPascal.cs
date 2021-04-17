using System;
using System.Collections.Generic;
using System.Text;

namespace CompiPascalC3D.Compilador.utils
{
    class ErrorPascal
    {
        private int linea, columna;
        private string mensaje;
        private string tipo;

        public ErrorPascal(string mensaje, int linea, int columna, string tipo)
        {
            this.mensaje = mensaje;
            this.linea = linea;
            this.columna = columna;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return this.mensaje + "," + this.linea + "," + this.columna + "," + this.tipo;
        }
    }
}
