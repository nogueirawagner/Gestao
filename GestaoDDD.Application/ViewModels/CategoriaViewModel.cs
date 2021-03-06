﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestaoDDD.Application.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int cat_Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome")]
        public string cat_Nome { get; set; }
    }
}