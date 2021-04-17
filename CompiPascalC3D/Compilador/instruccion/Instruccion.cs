using CompiPascalC3D.Compilador.simbolo;
using System;
using System.Collections.Generic;
using System.Text;
using Type = CompiPascalC3D.Compilador.utils.Type;

namespace CompiPascalC3D.Compilador.instruccion
{
    abstract class Instruccion
    {
        int linea;
        int columna;

        public Instruccion(int linea, int columna)
        {
            this.linea = linea;
            this.columna = columna;
        }

        public abstract object compilar(Entorno entorno);

        public bool sameType(Type tipo1, Type tipo2)
        {
            throw new NotImplementedException();
        }
    }
}
