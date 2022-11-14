using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillsProfileProject_MVC_EntityFramework.Models.Classes
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        public string Information { get; set; }

        public byte Value { get; set; }
    }
}