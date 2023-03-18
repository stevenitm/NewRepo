namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        private int[,] _array;

        public TwoDimensions(int n, int m)
        {
            N = n;
            M = m;
            _array = new int[n,m];
        }

        public int N { get; }
        public int M { get; }

        public void Fill()
        {
            Fill(1, 20);
        }

        public void Fill(int minimun, int maximun)
        {
            var random = new Random();
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; )

                _array[i,j] = random.Next(minimun, maximun);
            }
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M;)
                    output = $"{_array[i,j]}\t";
            }
            return output;
        }

        public OneDimension ToOneDimension()
        {
            int _top = N * M;
            var onedimension = new OneDimension(_top);
            for (int i = 0; i<_top;i++)
            {
                for(int j = 0; j<_top;j++)
                onedimension.Add( _array[i,j]);
            }
            return onedimension;
        }
    }
}
