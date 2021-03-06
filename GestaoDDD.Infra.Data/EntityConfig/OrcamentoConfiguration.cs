﻿using System;
using GestaoDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDDD.Infra.Data.EntityConfig
{
    public class OrcamentoConfiguration : EntityTypeConfiguration<Orcamento>
    {
        public OrcamentoConfiguration()
        {
            HasKey(c => c.orc_Id);

            Property(c => c.orc_descricao)
                .IsRequired()
                .HasMaxLength(500).HasColumnName("descricao");

            Property(c => c.orc_endereco)
                .IsRequired().HasColumnName("endereco");

            Property(c => c.orc_prazo)
                .IsRequired().HasColumnName("prazo");

            Property(c => c.orc_nome_solicitante)
                .IsRequired()
                .HasMaxLength(200).HasColumnName("solicitante");

            Property(c => c.orc_email_solicitante)
                .HasMaxLength(200)
                .IsRequired().HasColumnName("email_solicitante");

            Property(c => c.orc_telefone_solicitante)
                .IsRequired().HasColumnName("telefone_solicitante");

            Property(c => c.orc_endereco_solicitante)
                .HasMaxLength(200).HasColumnName("endereco_solicitante");

            Property(c => c.serv_Id).HasColumnName("servico_id");

            Property(c => c.orc_latitude).HasColumnName("latitude");

            Property(c => c.orc_longitude).HasColumnName("longitude");

            Property(c => c.data_alteracao).HasColumnName("data_alteracao");

            Property(c => c.data_inclusao).HasColumnName("data_inclusao");

            Property(c => c.orc_cidade).HasColumnName("cidade");

            Property(c => c.orc_estado).HasColumnName("estado");

            Property(c => c.Status).HasColumnName("status");

            Property(c => c.Distancia).HasColumnName("distancia");

            HasMany<Prestador>(p => p.PrestadorFk)
                .WithMany(o => o.OrcamentoFk)
                .Map(po =>
                {
                    po.MapLeftKey("orcamento_id_fk");
                    po.MapRightKey("prestador_id_fk");
                    po.ToTable("OrcamentoPrestador");
                });
        }
    }
}
