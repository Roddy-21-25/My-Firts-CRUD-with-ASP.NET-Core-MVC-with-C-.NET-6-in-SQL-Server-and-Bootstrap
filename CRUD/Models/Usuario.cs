using System;
using System.Collections.Generic;

namespace CRUD.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public int? Nota { get; set; }
        public string? Grade { get; set; }
        public string? Materia { get; set; }
    }
}
