using Domain.Interfaces.Generics;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Generics
{
    public class RepositoryGenerics<T> : IGeneric<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;
        public RepositoryGenerics()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task Add(T Object)
        {
            using (var db = new ContextBase(_optionsBuilder))
            {
                await db.Set<T>().AddAsync(Object);
                await db.SaveChangesAsync();
            }
        }

        public async Task Update(T Object)
        {
            using (var db = new ContextBase(_optionsBuilder))
            {
                db.Set<T>().Update(Object);
                await db.SaveChangesAsync();
            }
        }

        public async Task Delete(T Object)
        {
            using (var db = new ContextBase(_optionsBuilder))
            {
                db.Set<T>().Remove(Object);
                await db.SaveChangesAsync();
            }

        }

        public async Task<T> GetEntityById(Guid id)
        {
            using (var db = new ContextBase(_optionsBuilder))
            {
                return await db.Set<T>().FindAsync(id);
            }
        }

        public async Task<List<T>> List()
        {
            using (var db = new ContextBase(_optionsBuilder))
            {
                return await db.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposed = true;
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~RepositoryGenerics()
        // {
        //     // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza no método 'Dispose(bool disposing)'
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
