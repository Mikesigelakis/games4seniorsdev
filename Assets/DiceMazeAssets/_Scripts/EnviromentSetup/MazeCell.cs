using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCell {
    public bool[] walls;
    public bool visited;

    public MazeCell () {
        walls = new bool[6] { true, true, true, true, false, true };
        visited = false;

    }
}