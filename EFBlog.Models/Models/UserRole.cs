namespace EFBlog.Models.Models
{
    /*
     * CREATE TABLE [UserRole] (
    [UserId] INT NOT NULL,
    [RoleId] INT NOT NULL,

    CONSTRAINT [PK_UserRole] PRIMARY KEY([UserId], [RoleId])
)

     */
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}