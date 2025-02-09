﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG6.Entidades
{
    public class Funcion
    {
        public DateTime fechaHora { get; set; }
        public int sala { get; set; }
        public int pelicula { get; set; }
        public string nombrePelicula { get; set; }
        public string estado { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public int TipoEdicion { get; set; }

        public Funcion(DateTime fechaHora, int sala, int pelicula,string nombrePelicula ,string estado, DateTime fechaInicio, DateTime fechaFin, int TipoEdicion)
        {
            this.fechaHora = fechaHora;
            this.sala = sala;
            this.pelicula = pelicula;
            this.nombrePelicula = nombrePelicula;
            this.estado = estado;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.TipoEdicion = TipoEdicion;
        }

        public Funcion () { }
    }
}
