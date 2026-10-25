using System.Collections;
using System.Collections.Generic;

namespace Aplikacja.Podstawy
{
    public class Math
    {
        public int Add(int a, int b) => a + b;

        public int Max(int a, int b) => a > b ? a : b;

        //metoda która zwraca liczby nieparzyste z zakresu od 1 do n
        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (int i = 1; i <= limit; i++)            
                if (i % 2 != 0)                
                    yield return i;
        }
    }
}
