using System.Collections.Generic;
using Webvendas.Data;
using Webvendas.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Webvendas.Services.Exceptions;

namespace Webvendas.Services

{
    public class SellerService
    {

        private readonly WebvendasContext _context;

        public SellerService(WebvendasContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            // eager loading => equivalente ao Join de tabelas relacionados ao objeto principal.
            // include, está relacionado ao Entity Framework e não ao Linq.
            return 
                _context.Sellers
                .Include(obj => obj.Department)
                .FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if (!_context.Sellers.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id nof found!");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();

            } catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            } 
    

        }


    }
}
