using System.Collections.Generic;
using Webvendas.Data;
using Webvendas.Models;
using System.Linq;

namespace Webvendas.Services
{
    public class DepartmentService
    {

        private readonly WebvendasContext _context;

        public DepartmentService(WebvendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }


    }
}
