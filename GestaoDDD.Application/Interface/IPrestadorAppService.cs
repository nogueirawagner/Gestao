﻿using GestaoDDD.Domain.Entities;

namespace GestaoDDD.Application.Interface
{
    public interface IPrestadorAppService : IAppServiceBase<Prestador>
    {
        Prestador GetPorCpf(string cpf);
        Prestador GetPorGuid(string guid);

        //retorna o prestador atraves do email
        Prestador GetPorEmail(string email);
    }
}
