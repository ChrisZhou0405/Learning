using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Entities
{
    public class LibraryDbContext:DbContext
    {
        //DbSet类型的属性，分别表示Author和Book两张数据表
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options) 
        {
        }

        /// <summary>
        /// 添加测试数据
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasData(
                new Author 
                {
                    Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A3330"),
                    Name = "Author1",
                    BirthDate = new DateTimeOffset(new DateTime(1960, 11, 18)),
                    Email = "authorl@xxx.com",
                    BirthPlace="广东广州"
                },
                new Author
                {
                    Id = new Guid("72D5B505-3008-49B7-B0D6-CC337F1A3330"),
                    Name = "Author2",
                    BirthDate = new DateTimeOffset(new DateTime(1960, 11, 18)),
                    Email = "authorl@xxx.com",
                    BirthPlace = "广东河源"
                }

            );
              
             
        }

    }
}
