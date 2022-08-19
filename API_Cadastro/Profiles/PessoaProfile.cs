using API_Cadastro.Data.Dtos.Pessoa;
using API_Cadastro.Models;
using AutoMapper;

namespace API_Cadastro.Profiles
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<CreatePessoaDto, Pessoa>();
            CreateMap<Pessoa, ReadPessoaDto>();
            CreateMap<UpdatePessoaDto, Pessoa>();
        }
    }
}
