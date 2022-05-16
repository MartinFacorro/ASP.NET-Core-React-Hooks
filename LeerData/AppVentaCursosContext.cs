using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
  /// <summary>
  /// Esta clase se encargara de tener la configuracion de conexion a SQL Server.
  /// </summary>
  public class AppVentaCursosContext : DbContext
  {
    //PROPIEDADES
    private const string connectionString = @"Data Source=.\\SQLExpress;Initial Catalog=CursosOnline;Integrated Security=True";
    public DbSet<Curso> Curso { get; set; }

    //METODOS
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) { 
      
      optionBuilder.UseSqlServer(connectionString); //CREADA LA CONFIGURACION PARA LA INSTANCIA DE LA BASE DE DATOS.
    
    }



  }
}