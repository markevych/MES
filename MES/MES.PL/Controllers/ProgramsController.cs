namespace MES.PL.Controllers
{
    using System;
    using MES.BLL.Interfaces;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramService programService;

        public ProgramsController(IProgramService programService)
        {
            this.programService = programService;
        }

        [HttpGet]
        public ActionResult<string> GetProgram(Guid id) =>
            this.programService.CreateProgram();
    }
}