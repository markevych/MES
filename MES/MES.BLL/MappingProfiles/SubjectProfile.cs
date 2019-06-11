namespace MES.BLL.MappingProfiles
{
    using AutoMapper;
    using MES.BLL.Models.DataTransfer;
    using MES.DAL.Entities.Program;

    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            this.CreateMap<SubjectDto, Subject>();
        }
    }
}
