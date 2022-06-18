﻿using System.Linq.Expressions;
using Gaby.Shared.Interfaces;
using Gaby.Shared.Pager;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gaby.Server.Infrastructure.Repository
{
    public  class GenericRepository<T> : IGenericRepository<T> where T : class, INamed
    {
        protected readonly GabyDbContext context;
        public GenericRepository(GabyDbContext context)
        {
            this.context = context;
        }
        public async Task<T> Add(T entity)
        {
            var result = await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<IEnumerable<T>> AddRange(IEnumerable<T> entities)
        {
            await  context.Set<T>().AddRangeAsync(entities);
            await context.SaveChangesAsync();
            return entities;
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression);
        }
        public PagedResult<T> GetAll([FromQuery] string? name , int page) 
        {
            int pageSize = 5;

            if (name != null)
            {
                return context.Set<T>()
                    .Where(p => p.Name.Contains(name))
                    .GetPaged(page, pageSize);
                    
                    
            }
            else
            {
                return context.Set<T>()
                    .GetPaged(page, pageSize);
            }
        }

        public async Task<T> GetById(int id)
        {
            var result = await context.Set<T>().FindAsync(id);
            return result;
        }
           
        public async Task Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            //return entity;
        }
        public async Task RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
            await context.SaveChangesAsync();
        }

        public async Task<T?> Update(T entity)
        {
            var result = context.Set<T>().Contains<T>(entity);
            if (result)
            {

                // Update existing entity
                context.Entry(result).CurrentValues.SetValues(entity);

                await context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Person not found");
            }
            return entity;
        }

    }
}