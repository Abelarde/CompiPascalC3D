using System;
using System.Collections.Generic;
using System.Text;
using Type = CompiPascalC3D.Compilador.utils.Type;

namespace CompiPascalC3D.Compilador.simbolo
{
    class Simbolo
    {
        Type tipo;
        string id;
        int? posicion;
        bool isConst;
        bool isGlobal;
        bool isHeap;

        public Simbolo(Type tipo, string id, int? posicion, bool isConst, bool isGlobal, bool isHeap)
        {
            this.tipo = tipo;
            this.id = id;
            this.posicion = posicion;
            this.isConst = isConst;
            this.isGlobal = isGlobal;
            this.isHeap = isHeap;
        }
    }
}
