using CompiPascalC3D.Compilador.instruccion;
using CompiPascalC3D.Compilador.utils;
using System;
using System.Collections.Generic;
using System.Text;
using Type =CompiPascalC3D.Compilador.utils.Type;

namespace CompiPascalC3D.Compilador.simbolo
{
    class SimboloFuncionMetodo
    {
        Type tipo;
        string id;
        string idUnico;
        int tamanio;
        LinkedList<Parametro> parametros;


        public SimboloFuncionMetodo(FuncionInstruccion func, string idUnico)
        {
            throw new NotImplementedException();
        }
    }
}
