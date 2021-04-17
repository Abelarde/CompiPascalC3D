using System;
using System.Collections.Generic;
using System.Text;
using Type = CompiPascalC3D.Compilador.utils.Type;

namespace CompiPascalC3D.Compilador.utils
{
    class Parametro
    {
        string id;
        Type tipo;

        public Parametro(string id, Type tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }

        public string Id { get => id; set => id = value; }
        internal Type Tipo { get => tipo; set => tipo = value; }

        public string obtenerTipo()
        {
            if (this.tipo.tipo == Tipos.OBJECT)
                return this.tipo.tipoAuxiliar;
            else
                return this.tipo.tipo.ToString();
        }

    }
}
