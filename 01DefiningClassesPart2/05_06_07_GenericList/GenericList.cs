using System;

public class GenericList<T>
    where T : IComparable
{
    private T[] array;
    private int index;

    public GenericList(int size)
    {
        array = new T[size];
        this.index = 0;
    }
    public void Add(T element)
    {
        if (this.index == this.array.Length - 1)
        {
            Expand();
        }
        array[index] = element;
        this.index++;
    }
    public T this[int position]
    {
        get
        {
            return this.array[position];
        }
        set
        {
            this.array[position] = value;
        }
    }
    public void RemoveAt(int position)
    {
        if (position < 0 || position > index)
        {
            Console.WriteLine("Doesn't exist !");
        }
        else
        {
            T[] result = new T[this.array.Length - 1];
            this.index--;
            Array.Copy(this.array, 0, result, 0, position);
            Array.Copy(this.array, position + 1, result, 0, this.array.Length - 1 - position);
            this.array = result;
        }
    }
    public void InsertAt(T element, int position)
    {
        if (position == this.array.Length - 1)
        {
            Expand();
        }

        T[] result = new T[this.array.Length + 1];
        this.index++;
        Array.Copy(this.array, 0, result, 0, position);
        result[position] = element;
        Array.Copy(this.array, position, result, position + 1, this.array.Length - position);
        this.array = result;
    }
    public void Clear()
    {
        int sizeTemp = this.array.Length;
        array = new T[sizeTemp];
        index = 0;
    }
    public int Find(T element)
    {
        return Array.IndexOf(this.array, element);
    }
    public override string ToString()
    {
        string result = String.Empty;
        for (int i = 0; i < this.index; i++)
        {
            result += this.array[i] + " ";
        }
        return result;
    }

    public void Expand()
    {
        T[] result = new T[this.array.Length * 2];
        Array.Copy(this.array, result, this.array.Length);
        this.array = result;
    }
    public T Min()
    {
        T min = this.array[0];
        for (int i = 0; i < index; i++)
        {
            if (min.CompareTo(this.array[i]) > 0)
            {
                min = this.array[i];
            }
        }

        return min;
    }
    public T Max()
    {
        T max = this.array[0];
        for (int i = 0; i < index; i++)
        {
            if (max.CompareTo(this.array[i]) < 0)
            {
                max = this.array[i];
            }
        }

        return max;
    }
}

public class Test
{
    static void Main()
    {
        GenericList<int> array = new GenericList<int>(5);
        array.Add(1);
        array.InsertAt(2, 1);
        array.RemoveAt(1);
        array.Add(10);
        Console.WriteLine(array.ToString());
        Console.WriteLine(array.Min());
        Console.WriteLine(array.Max());
        Console.WriteLine();
        array.Add(10);
        array.Add(10);
        array.Add(10);
        array.Add(10);
        array.Add(10);
        Console.WriteLine(array.ToString());
    }
}