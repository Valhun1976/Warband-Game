using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerHand owningPlayerHand;
    public float owningPlayerId;

    // Start is called before the first frame update
    void Start()
    {
        SetOwningPlayerId();
        owningPlayerHand = GetComponent<PlayerHand>();
        owningPlayerHand.owningPlayerId = owningPlayerId;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetOwningPlayerId()
    {

        owningPlayerId = Random.Range(1, Random.Range(1, 250000));

        Player[] players = GetComponents<Player>();

        foreach (Player player in players)
        {
            
            while (player.GetOwningPlayerId() == this.owningPlayerId && player != this) {

                owningPlayerId = Random.Range(1, Random.Range(1, 250000));

            }
        }
        
    }

    public float GetOwningPlayerId()
    {
        return owningPlayerId;
    }

}
