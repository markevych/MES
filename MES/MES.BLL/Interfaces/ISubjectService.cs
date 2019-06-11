using MES.BLL.Models.DataTransfer;
using MES.DAL.Entities.Program;
using System;
using System.Collections.Generic;

namespace MES.BLL.Interfaces
{
    public interface ISubjectService
    {
        void CreateSubject(SubjectDto subject);

        void UpdateSubject(SubjectDto subject);

        void RemoveSubject(Guid subjectId);

        List<Subject> GetSubjects(Guid programId);

        Subject GetSubject(Guid subjectId);
    }
}
