using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq.Expressions;


namespace LeerData
{
  internal class Program
  {
    static void Main(string[] args)
    {
      using (var dataBase = new AppVentaCursosContext())
      {
        var cursos = dataBase.Curso.AsNoTracking(); //ARREGLO iQuerable
        foreach (var curso in cursos)
        {
          Console.WriteLine(curso.Titulo);
        }
      }
    }
  }
}