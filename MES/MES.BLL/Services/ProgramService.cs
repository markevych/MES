namespace MES.BLL.Services
{
    using MES.BLL.Interfaces;
    using MES.DAL.Entities.Group;
    using MES.DAL.Interfaces;

    public class ProgramService : IProgramService
    {
        private readonly IRepository<Program> programs;

        public ProgramService(IRepository<Program> programs)
        {
            this.programs = programs;
        }

        public string CreateProgram()
        {
            return "Program was created";
        }
    }
}
