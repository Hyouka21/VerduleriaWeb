
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using VerduleriaWeb.Entidades;

namespace VerduleriaWeb.EntityFramework
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
