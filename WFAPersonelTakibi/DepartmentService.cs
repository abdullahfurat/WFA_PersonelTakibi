using System;
using System.Collections.Generic;

namespace WFAPersonelTakibi
{
    public class DepartmentService : IService<Department>
    {
        private static List<Department> departments = new List<Department>();
        public void Add(Department entity)
        {
            departments.Add(entity);
        }

        public bool Delete(Department entity)
        {
            return departments.Remove(entity);
        }

        public List<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public Department GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
