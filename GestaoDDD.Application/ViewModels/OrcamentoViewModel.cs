﻿using System.Collections.Generic;
using System.ComponentModel;
using GestaoDDD.Domain.Entities;
using EnumClass = GestaoDDD.Domain.Entities.NoSql;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoDDD.Application.ViewModels
{
    public class OrcamentoViewModel
    {
        [Key]
        [ScaffoldColumn(true)]
        public int orc_Id { get; set; }

        [Required(ErrorMessage = "Preencha uma breve descrição")]
        [MaxLength(250, ErrorMessage = "Tamanho máximo de {0} caracteres.")]
        [MinLength(10, ErrorMessage = "Tamanho minímo de {0} caracteres.")]
        [DisplayName("Descrição:")]
        public string orc_descricao { get; set; }

         [DisplayName("Endereço")]
        [Required(ErrorMessage = "Preencha o endereço do serviço.")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo de {0} caracteres.")]
        [MinLength(10, ErrorMessage = "Tamanho minímo de {0} caracteres.")]
        public string orc_Endereco { get; set; }

         [DisplayName("Prazo")]
        [Required(ErrorMessage = "Preencha o prazo do serviço.")]
        public string orc_prazo { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Preencha o campo nome.")]
        public string orc_nome_solicitante { get; set; }

        [DisplayName("Email:")]
        [DataType(DataType.EmailAddress,  ErrorMessage = "Digite um E-mail válido.")]
        [Required(ErrorMessage = "Preencha o campo email.")]
        public string orc_email_solicitante { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Preencha o campo telefone.")]
        public string orc_telefone_solicitante { get; set; }

        public string orc_endereco_solicitante { get; set; }

        [Display(AutoGenerateField= false)]
        public string  orc_latitude { get; set; }

        [Display(AutoGenerateField = false)]
        public string orc_longitude { get; set; }

        public string orc_cidade { get; set; }

        public EnumClass.EnumEstados orc_estado { get; set; }

        // [Required(ErrorMessage = "Selecione a categoria na qual pertence seu orçamento.")]
        //public virtual Categoria categoria_id { get; set; }
        public int serv_Id { get; set; }
        public EnumClass.EnumStatusOrcamento Status { get; set; }

        [NotMapped]
        public string Distancia { get; set; }
        public virtual ICollection<Prestador> PrestadorFk { get; set; }

        [NotMapped]
        public string NomeServico { get; set; }

        [DisplayName("Li e aceito as condições")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "Aceite os termos e condições")]
        public bool TermosECondicoes { get; set; }

    }


}