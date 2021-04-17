using CompiPascalC3D.Compilador.simbolo;
using System;
using System.Collections.Generic;
using System.Text;
using Type = CompiPascalC3D.Compilador.utils.Type;

namespace CompiPascalC3D.Compilador.utils
{
    class Retorno
    {
        string valor;
        bool isTemp;
        Type tipo;
        string trueLabel;
        string falseLabel;
        Simbolo simbolo;

        public Retorno(string valor, bool isTemp, Type tipo, Simbolo simbolo)
        {
            this.valor = valor;
            this.isTemp = isTemp;
            this.tipo = tipo;
            this.simbolo = simbolo;
            this.trueLabel = this.falseLabel = "";
        }

        public string obtenerValor()
        {
            throw new NotImplementedException();
        }
    }
}
