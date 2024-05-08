using System.Collections.Generic;

namespace EFBlog.Models
{
    /*
     SQL SCRIPT:

    CREATE TABLE [User] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] NVARCHAR(80) NOT NULL,
    [Email] VARCHAR(200) NOT NULL,
    [PasswordHash] VARCHAR(255) NOT NULL,
    [Bio] TEXT NOT NULL,
    [Image] VARCHAR(2000) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,

        CONSTRAINT [PK_User] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_User_Email] UNIQUE([Email]),
    CONSTRAINT [UQ_User_Slug] UNIQUE([Slug])
        )
    CREATE NONCLUSTERED INDEX [IX_User_Email] ON [User]([Email])
    CREATE NONCLUSTERED INDEX [IX_User_Slug] ON [User]([Slug])
    */
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public IList<Post> Posts { get; set; }
        public IList<Role> Roles { get; set; }
    }
}