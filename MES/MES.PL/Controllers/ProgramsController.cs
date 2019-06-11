namespace MES.PL.Controllers
{
    using System;
    using MES.BLL.Interfaces;
    using MES.BLL.Models.DataTransfer;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramService programService;
        private readonly ISubjectService subjectService;

        public ProgramsController(IProgramService programService, ISubjectService subjectService)
        {
            this.programService = programService;
        }

        [HttpPost]
        public ActionResult CreateProgram([FromBody] ProgramDto program)
        {
            this.programService.CreateProgram(program);
            return this.Ok();
        }

        [HttpPut]
        public ActionResult UpdateProgram([FromBody] ProgramDto program)
        {
            this.programService.UpdateProgram(program);
            return this.Ok();
        }

        [HttpDelete("{programId}")]
        public ActionResult RemoveProgram([FromRoute] Guid programId)
        {
            this.programService.RemoveProgram(programId);
            return this.Ok();
        }

        [HttpGet]
        public ActionResult GetPrograms() =>
            this.Ok(this.programService.GetPrograms());

        [HttpGet("{programId}")]
        public ActionResult GetProgram(Guid programId) =>
            this.Ok(this.programService.GetProgram(programId));

        [HttpGet("{pogramId}/subjects")]
        public ActionResult GetSubjects([FromRoute] Guid programId) =>
            this.Ok(this.subjectService.GetSubjects(programId));
    }
}