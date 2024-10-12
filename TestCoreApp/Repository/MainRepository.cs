using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TestCoreApp.Data;
using TestCoreApp.Models;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Repository
{
    public class MainRepository<T> : IRepository<T> where T : class
    {
        public MainRepository(AppDbContext context) 
        {
            this.context = context;
        }

        protected AppDbContext context { get; set; }

        public IEnumerable<T> FindAll()
        {
			return context.Set<T>().ToList();
        }

		public T SelectOne(Expression<Func<T, bool>> match)
		{
			return context.Set<T>().SingleOrDefault(match);
		}

		public T FindById(int id)
        {
            return context.Set<T>().Find(id);
        }

		public async Task<T> FindByIdAsync(int id)
		{
			return await context.Set<T>().FindAsync(id);
		}

		public async Task<IEnumerable<T>> FindAllAsync()
		{
			return await context.Set<T>().ToListAsync();
		}

		public IEnumerable<T> FindAll(params string[] eagers)
		{
			IQueryable<T> query = context.Set<T>();
			if (eagers.Length > 0)
			{
				foreach(var eager in eagers)
				{
					query = query.Include(eager);
				}
			}

			return query.ToList();
		}

		public async Task<IEnumerable<T>> FindAllAsync(params string[] eagers)
		{
			IQueryable<T> query = context.Set<T>();
			if (eagers.Length > 0)
			{
				foreach (var eager in eagers)
				{
					query = query.Include(eager);
				}
			}
			return await query.ToListAsync();
		}

		//=======================================================================//

		public void AddOne(T myItem)
		{
			context.Set<T>().Add(myItem);
			context.SaveChanges();
		}

		public void UpdateOne(T myItem)
		{
			context.Set<T>().Update(myItem);
			context.SaveChanges();
		}

		public void DeleteOne(T myItem)
		{
			context.Set<T>().Remove(myItem);
			context.SaveChanges();
		}

		public void AddList(IEnumerable<T> myList)
		{
			context.Set<T>().AddRange(myList);
			context.SaveChanges();
		}

		public void UpdateList(IEnumerable<T> myList)
		{
			context.Set<T>().UpdateRange(myList);
			context.SaveChanges();
		}

		public void DeleteList(IEnumerable<T> myList)
		{
			context.Set<T>().RemoveRange(myList);
			context.SaveChanges();
		}
	}
}
