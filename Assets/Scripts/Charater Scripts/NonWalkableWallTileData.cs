using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonWalkableWallTileData : MonoBehaviour
{

    public float tileXPosition;
    public float tileZPosition;

    public bool isWalkable = false;

    // Start is called before the first frame update
    void Start()
    {
        tileXPosition = this.transform.position.x;
        tileZPosition = this.transform.position.z;
    }
}
