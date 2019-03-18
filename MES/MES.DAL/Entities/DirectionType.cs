using MES.DAL.Enumerations;
using System;

namespace MES.DAL.Entities
{
    public class DirectionType
    {
        public Guid Id { get; set; }
        public DirectionTypeName Name { get; set; }
    }
}
