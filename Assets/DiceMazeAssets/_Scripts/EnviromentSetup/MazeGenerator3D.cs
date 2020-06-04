using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazePosition
{
    public int x, y, z;
    public MazePosition(int posX, int posY, int posZ)
    {
        x = posX;
        y = posY;
        z = posZ;
    }
}

public class MazeGenerator3D {
    private int sizeX;
    private int sizeY;
    private int sizeZ;

    public MazeCell[,,] cells;
    private MazePosition[] stack;

    private int positionInStack;

    public MazeGenerator3D (int size_X, int size_Y, int size_Z)
    {
        sizeX = size_X;
        sizeY = size_Y;
        sizeZ = size_Z;

        cells = new MazeCell[sizeX, sizeY, sizeZ];

     
        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                for (int z = 0; z < sizeZ; z++)
                {
                    cells[x, y, z] = new MazeCell();
                }
            }
        }

   
        stack = new MazePosition[sizeX * sizeY * sizeZ];

       
        int startX = Random.Range(0, sizeX);
        int startY = Random.Range(0, sizeY);
        int startZ = Random.Range(0, sizeZ);
        stack[0] = new MazePosition(startX, startY, startZ);
        positionInStack = 0;
 
        cells[startX, startY, startZ].visited = true;
    }

    private int[] checkNeighbours(MazePosition currentPosition)
    {
        List<int> result = new List<int>();

        int x = currentPosition.x;
        int y = currentPosition.y;
        int z = currentPosition.z;

        
        if (x - 1 >= 0)  
        {
            if (cells[x - 1, y, z].visited == false) result.Add(0); 
        }
 
        if (x + 1 < sizeX) 
        {
            if (cells[x + 1, y, z].visited == false) result.Add(5);  
        }


        
        if (y - 1 >= 0) 
        {
            if (cells[x, y - 1, z].visited == false) result.Add(1);  
        }

 
        if (y + 1 < sizeY)  
        {
            if (cells[x, y + 1, z].visited == false) result.Add(4);  
        }


        
        if (z - 1 >= 0)  
        {
            if (cells[x, y, z - 1].visited == false) result.Add(2);  
        }

     
        if (z + 1 < sizeZ)  
        {
            if (cells[x, y, z + 1].visited == false) result.Add(3);
        }

        return result.ToArray();
    }

    public void generate()
    {
       
        while (positionInStack >= 0)
        {
         
            int x = stack[positionInStack].x;
            int y = stack[positionInStack].y;
            int z = stack[positionInStack].z;

         
            int[] possibleNeighbours = checkNeighbours(stack[positionInStack]);

            if (possibleNeighbours.Length > 0)   
            {
              
                int wall = possibleNeighbours[Random.Range(0, possibleNeighbours.Length)];

  
                cells[x, y, z].walls[wall] = false;

               
                if (wall == 0) x--;
                else if (wall == 5) x++;
                else if (wall == 1) y--;
                else if (wall == 4) y++;
                else if (wall == 2) z--;
                else if (wall == 3) z++;

            
                positionInStack++;
                stack[positionInStack] = new MazePosition(x, y, z);
                cells[x, y, z].visited = true;
                cells[x, y, z].walls[5-wall] = false;
            }

            else   
            {
              
                positionInStack--;
                
            }
        }
    }
}
