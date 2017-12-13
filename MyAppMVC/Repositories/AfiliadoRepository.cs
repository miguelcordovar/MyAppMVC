using MyAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Attributes;
using System.Data.Entity;


namespace MyAppMVC.Repositories
{
    //The Afiliado Repository Class. This is used to 
    //Isolate the EntityFramework based Data Access Layer from
    //the MVC Controller class
    public class AfiliadoRepository : IRepository<Afiliado, int>
    {
        [Dependency]
        public ApplicationEntities context { get; set; }

        public IEnumerable<Afiliado> Get()
        {
            /*
            return context.Afiliado
                            .Include(s => s.Cliente)
                            .Include(s => s.Cliente.TipoDocumento)
                            .Include(s => s.Cliente.TipoCliente)
                            .ToList();
            */

            return context.Afiliado.ToList();

        }

        public Afiliado Get(int id)
        {
            return context.Afiliado.Find(id);
        }

        public void Add(Afiliado entity)
        {
            context.Afiliado.Add(entity);
            context.SaveChanges();
        }

        public void Remove(Afiliado entity)
        {
            var obj = context.Afiliado.Find(entity.ClienteId);
            context.Afiliado.Remove(obj);
            context.SaveChanges();
        }
    }
}