using MyAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity.Attributes;

namespace MyAppMVC.Repositories
{
    //The EmployeeInfo Repository Class. This is used to 
    //Isolate the EntityFramework based Data Access Layer from
    //the MVC Controller class
    public class EmployeeInfoRepository : IRepository<EmployeeInfo, int>
    {
        [Dependency]
        public ApplicationEntities context { get; set; }

        public IEnumerable<EmployeeInfo> Get()
        {
            return context.EmployeeInfo.ToList();
        }

        public EmployeeInfo Get(int id)
        {
            return context.EmployeeInfo.Find(id);
        }

        public void Add(EmployeeInfo entity)
        {
            context.EmployeeInfo.Add(entity);
            context.SaveChanges();
        }

        public void Remove(EmployeeInfo entity)
        {
            var obj = context.EmployeeInfo.Find(entity.EmpNo);
            context.EmployeeInfo.Remove(obj);
            context.SaveChanges();
        }
    }
}