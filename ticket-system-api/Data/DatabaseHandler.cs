
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ticket_system_api.Interfaces;

namespace ticket_system_api.Data
{
    public class DatabaseHandler<T> : IDatabaseHandler where T:class
    {
        private readonly ticketContext _context;//Where am I??

        public DatabaseHandler(ticketContext context) {
            _context = context; // here I am!
        }
        public bool Delete<T1>(int id)
        {
            try
            {
                _context.Set<T>().Remove(id as T);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public T1 Find<T1>(object item_find)
        {
            throw new NotImplementedException();
        }

        public ICollection<T1> FindAll<T1>(object item_find)
        {
            throw new NotImplementedException();
        }
        //Types are fcked
        //public int Insert<T>(T insert_item) where T:class
        //{
        //    _context.Set<T>().Add(insert_item);
        //    return 1;
        //}

        public int Insert<T>(T insert_item)
        {
            throw new NotImplementedException(); //TODO
        }
        public bool Update<T1>(T1 update_item)
        {
            throw new NotImplementedException();
        }
    }
}
