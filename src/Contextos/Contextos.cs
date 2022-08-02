using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class BlogPessoalContexto : Microsoft.EntityFrameworkCore.DbContext
{

#region Atributo

    public Microsoft.EntityFrameworkCore.DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Tema> Temas { get; set; }
    public DbSet<Postagem> Postagens { get; set; }
    #endregion
    #region Construtores
    public BlogPessoalContexto(DbContextOptions<BlogPessoalContexto> opt) :
    base(>opt)
    {
    }
    #endregion
}
