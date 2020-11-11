using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCard : Character
{
    //float owningPlayerId;

    public GameObject cardCanvas;
    public GameObject go;
    public Text hpText;
    public string hp;
    //public string cardSetNumber;

    //public Sprite cardRaritySprite;
    //public Sprite cardSetSprite;
    //public Sprite characterAlignmentSprite;
    //public Sprite dungeonsAndDragonsLogo;

    //TODO: Add sprites for the card card rarities
    //public Sprite cardRaritySprite;

    //TODO: Add sprites for the different card sets
    //public Sprite cardSetSprite;

    //TODO: Add sprites for the card alignments
    //public Sprite cardAlignmentSprite;

    //TODO: add sprite for the Dungeons & Dragons logo with the copywrite date and (Wizards) name
    //public Sprite dungeonsAndDrgaonsLogo;


    //public string[] CardSetNumber = 
    //{
    //    "01/60", //Index 0
    //    "02/60", //Index 1
    //    "03/60", //Index 2
    //    "04/60", //Index 3
    //    "05/60", //Index 4
    //    "06/60", //Index 5
    //    "07/60", //Index 6
    //    "08/60", //Index 7
    //    "09/60", //Index 8
    //    "10/60", //Index 9
    //    "11/60", //Index 10
    //    "12/60", //Index 11
    //    "13/60", //Index 12
    //    "14/60", //Index 13
    //    "15/60", //Index 14
    //    "16/60", //Index 15
    //    "17/60", //Index 16
    //    "18/60", //Index 17
    //    "19/60", //Index 18
    //    "20/60", //Index 19
    //    "21/60", //Index 20
    //    "22/60", //Index 21
    //    "23/60", //Index 22
    //    "24/60", //Index 23
    //    "25/60", //Index 24
    //    "26/60", //Index 25
    //    "27/60", //Index 26
    //    "28/60", //Index 27
    //    "29/60", //Index 28
    //    "30/60", //Index 29
    //    "31/60", //Index 30
    //    "32/60", //Index 31
    //    "33/60", //Index 32
    //    "34/60", //Index 33
    //    "35/60", //Index 34
    //    "36/60", //Index 35
    //    "37/60", //Index 36
    //    "38/60", //Index 37
    //    "39/60", //Index 38
    //    "40/60", //Index 39
    //    "41/60", //Index 40
    //    "42/60", //Index 41
    //    "43/60", //Index 42
    //    "44/60", //Index 43
    //    "45/60", //Index 44
    //    "46/60", //Index 45
    //    "47/60", //Index 46
    //    "48/60", //Index 47
    //    "49/60", //Index 48
    //    "50/60", //Index 49
    //    "51/60", //Index 50
    //    "52/60", //Index 51
    //    "53/60", //Index 52
    //    "54/60", //Index 53
    //    "55/60", //Index 54
    //    "56/60", //Index 55
    //    "57/60", //Index 56
    //    "58/60", //Index 57
    //    "59/60", //Index 58
    //    "60/60"  //Index 59
    //};


    // Start is called before the first frame update
    void Start()
    {
        hitPoints = 20;
        cardCanvas = GameObject.FindGameObjectWithTag("Hp");
        hpText = cardCanvas.GetComponent<Text>();

        hpText.text = "HP" + "\n" + hitPoints.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: create a function to populate the cardSetSprite variable list


    //TODO: create a function to populate the cardAlignmentSprite variable list


    //TODO: create a function to populate the cardRaritySprite variable list

}
