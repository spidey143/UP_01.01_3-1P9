﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JournalApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Jurnal> Jurnal { get; set; }
        public virtual DbSet<Special> Special { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<StudentGrade> StudentGrade { get; set; }
    }
}
