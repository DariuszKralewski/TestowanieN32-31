using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class Stack<T>
    {
        private readonly List<T> _list = new List<T>(); // Lista do przechowywania elementów stosu
        public int Count => _list.Count; // Właściwość zwracająca liczbę elementów na stosie

        public void Push(T item)
        {
            if(item == null)
                throw new ArgumentNullException(nameof(item), "Nie można dodać null do stosu.");

            _list.Add(item); // Dodaje element na szczyt stosu
        }

        public T Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stos jest pusty. Nie można usunąć elementu.");

            T item = _list[_list.Count - 1]; // Pobiera element ze szczytu stosu
            _list.RemoveAt(_list.Count - 1); // Usuwa element ze szczytu stosu
            return item; // Zwraca pobrany element
        }

        public T Peek()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stos jest pusty. Nie można podejrzeć elementu.");

            return _list[_list.Count - 1]; // Zwraca element ze szczytu stosu bez usuwania go
        }

    }
}
