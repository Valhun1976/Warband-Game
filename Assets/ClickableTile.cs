using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableTile : MonoBehaviour
{
    GameObject go;
    TileMap map;

    WalkableTileData tileXZData;

    public int tileX;
    public int tileZ;

    // Start is called before the first frame update
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("DrowEnclaveMap");
        map = go.GetComponent<TileMap>();
        tileXZData = gameObject.GetComponentInParent<WalkableTileData>();
       
        tileX = tileXZData.tileXPosition;
        tileZ = tileXZData.tileZPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        Debug.Log("Click!!!");
        map.MoveSelectedCharacterTo(tileX, tileZ);
    }
}
