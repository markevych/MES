namespace MES.BLL.Models.DataTransfer
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SubjectDto
    {
        public Guid? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int HoursQuantity { get; set; }

        [Required]
        public Guid ProgramId { get; set; }
    }
}
