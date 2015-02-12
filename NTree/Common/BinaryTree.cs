﻿using System;
using System.Collections;
using System.Collections.Generic;


namespace NTree.Common
{
    public abstract class BinaryTree<T> : ICollection<T> where T : IComparable
    {
        public abstract IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public abstract void Add(T item);
        public abstract void Clear();
        public abstract bool Contains(T item);
        public abstract void CopyTo(T[] array, int arrayIndex);
        public abstract bool Remove(T item);
        public abstract int Count { get; }
        public abstract bool IsReadOnly { get; }
    }
}