using CompiPascalC3D.Compilador.instruccion;
using CompiPascalC3D.Compilador.utils;
using System;
using System.Collections.Generic;
using System.Text;
using Type = CompiPascalC3D.Compilador.utils.Type;

namespace CompiPascalC3D.Compilador.simbolo
{
    class Entorno
    {
        Dictionary<string, SimboloFuncionMetodo> funciones;
        Dictionary<string, SimboloStruct> structs;
        Dictionary<string, Simbolo> variables;

        Entorno? anterior;

        int? tamanio;

        string? _break;
        string _continue;
        string? _return;

        string prop;

        SimboloFuncionMetodo? actualFuncion;

        public Entorno(Entorno anterior)
        {
            this.funciones = new Dictionary<string, SimboloFuncionMetodo>();
            this.structs = new Dictionary<string, SimboloStruct>();
            this.variables = new Dictionary<string, Simbolo>();

            this.anterior = anterior;

            this.tamanio = anterior.tamanio ?? 0;

            this._break = anterior._break ?? null;
            this._continue = anterior._continue ?? null;
            this._return = anterior._return ?? null;

            this.prop = "main";

            this.actualFuncion = anterior.actualFuncion ?? null;
        }


        public void setEntorno(string prop, SimboloFuncionMetodo actualFuncion, string _return)
        {
            this.tamanio = 1; //la pos 0 es para el return
            this.prop = prop;
            this._return = _return;
            this.actualFuncion = actualFuncion;
        }

        public Simbolo addVar(string id, Type type, bool isConst, bool isRef)
        {
           id = id.ToLower();

            if (this.variables.ContainsKey(id))
                return null;

            Simbolo nuevaVariable = new Simbolo(type, id, this.tamanio++, isConst, this.anterior == null, isRef);
            this.variables.Add(id, nuevaVariable);
            return nuevaVariable;
        }

        public bool addFuncMet(FuncionInstruccion func, string idUnico)
        {
            if (this.funciones.ContainsKey(func.Id.ToLower()))
                return false;
            this.funciones.Add(func.Id.ToLower(), new SimboloFuncionMetodo(func, idUnico));
            return true;
        }

        public bool addStruct(string id, int tamanio, LinkedList<Parametro> parametros)
        {
            if (this.structs.ContainsKey(id.ToLower()))
                return false;
            this.structs.Add(id.ToLower(), new SimboloStruct(id.ToLower(), tamanio, parametros));
            return true;
        }

        public Simbolo getVar(string id)
        {
            Entorno entorno = this;
            id = id.ToLower();
            while (entorno != null)
            {
                Simbolo sim = null;
                if (entorno.variables.TryGetValue(id, out sim))
                    return sim;

                entorno = entorno.anterior;
            }
            return null;
        }

        public SimboloFuncionMetodo getFuncMet(string id)
        {
            SimboloFuncionMetodo funcMet = null;
            this.funciones.TryGetValue(id.ToLower(), out funcMet);
            return funcMet;
        }

        public SimboloFuncionMetodo searchFuncMet(string id)
        {
            Entorno entorno = this;
            id = id.ToLower();

            while(entorno != null)
            {
                SimboloFuncionMetodo sim = null;
                if (entorno.funciones.TryGetValue(id, out sim))
                    return sim;

                entorno = entorno.anterior;
            }
            return null;
        }

        public Entorno getGlobal()
        {
            Entorno temp = this;
            while(temp.anterior != null)
            {
                temp = temp.anterior;
            }
            return temp;
        }

        public SimboloStruct getStruct(string id)
        {
            SimboloStruct stru = null;
            this.getGlobal().structs.TryGetValue(id.ToLower(), out stru);
            return stru;
        }

        
    }
}
