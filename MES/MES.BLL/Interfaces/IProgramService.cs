using MES.BLL.Models.DataTransfer;
using MES.DAL.Entities.Program;
using System;
using System.Collections.Generic;

namespace MES.BLL.Interfaces
{
    public interface IProgramService
    {
        void CreateProgram(ProgramDto program);

        void UpdateProgram(ProgramDto program);

        void RemoveProgram(Guid programId);

        List<Program> GetPrograms();

        Program GetProgram(Guid programId);
    }
}
