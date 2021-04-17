using CompiPascalC3D.Compilador.simbolo;
using CompiPascalC3D.Compilador.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompiPascalC3D.Compilador.expresion
{
    abstract class Expresion
    {
        string trueLabel;
        string falseLabel;
        int linea;
        int columna;

        public Expresion(int linea, int columna)
        {
            this.trueLabel = this.falseLabel = "";
            this.linea = linea;
            this.columna = columna;
        }

        public abstract Retorno compilar(Entorno entorno);
    }
}
