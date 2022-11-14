using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; // projeye nuget packages kısmından entity'i dahil ettikten sonra bu kütüphaneyi DbSet kullanabilmek için ekliyoruz.

namespace SkillsProfileProject_MVC_EntityFramework.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Skills> Skills {get; set;}
    }
}