﻿using System.Collections.Generic;

namespace EFBlog.Models
{
    /*
     CREATE TABLE [Category] (
    [Id] INT NOT NULL IDENTITY(1, 1),
    [Name] VARCHAR(80) NOT NULL,
    [Slug] VARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Category] PRIMARY KEY([Id]),
    CONSTRAINT [UQ_Category_Slug] UNIQUE([Slug])
)
CREATE NONCLUSTERED INDEX [IX_Category_Slug] ON [Category]([Slug])
*/
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        
        public IList<Post> Posts { get; set; }
    }
}