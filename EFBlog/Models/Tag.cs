using System.Collections.Generic;

namespace EFBlog.Models
{
    /*CREATE TABLE [Tag] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(80) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Tag] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Tag_Slug] UNIQUE([Slug])
)
CREATE NONCLUSTERED INDEX [IX_Tag_Slug] ON [Tag]([Slug])*/
    
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Post> Posts { get; set; }
    }
}