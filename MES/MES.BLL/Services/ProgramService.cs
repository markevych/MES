namespace MES.BLL.Services
{
    using AutoMapper;
    using MES.BLL.Interfaces;
    using MES.BLL.Models.DataTransfer;
    using MES.DAL.Entities.Program;
    using MES.DAL.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramService : IProgramService
    {
        private readonly IRepository<Program> programs;

        private readonly IMapper mapper;

        public ProgramService(
            IRepository<Program> programs,
            IMapper mapper)
        {
            this.programs = programs;
            this.mapper = mapper;
        }

        public void CreateProgram(ProgramDto program) =>
            this.programs.Create(this.mapper.Map<Program>(program));

        public void UpdateProgram(ProgramDto program) =>
            this.programs.Update(this.mapper.Map<Program>(program));

        public void RemoveProgram(Guid programId)
        {
            var program = this.programs.FindById(programId);
            this.programs.Remove(program);
        }

        public List<Program> GetPrograms() =>
            this.programs.Get().ToList();

        public Program GetProgram(Guid programId) =>
            this.programs.FindById(programId);
    }
}
