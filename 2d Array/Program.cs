using System;

//[,] indicates that it is a 2d array. [] indidates array only
int[,] numberGrid = { 
    {1, 2},
    {3, 4},
    {5, 6}
};

int[,] myArray = new int[2,3];

Console.WriteLine(numberGrid[1, 1]); // 4

Console.ReadLine();
