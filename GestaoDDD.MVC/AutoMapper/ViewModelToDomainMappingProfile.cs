﻿using AutoMapper;
using GestaoDDD.Application.ViewModels;
using GestaoDDD.Domain.Entities;

namespace GestaoDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        //public string ProfileName
        //{
        //    get { return "ViewModelToDomainMappings"; }
        //}

        protected override void Configure()
        {
            //mapeia classe para categoria
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Servico, ServicoViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Orcamento, OrcamentoViewModel>();
        }
    }
}