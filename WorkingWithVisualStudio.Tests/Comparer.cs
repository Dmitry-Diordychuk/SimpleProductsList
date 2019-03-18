using System;
using System.Collections.Generic;

namespace WorkingWithVisualStudio.Tests
{
    public class Comparer
    {
        public static Comparer<U> Get<U>(Func<U, U, bool> func) //Лямбда-выражение для сравнения.
        {
            return new Comparer<U>(func);
        }
    }

    public class Comparer<T> : Comparer, IEqualityComparer<T>  //Для сравнения объектов, являющихся экземпляром специальных классов, понадобится метод Assert.Equal()
    {                                                          //который принимает аргумент реализующий интерфейс IEqualityComparer<T>
        private Func<T, T, bool> comparisonFunction;
        public Comparer(Func<T,T,bool> func)
        {
            comparisonFunction = func;
        }
        public bool Equals(T x, T y)
        {
            return comparisonFunction(x, y);
        }
        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }
    }
}
