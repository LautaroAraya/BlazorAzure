﻿using BlazorAppVSCode.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppVSCode.Models
{
    public class DetalleInscripcion
    {
        public int Id { get; set; }
        public ModalidadCursadoEnum ModalidadCursado { get; set; }
        public int InscripcionId { get; set; }
        public Inscripcion? Inscripcion { get; set; }
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }
        public override string ToString()
        {
            return $"{Materia?.Nombre} {ModalidadCursado}" ?? string.Empty;
        }

    }
}
