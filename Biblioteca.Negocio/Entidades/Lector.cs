﻿using Biblioteca.Negocio.Entidades;
using System;
using System.Collections.Generic;

namespace Biblioteca.Negocio.Entidades
{
    public class Lector : Usuario
    {
        public Lector(string nombre, string apellido, string email, string telefono, string tipoLector, string preferencia)
        {
            base.PrimerNombre = nombre;
            base.PrimerApellido = apellido;
            base.Correo = email;
            base.Telefono = telefono;
            this.TipoLector = tipoLector;
            this.Preferencias = preferencia;
        }

        public Lector()
        {

        }

        public int LectorId { get; set; }
        public string TipoLector { get; set; } 
        public string Preferencias { get; set; }
        public List<LectorLibros> LectorLibros { get; set; } = new List<LectorLibros>();

        public string Descripcion()
        {
            return $"Hola mis preferencias en libros son: {Preferencias}.";
        }

        public override string Saludo()
        {
            return $"Hola mi nombre es: {base.PrimerNombre} {base.PrimerApellido}";
        }

        public string Leer()
        {
            return "Me gusta leer mucho";
        }


    }
}
