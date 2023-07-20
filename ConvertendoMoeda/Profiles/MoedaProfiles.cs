
using APImoeda.Models;
using AutoMapper;
using ConvertendoMoeda.Data.Dtos;

namespace APIMoeda.Profiles;


//Acontece o mapeamento de um CreateMoedaDto para um Moeda, através do AutoMapper.
public class MoedasProfile : Profile
{
    public MoedasProfile()
    {
        CreateMap<CreateMoedaDto, MoedasModel>();
        CreateMap<UpdateMoedaDto, MoedasModel>();
        CreateMap<MoedasModel, UpdateMoedaDto>();
        CreateMap<MoedasModel, ReadMoedaDto>();
    }
}