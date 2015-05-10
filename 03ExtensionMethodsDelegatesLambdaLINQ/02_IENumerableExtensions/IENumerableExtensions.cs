using System;
using System.Collections.Generic;
using System.Linq;

public static class IENumerableExtensions<T>
{
    public static T Sum<T>(this IEnumerable<T> elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException();
        }

        T sum = default(T);
        foreach (var item in elements)
        {
            sum += (dynamic)item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException();
        }

        T product = (dynamic)1;
        foreach (var item in elements)
        {
            product *= (dynamic)item;
        }

        return product;
    }

    public static T Average<T>(this IEnumerable<T> elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException();
        }

        T sum = default(T);
        int elementsCount = 0;
        foreach (var item in elements)
        {
            elementsCount++;
            sum += (dynamic)item;
        }
        T average = (dynamic)sum / elementsCount;

        return average;
    }

    public static T Min<T>(this IEnumerable<T> elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException();
        }

        T min = elements.First();
        foreach (var item in elements)
        {
            if ((dynamic)item < min)
            {
                min = item;
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> elements)
    {
        if (elements == null)
        {
            throw new ArgumentNullException();
        }

        T max = elements.First();
        foreach (var item in elements)
        {
            if ((dynamic)item > max)
            {
                max = item;
            }
        }

        return max;
    }
}