using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Xunit;

namespace CleanCode.AgilePractices.SOLID.DIP
{

    public class OrderTests
    {
        [Fact]
        public void Test()
        {
            //Context setup
            //Config serviceLocator
            //ServiceLocator.Register(resolver);
            OrderService orderService = new OrderService();

            
        }    
    }

    public class OrderService
    {
        private IOrderRepository _orderRepository ;

        public OrderService()
        {
            _orderRepository = ServiceLocator.Resolve<IOrderRepository>();
        }
    }

    public class ServiceLocator
    {
        private static IResolver _resolver;
        public static void SetResolver(IResolver resolver)
        {
            _resolver = resolver;
        }
        public static T Resolve<T>()
        {
            return _resolver.Resolve<T>();
        }
    }

    public interface IResolver
    {
        T Resolve<T>();
    }

    public interface IOrderRepository
    {
    }

    class OrderRepository : IOrderRepository
    {
    }
}