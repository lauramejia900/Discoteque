using Microsoft.EntityFrameworkCore; //es como el import en javaScript para importar librerias y demas
using Discoteque.Data.Models;

namespace Discoteque.Data;

public class DiscotequeContext : DbContext //realiza las configuraciones para la base de datos
{
    public DiscotequeContext(DbContextOptions<DiscotequeContext> options) : base(options) //configuracion de la base de Datos
    {
    }

    public DbSet<Artist> Artists { get; set; } //Es una tabla en la base de datos 
    public DbSet<Album > Albums {get; set;} 

}