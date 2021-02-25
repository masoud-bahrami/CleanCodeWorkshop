using System;
using System.Collections.Generic;

namespace MetroApp.Bridge
{
     public interface IResolver
    {
        object Resolve(Type type);
        T Resolve<T>();
        IEnumerable<T> ResolveAll<T>();
    }

    public class Resolver : IResolver
    {
        private readonly IContainer _container;

        public Resolver(IContainer container)
        {
            this._container = container;
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _container.ResolveAll<T>();
        }
    }

    public interface IContainer : IResolver
    {
        void RegisterSingleTone<T, TImpl>();
        void RegisterTransient<T, TImpl>();
        void RegisterScoped<T, TImpl>();
        void Build();
    }

    public class ServiceCollectionContainer : IContainer
    {
        
        public object Resolve(Type type)
        {
            throw new NotImplementedException();
        }

        public T Resolve<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            throw new NotImplementedException();
        }

        public void RegisterSingleTone<T, TImpl>()
        {
            throw new NotImplementedException();
        }

        public void RegisterTransient<T, TImpl>()
        {
            throw new NotImplementedException();
        }

        public void RegisterScoped<T, TImpl>()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }
    }
    public class AutoFacContainer : IContainer
    {
        public object Resolve(Type type)
        {
            throw new NotImplementedException();
        }

        public T Resolve<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            throw new NotImplementedException();
        }

        public void RegisterSingleTone<T, TImpl>()
        {
            throw new NotImplementedException();
        }

        public void RegisterTransient<T, TImpl>()
        {
            throw new NotImplementedException();
        }

        public void RegisterScoped<T, TImpl>()
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }
    }
}