using Microsoft.EntityFrameworkCore;

namespace Mission06_Fisher.Models
{
    public class JoelHiltonMovieCollectionContext : DbContext
    {
        public JoelHiltonMovieCollectionContext(DbContextOptions<JoelHiltonMovieCollectionContext> options) : base (options) 
        { 
        }
        public DbSet<Form> Movies { get; set; }
    }
}
