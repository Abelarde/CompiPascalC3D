using System;
using System.Collections.Generic;
using System.Text;

namespace CompiPascalC3D.Compilador.utils
{
    class Struct : Type
    {
        Dictionary<string, object> atributos;
        int tamanio;

        public Struct(string id, Dictionary<string, object> atributos)
            :base(Tipos.OBJECT, id)
        {
            this.atributos = atributos;
            this.tamanio = atributos.Count;
        }
    }
}
