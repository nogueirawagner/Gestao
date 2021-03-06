﻿using GestaoDDD.Domain.Entities;
using GestaoDDD.Domain.Interfaces.Repositories;
using GestaoDDD.Infra.Data.Contexto;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GestaoDDD.Infra.Data.Repositories
{
    public class ServicoPrestadorRepository : RepositoryBase<ServicoPrestador>, IServicoPrestadorRepository
    {
        private readonly GestaoContext _dbContext;

        public ServicoPrestadorRepository(GestaoContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void SalvarServicosPrestador(IEnumerable<Servico> servicos, Prestador prestador) 
        {
            var servicoPrestador = new ServicoPrestador();
            //var servicosPrestador = _db.ServicoPrestador.FirstOrDefault(s => s.serv_Pres_Id.Equals(prestador.pres_Id));

            foreach (var check in servicos)
            {
                //servicoPrestador.Prestador = prestador;
                //servicoPrestador.Servico = check;
                servicoPrestador.pres_Id = prestador.pres_Id;
                servicoPrestador.serv_Id = check.serv_Id;
                SaveOrUpdate(servicoPrestador);
            }
        }

        public IEnumerable<ServicoPrestador> GetServicoPorPrestadorId(string prestadorId)
        {
            return _db.ServicoPrestador.Where(s => s.Prestador.pres_Id.Equals(prestadorId));
        }


        public IEnumerable<ServicoPrestador> GetByServicoId(int servicoId)
        {
            return _db.ServicoPrestador.Where(s => s.Servico.serv_Id.Equals(servicoId));
        }

        // public IEnumerable<Guid> PrestadoresOferecemServico(int servicoId)
        public IEnumerable<Guid> PrestadoresOferecemServico(int servicoId)
        {
            var servicos = _db.ServicoPrestador.Where(s => s.Servico.serv_Id.Equals(servicoId));
            var list = new List<Guid>();
            foreach (var guid in servicos)
            {
                list.Add(Guid.Parse(guid.pres_Id));
            }
            return list;
        }
    }
}
