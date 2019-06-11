using AutoMapper;
using MES.BLL.Models.DataTransfer;
using MES.DAL.Entities.Program;

namespace MES.BLL.MappingProfiles
{
    public class ProgramProfile : Profile
    {
        public ProgramProfile()
        {
            this.CreateMap<ProgramDto, Program>();
        }
    }
}
