using System;
using Api.Controllers;
namespace ApiXUnit.Model
{
    public class GenericFixtrue<T> : IDisposable where T :class,IDisposable ,new()
    {
        public T Sut { get; private set; } 

        public GenericFixtrue()
        {
            Sut = new T();
            
        }

        public void Dispose()
        {
            // Sut.Dispose();
       
        }
    }
}