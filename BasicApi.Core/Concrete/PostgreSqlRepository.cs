using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicApi.Core.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Core.Concrete
{
    public class PostgreSqlRepository<T> : IRepository<T> where T : class
    {
        private readonly BasicApiContext _context;
        private DbSet<T> _entities;

        public PostgreSqlRepository(BasicApiContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public virtual async Task<T> GetById(object id)
        {
            return await Entities.FindAsync(id);
        }

        /// <summary>
        ///     Insert entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public async Task Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        ///     Insert entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task Insert(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                await Entities.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        ///     Update entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public async Task Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));


            Entities.Update(entity);

            await _context.SaveChangesAsync();
        }


        /// <summary>
        ///     Update entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task Update(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                Entities.Update(entity);

            await _context.SaveChangesAsync();
        }

        /// <summary>
        ///     Delete entity
        /// </summary>
        /// <param name="entity">Entity</param>
        public async Task Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            Entities.Remove(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        ///     Delete entities
        /// </summary>
        /// <param name="entities">Entities</param>
        public virtual async Task Delete(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
                Entities.Remove(entity);
            await _context.SaveChangesAsync();
        }



        /// <summary>
        ///     Gets a table
        /// </summary>
        public virtual IQueryable<T> Table => Entities;

        /// <summary>
        ///     Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only
        ///     operations
        /// </summary>
        public virtual IQueryable<T> TableNoTracking => Entities.AsNoTracking();

        /// <summary>
        ///     Entities
        /// </summary>
        protected virtual DbSet<T> Entities => _entities ?? (_entities = _context.Set<T>());
    }
}
