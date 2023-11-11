using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;


namespace DataAccess.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> o) : base(o)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Expert> Experts { get; set; }
    public DbSet<Role> Roles { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<UserPreference> UserPreferences { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<CategoryVideo> CategoryVideos { get; set; }
    public DbSet<PostCast> PostCasts { get; set; }
    public DbSet<CategoryPostCast> CategoryPostCasts { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

     public DbSet<MeetingRoom> MeetingRooms { get; set; }

}

