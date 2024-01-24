using System.Collections;

namespace CustomCollection
{
    public class CustomCollection<T> : ICollection<T>
    {
        private T[] _arr;
        private int _size;
        private int _capacity;

        // Events
        public class ElementChangedEventArgs<T> : EventArgs
        {
            public T Element { get; }

            public ElementChangedEventArgs(T element)
            {
                Element = element;
            }
        }

        public event EventHandler<ElementChangedEventArgs<T>> ElementAdded;
        public event EventHandler<ElementChangedEventArgs<T>> ElementRemoved;

        protected virtual void OnElementAdded(ElementChangedEventArgs<T> e)
        {
            ElementAdded?.Invoke(this, e);
        }

        protected virtual void OnElementRemoved(ElementChangedEventArgs<T> e)
        {
            ElementRemoved?.Invoke(this, e);
        }

        // Constructors
        public CustomCollection()
        {
            _arr = new T[8];
            _size = 0;
            _capacity = 8;
        }

        public CustomCollection(T[] array)
        {
            _arr = array;
            _size = array.Length;
            _capacity = array.Length;
        }

        // Enumerator
        private class CustomCollectionEnumerator : IEnumerator<T>
        {
            private readonly CustomCollection<T> _collection;
            private int _index;

            public CustomCollectionEnumerator(CustomCollection<T> collection)
            {
                _collection = collection ?? throw new ArgumentNullException(nameof(collection));
                _index = -1;
            }

            public T Current => _collection._arr[_index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                _index++;
                return _index < _collection._size;
            }

            public void Reset()
            {
                _index = -1;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomCollectionEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // ICollection<T> methods
        public void Add(T item)
        {
            if (_size == _capacity)
            {
                T[] oldarray = _arr;
                _arr = new T[_size * 2];
                for (int i = 0; i < _size; ++i)
                {
                    _arr[i] = oldarray[i];
                }
                _arr[_size] = item;
                _capacity = _size * 2;
            }
            else
            {
                _arr[_size] = item;
            }

            ++_size;

            OnElementAdded(new ElementChangedEventArgs<T>(item));
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }

            int indexToRemove = -1;

            for (int i = 0; i < _size; i++)
            {
                if (_arr[i].Equals(item))
                {
                    indexToRemove = i;
                    break;
                }
            }

            for (int i = indexToRemove; i < _size - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }

            --_size;

            OnElementRemoved(new ElementChangedEventArgs<T>(item));

            return true;
        }

        public void Clear()
        {
            _size = 0;
            _capacity = 0;
        }

        public bool Contains(T item)
        {
            if (item != null)
            {
                for (int i = 0; i < _size; ++i)
                {
                    if (_arr[i].Equals(item))
                        return true;
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(item));
            }

            return false;
        }

        public int Count { get { return _size; } }

        public bool IsReadOnly {
            get 
            {
                return false; 
            } 
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(arrayIndex), "Index must be non-negative.");

            if (_size > array.Length - arrayIndex)
                throw new ArgumentException("Destination array is not long enough to copy all the items starting at the specified index.");

            for (int i = 0; i < _size; i++)
            {
                array[arrayIndex + i] = _arr[i];
            }
        }

        // Indexer
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                return _arr[index];
            }
            set
            {
                if (index < 0 || index > _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }

                _arr[index] = value;
            }
        }
    }
}
