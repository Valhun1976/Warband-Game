using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
    //int[,] tiles;
    Node[,] graph;

    public int mapSizeX = 34;
    public int mapSizeZ = 22;

    public GameObject selectedCharacter;

    private void Start()
    {
        GeneratePathfindingGraph();
    }

    class Node
    {
        public List<Node> neighbouringTiles;

        public Node()
        {
            neighbouringTiles = new List<Node>();
        }
    }

    
    void GeneratePathfindingGraph()
    {
        graph = new Node[mapSizeX, mapSizeZ];

        for (int x = 0; x < mapSizeX; x++)
        {
            for (int z = 0; z < mapSizeZ; z++)
            {
                if (x > 0)
                    graph[x, z].neighbouringTiles.Add(graph[x - 1, z]);
                if (x < mapSizeX - 1)
                    graph[x, z].neighbouringTiles.Add(graph[x + 1, z]);
                if (z > 0)
                    graph[x, z].neighbouringTiles.Add(graph[x, z - 1]);
                if (z < mapSizeZ - 1)
                    graph[x, z].neighbouringTiles.Add(graph[x, z + 1]);
            }
        }
    }

    public Vector3 TileCoordToWorldCoord(int x, int z)
    {
        return new Vector3(x, 0, z);
    }

    public void MoveSelectedCharacterTo(int x, int z)
    {
        selectedCharacter.GetComponent<CharacterPositionData>().tileX = x;
        selectedCharacter.GetComponent<CharacterPositionData>().tileZ = z;

        selectedCharacter.transform.position = TileCoordToWorldCoord(x, z);
    }
}
