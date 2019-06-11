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

    public class SubjectService : ISubjectService
    {
        private readonly IRepository<Subject> Subjects;

        private readonly IMapper mapper;

        public SubjectService(
            IRepository<Subject> Subjects,
            IMapper mapper)
        {
            this.Subjects = Subjects;
            this.mapper = mapper;
        }

        public void CreateSubject(SubjectDto Subject) =>
            this.Subjects.Create(this.mapper.Map<Subject>(Subject));

        public void UpdateSubject(SubjectDto Subject) =>
            this.Subjects.Update(this.mapper.Map<Subject>(Subject));

        public void RemoveSubject(Guid SubjectId)
        {
            var Subject = this.Subjects.FindById(SubjectId);
            this.Subjects.Remove(Subject);
        }

        public List<Subject> GetSubjects(Guid programId) =>
            this.Subjects.Get(e => e.ProgramId == programId).ToList();

        public Subject GetSubject(Guid SubjectId) =>
            this.Subjects.FindById(SubjectId);
    }
}
