// See https://aka.ms/new-console-template for more information
using System;

class A
{
    static void Main()
    {
        int N = 8; 
        int[,] board = new int[N, N]; 

        
        int startX = 3; // for example
        int startY = 3; // for example

        
        board[startX, startY] = 1;

        
        Random random = new Random();

        while (true)
        {
            
            int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

            int numMoves = 0;

            
            for (int i = 0; i < 8; i++)
            {
                int newX = startX + dx[i];
                int newY = startY + dy[i];

                if (newX >= 0 && newX < N && newY >= 0 && newY < N && board[newX, newY] == 0)
                {
                    numMoves++;
                }
            }

            if (numMoves == 0)
                break;

            
            int moveIndex = random.Next(0, 8);

           
            startX += dx[moveIndex];
            startY += dy[moveIndex];

          
            board[startX, startY] = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
