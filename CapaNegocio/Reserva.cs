using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace CapaNegocio
{
    [Serializable]
    public class Reserva
    {
        public string nroReserva;
        public Vivienda viviendaReservada;
        public Cliente clienteReserva;
        public DateTime fechaInicioReserva;

        public Reserva(string nroReserva, Vivienda viviendaReservada, Cliente clienteReserva, DateTime fechaInicioReserva)
        {
            this.nroReserva = nroReserva;
            this.viviendaReservada = viviendaReservada;
            this.clienteReserva = clienteReserva;
            this.fechaInicioReserva = fechaInicioReserva;
        }


    }
}
