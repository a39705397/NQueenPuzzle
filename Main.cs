using System;
					
public class Program
{
	public static void Main()
	{		
		EightQueens.Test();
	}
	public static class EightQueens
    {
        //queens count
        static int _queens = 8;
        //queens index array
        static int[] _arr = new int[_queens];
        //solution count
        static int _count = 0;
      
        public static void Test()
        {
            EightQueens.Check(0);
        }

        /// <summary>
        /// put Queen        
        /// </summary>
        /// <param name="n"></param>
        private static void Check(int n)
        {
            if (n == _queens)
            {
                Print();
                return;
            }
            
            for (int i = 0; i < _queens; i++)
            {                
                _arr[n] = i;                
                if (Conflict(n))
                {                    
                    Check(n + 1);
                }                
            }
        }

        /// <summary>
        /// View Queen Conflict
        /// </summary>
        /// <param name="n">The n queen</param>
        /// <returns></returns>
        private static bool Conflict(int n)
        {

            for (int i = 0; i < n; i++)
            {
                //1._arr[i] == _arr[n] same row
                //2.Math.Abs(n - i) == Math.Abs(_arr[n] - _arr[i]) same diagonal                
                if (_arr[i] == _arr[n] || Math.Abs(n - i) == Math.Abs(_arr[n] - _arr[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Out Put Queen and empty
        /// </summary>
        private static void Print()
        {
            _count++;
				
            	for (int i = 0; i < _arr.Length; i++)
            	{					
					if(i% _queens==0)
						Console.WriteLine("//Solution" + _count);
					for(int j=0; j < _queens; j++)
					{
						if(j== _arr[i])
						{							
							System.Console.Write("Q");
						}
						else
						{
							Console.Write(".");
						}                		
					}
					Console.WriteLine();
					
            	}			
            System.Console.WriteLine();
        }
    }

}
