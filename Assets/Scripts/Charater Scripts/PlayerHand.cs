using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public float owningPlayerId;

    public List<GameObject> warband;

    // Start is called before the first frame update
    void Start()
    {
        warband = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
