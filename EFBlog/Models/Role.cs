using System.Collections.Generic;

namespace EFBlog.Models
{
    /*
    CREATE TABLE [Role] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(80) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,

        CONSTRAINT [PK_Role] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Role_Slug] UNIQUE([Slug])
        )
    CREATE NONCLUSTERED INDEX [IX_Role_Slug] ON [Role]([Slug])
        */
    
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public IList<User> Users { get; set; }
        
    }
}