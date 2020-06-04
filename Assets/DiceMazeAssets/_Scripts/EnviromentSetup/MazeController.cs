using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeController : MonoBehaviour
{

    public static int mazeSizeX = 1;
    public int mazeSizeY;
    public static int mazeSizeZ = 1;
    public GameObject hourGlassPrefab;
    public GameObject coinPrefab;
    public GameObject wallPrefab;
    public GameObject playerPrefab;
    public GameObject algorithmSolution;
    public GameObject objectOfSolution;
    public GameObject floorPrefab;
    public MazeGenerator3D maze;

    // Use this for initialization
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;

        maze = new MazeGenerator3D(mazeSizeX, mazeSizeY, mazeSizeZ);
        Vector3 initialValuesForPlayer = new Vector3();
        Vector3 valuesForSolutionOfAlgorithm = new Vector3();
        Vector3 positionOfObjectOfSolution = new Vector3();
        maze.generate();

        for (int x = 0; x < mazeSizeX; x++)
        {
            for (int y = 0; y < mazeSizeY; y++)
            {
                for (int z = 0; z < mazeSizeZ; z++)
                {

                    if (maze.cells[x, y, z].walls[4] == true)
                    {
                        GameObject wall = Instantiate(wallPrefab);
                        wall.transform.position = new Vector3(x * 2, y * 2 + 1, z * 2);
                        wall.transform.Rotate(90, 0, 0);
                        wall.tag = "Wall";
                        wall.name = "Floor";

                    }

                    if (maze.cells[x, y, z].walls[1] == true)
                    {
                        GameObject wall;

                        if ((x == y) && (y == z))
                        {
                            valuesForSolutionOfAlgorithm = new Vector3(-2+0.02f, -1, (z * 2)-0.09f);
                            positionOfObjectOfSolution = new Vector3(-2, -0, z * 2);
                        }
                        else if ((x + 1 != mazeSizeX) || (y + 1 != mazeSizeY) || ((z + 1 != mazeSizeZ)))
                        {
                            {
                                float randomValue = Random.value;
                                if (randomValue > 0.85 && Random.value < 0.95)
                                {
                                    InstantiateCoin(x, y + 0.5f, z);

                                }
                                else if (randomValue > 0.50 && randomValue < 0.53)
                                {
                                    InstantiateHourGlass(x, y + 0.5f, z);

                                }

                            }

                        }
                        wall = Instantiate(floorPrefab);
                        wall.transform.position = new Vector3(x * 2, y * 2 - 1, z * 2);
                        wall.transform.Rotate(90, 0, 0);
                        wall.tag = "Floor";
                        wall.name = "Floor";

                    }

                    if (maze.cells[x, y, z].walls[0] == true)
                    {

                        GameObject wall = Instantiate(wallPrefab);
                        wall.transform.position = new Vector3(x * 2 - 1, y * 2, z * 2);
                        wall.transform.Rotate(0, 90, 0);
                        wall.tag = "Wall";
                        if ((y == z) && x == 0)
                        {
                            wall.transform.gameObject.SetActive(false);
                            (wall.GetComponent(typeof(BoxCollider)) as Collider).enabled = false;
                        }
                        maze.cells[x, y, z].walls[0] = false;

                    }

                    if (maze.cells[x, y, z].walls[5] == true)
                    {
                        GameObject wall = Instantiate(wallPrefab);
                        wall.transform.position = new Vector3(x * 2 + 1, y * 2, z * 2);
                        wall.transform.Rotate(0, 90, 0);
                        wall.tag = "Wall";
                    }
                    if (maze.cells[x, y, z].walls[2] == true)
                    {
                        GameObject wall = Instantiate(wallPrefab);
                        wall.transform.position = new Vector3(x * 2, y * 2, z * 2 - 1);
                        wall.tag = "Wall";
                    }

                    if (maze.cells[x, y, z].walls[3] == true)
                    {
                        GameObject wall = Instantiate(wallPrefab);
                        wall.transform.position = new Vector3(x * 2, y * 2, z * 2 + 1);
                        wall.tag = "Wall";

                    }
                    if ((x + 1 == mazeSizeX) && (y + 1 == mazeSizeY) && ((z + 1 == mazeSizeZ)))
                    {
                        initialValuesForPlayer = new Vector3(x * 2, y * 2, z * 2);
                        GameObject player = Instantiate(playerPrefab);
                        player.transform.position = initialValuesForPlayer;
                    }

                }
            }

        }

        algorithmSolution = Instantiate(floorPrefab);
        algorithmSolution.transform.position = valuesForSolutionOfAlgorithm;
        algorithmSolution.transform.Rotate(90, 0,0);

        Instantiate(objectOfSolution, positionOfObjectOfSolution, Quaternion.identity);
        objectOfSolution.transform.Rotate(90,0,0);
        objectOfSolution.tag = "Solution";

    }



    private void InstantiateCoin(float x, float y, float z)
    {
        GameObject coin;
        coin = Instantiate(coinPrefab);
        coin.transform.position = new Vector3(x * 2, y * 2 - 1, z * 2);
        coin.transform.Rotate(90, 0, 0);
        coin.tag = "Coin";
        coin.name = "Coin";

    }
    private void InstantiateHourGlass(float x, float y, float z)
    {
        GameObject hourGlass;
        hourGlass = Instantiate(hourGlassPrefab);
        hourGlass.transform.position = new Vector3(x * 2, y * 2 - 1, z * 2);
        hourGlass.transform.Rotate(0, 0, 0);
        hourGlass.tag = "HourGlass";
        hourGlass.name = "HourGlass";

    }
}