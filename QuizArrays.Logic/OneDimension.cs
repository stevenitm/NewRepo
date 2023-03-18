
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private int [] _array;
        private int _top;

        public OneDimension(int n)
        {
            N = n;
           _array = new int[n];
           _top = 0;   
        }

        private bool IsEmpty =>  N == 0;
        private bool IsFull =>  _top == N;
        public int N { get;} 

        public void Add(int num)
        {
            if(IsFull)
            {
                throw new Exception("El array esta lleno");  
            }
            _array[_top] = num;
            _top++;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < _top; i++)
            {
                  output = $"{_array[i]}\t";
            }
            return output;    
        }

    }
}
