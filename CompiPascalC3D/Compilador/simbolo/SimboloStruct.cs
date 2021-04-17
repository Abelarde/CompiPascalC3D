using CompiPascalC3D.Compilador.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompiPascalC3D.Compilador.simbolo
{
    class SimboloStruct
    {
        string id;
        int tamanio;
        LinkedList<Parametro> atributos;

        public SimboloStruct(string id, int tamanio, LinkedList<Parametro> atributos)
        {
            this.id = id;
            this.tamanio = tamanio;
            this.atributos = atributos;
        }

        public Parametro getAtributo(string id)
        {
            foreach(Parametro param in atributos)
            {
                if (param.Id == id)
                    return param;
            }
            return null;
        }
    }
}
