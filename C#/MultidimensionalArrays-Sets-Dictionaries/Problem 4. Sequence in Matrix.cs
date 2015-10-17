using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = new int[2];
            size = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); 
            string[,] matrix = new string[size[0], size[1]];    
            for (int i = 0; i < size[0]; i++)                                 
            {                                                                 
                string[] temp = Console.ReadLine().Split(' ');                
                for (int k = 0; k < size[1]; k++)                             
                {
                    matrix[i, k] = temp[k];
                }
            }
            //
            int maxCount = 0;
            string bestString = string.Empty;
            for (int row = 0; row < size[0]; row++)
            {

                for (int col = 0; col < size[1]; col++)
                {
                    string temp = matrix[row, col];
                    int tempCount = 0;
                    //Check lines
                    for (int z = row; z < size[0]; z++)
                    {
                        if (temp == matrix[z, col])
                        {
                            tempCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        bestString = temp;
                    }
                    tempCount = 0;
                    //Check columns
                    for (int z = row; z < size[1]; z++)
                    {
                        if (temp == matrix[row, z])
                        {
                            tempCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        bestString = temp;
                    }
                    //Check diagonal
                    tempCount = 0;
                    int y = col;
                    for (int z = row; z < size[0] && y < size[1]; z++,y++)
                    {
                        if (temp == matrix[z, y])
                        {
                            tempCount++;
                        }
                        else
                        {
                            break;
                        }                        
                    }
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        bestString = temp;
                    }
                    tempCount = 0;
                    int w = col;
                    for (int z = row; z < size[0] && w > size[1]; z++,w--)
                    {
                        if (temp == matrix[z, w])
                        {
                            tempCount++;
                        }
                        else
                        {
                            break;
                        }                        
                    }
                    if (tempCount > maxCount)
                    {
                        maxCount = tempCount;
                        bestString = temp;
                    }
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                if (i != maxCount - 1)
                {
                    Console.Write(bestString + ", ");
                }
                else
                {
                    Console.WriteLine(bestString);
                }
            }
        }
    }
}
