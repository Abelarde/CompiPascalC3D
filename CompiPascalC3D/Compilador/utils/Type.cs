using System;
using System.Collections.Generic;
using System.Text;

namespace CompiPascalC3D.Compilador.utils
{
    public enum Tipos
    {
        REAL = 0,
        INTEGER = 1,
        BOOLEAN = 2,
        ARRAY = 3,
        STRING = 4,
        OBJECT = 5,
        ERROR = 6
    }

    class Type
    {
        public Tipos tipo;
        public string tipoAuxiliar; 

        //TODO: dimension?
        public Type(Tipos tipo, string tipoAuxiliar)
        {
            this.tipo = tipo;
            this.tipoAuxiliar = tipoAuxiliar;
        }
    }
}
