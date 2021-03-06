﻿using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class BaseRepository<T> where T : BaseEntity, new()
    {
        private DbContext Context { get; }

        protected DbSet<T> Items { get; set; }

        public BaseRepository()
        {
            Context = new BankSystemDbContext();
            Items = Context.Set<T>();
        }

        public T GetById(int id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null, int? page = null, int? pageSize = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            
            if (page != null && pageSize != null)
            {
                query = query
                        .OrderBy(i => i.Id)
                        .Skip(page.Value * pageSize.Value)
                        .Take(pageSize.Value);
            }
                
            return query.ToList();
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.Count();
        }

        public void Save(T item)
        {
            if (item.Id <= 0)
            {
                Items.Add(item);
            }
            else
            {
                Context.Entry(item).State = EntityState.Modified;
            }
                

            Context.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);

            Context.SaveChanges();
        }
    }
}
