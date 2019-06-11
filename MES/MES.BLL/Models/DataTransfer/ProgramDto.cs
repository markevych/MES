namespace MES.BLL.Models.DataTransfer
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ProgramDto
    {
        public Guid? Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
