using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.v2.Data;
using SalesWebMvc.v2.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.v2.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcv2Context _context;

        public DepartmentService(SalesWebMvcv2Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
