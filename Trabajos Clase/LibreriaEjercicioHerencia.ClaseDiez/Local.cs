﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEjercicioHerencia.ClaseDiez
{
    public class Local : Llamada
    {
        protected float _costo;

        public float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(string origen, float duracion, string destino, float costo)
            : base(origen,destino,duracion)
        {
            this._costo = costo;
 
        }

        public Local(Llamada unaLlamada, float costo) : 
            this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {

        }

        protected override string Mostrar()
        {
            return "Duracion: " + base.Duracion + "\nNumero Origen: " + base.NroOrigen + "\nNumero Destino: " + base.NroDestino + "\nCosto Llamada: "+ this.CostoLlamada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.CostoLlamada;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Local)
                retorno = true;

            return retorno;
        }
    }
}
