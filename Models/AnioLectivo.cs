﻿using BlazorAppVSCode.Interfaces.Commons;
using BlazorAppVSCode.Pages.Materias;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppVSCode.Models
{
    public class AnioLectivo : IEntityIdNombre
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre debe cargarse obligatoriamente")]
        public string Nombre { get; set; }=string.Empty;

        public override string ToString()
        {
            return $"Id ={Id} {Environment.NewLine}" +
                   $"Nombre= {Nombre} {Environment.NewLine}" ;
        }
    }
}