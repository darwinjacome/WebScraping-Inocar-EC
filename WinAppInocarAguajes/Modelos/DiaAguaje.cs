using System;

namespace WinAppAguajes
{
    public class DiaAguaje
    {
        public DiaAguaje(DateTime dfeAguaje)
        {
            this.dfeAguaje = dfeAguaje;
        }

        public string guid { get; set; }
        public DateTime dfeAguaje { get; set; }
    }
}