  using System;

public class CustomList<T>
{
    private T[] array;
    private int count;
    private int capacity;
    private const int initialCount = 4;

    public CustomList()
    {
        array = new T[initialCount];
        count = 0;
        capacity = initialCount;
    }

    public void GetAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public void Add(T item)
    {
        if (count == capacity)
        {
            Array.Resize(ref array, capacity == 0 ? initialCount : capacity * 2);
            capacity = array.Length;
        }
        array[count] = item;
        count++;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(array, item, 0, count);
        if (index >= 0)
        {
            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[count - 1] = default(T);
            count--;
            return true;
        }
        return false;
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < count; i++)
        {
            if (array[i].Equals(item))
            {
                return true;
            }
        }
        return false;
    }

    public bool Any()
    {
        if (count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Clear()
    {
        array = new T[initialCount];
        count = 0;
        capacity = initialCount;
    }

    public T FirstOrDefault()
    {
        if (count > 0)
        {
            return array[0];
        }
        else
        {
            return default(T);
        }
    }

    public T ElementAtOrDefault(int index)
    {
        if (index >= 0 && index < count)
        {
            return array[index];
        }
        else
        {
            return default(T);
        }
    }

    public T LastOrDefault()
    {
        if (count > 0)
        {
            return array[count - 1];
        }
        else
        {
            return default(T);
        }
    }
}

