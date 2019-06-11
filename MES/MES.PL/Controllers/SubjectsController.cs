namespace MES.PL.Controllers
{
    using System;
    using MES.BLL.Interfaces;
    using MES.BLL.Models.DataTransfer;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        [HttpPost]
        public ActionResult CreateSubject([FromBody] SubjectDto subject)
        {
            this.subjectService.CreateSubject(subject);
            return this.Ok();
        }

        [HttpPut]
        public ActionResult UpdateSubject([FromBody] SubjectDto subject)
        {
            this.subjectService.UpdateSubject(subject);
            return this.Ok();
        }

        [HttpDelete("{subjectId}")]
        public ActionResult RemoveSubject([FromRoute] Guid subjectId)
        {
            this.subjectService.RemoveSubject(subjectId);
            return this.Ok();
        }

        [HttpGet("{subjectId}")]
        public ActionResult GetSubject(Guid subjectId) =>
            this.Ok(this.subjectService.GetSubject(subjectId));
    }
}