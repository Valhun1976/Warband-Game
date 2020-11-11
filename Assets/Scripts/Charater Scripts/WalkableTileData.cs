using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkableTileData : MonoBehaviour
{

    public int tileXPosition;
    public int tileZPosition;

    public bool isWalkable = true;

    // Start is called before the first frame update
    void Awake()
    {
        tileXPosition = (int)this.transform.position.x;
        tileZPosition = (int)this.transform.position.z;
    }
}
