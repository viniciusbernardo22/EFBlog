namespace EFBlog.Models.Models
{
    /*
     * CREATE TABLE [PostTag] (
    [PostId] INT NOT NULL,
    [TagId] INT NOT NULL,

    CONSTRAINT PK_PostTag PRIMARY KEY([PostId], [TagId])
)
     */
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
        
    }
}