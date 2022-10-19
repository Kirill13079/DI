using System;
using System.Collections.Generic;

namespace DI
{
    public interface IContainer
    {
        void Register<TInterface, TImplementation>();
        void Unregister();
        bool IsRegistered();
    }

    public class ContainerBuilder : IContainer
    {
        public readonly Dictionary<Type, Type> _types;

        public ContainerBuilder()
        {
            _types = new Dictionary<Type, Type>();
        }

        public void Register<TInterface, TImplementation>()
        {
            _types[typeof(TInterface)] = typeof(TImplementation);
        }

        public void Unregister()
        {

        }

        public bool IsRegistered()
        {
            return true;
        }
    }
}