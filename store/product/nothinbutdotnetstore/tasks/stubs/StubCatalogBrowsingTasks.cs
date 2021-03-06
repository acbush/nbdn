using System;
using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.dto;

namespace nothinbutdotnetstore.tasks.stubs
{
    public class StubCatalogBrowsingTasks : CatalogBrowsingTasks
    {
        public IEnumerable<Department> get_main_departments()
        {
            return Enumerable.Range(1, 100).Select(i => new Department { department_name = i.ToString("Department 0") });
        }

        public IEnumerable<Department> get_all_departments_in(Department department)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> get_products_in(Department department)
        {
            throw new NotImplementedException();
        }

        public void add_to_cart(Product product)
        {
            throw new NotImplementedException();
        }
    }
}