using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //TODO: create a function to get the owning player's ID number
    public float owningPlayerId;

    //TODO: create a function to generate a random Id number for the character and check that it is a unique number
    public float characterIdNumber;

    public bool playerOwns;

    //Character Data
    public string cardSetNumber;
    public string characterName;
    public string characterAlignnment;
    public string creatureType;
    public List<string> creatureSubTypes;
    public string characterSize;
    public List<string> specialAbilities;

    public int movementType;
    public int level;
    public int cardPointValue;
    public int hitPoints;
    public int armorClass;
    public int movementAmount;
    public int numberOfAttacks;
    public int numberOfRangedAttacks;
    public List<int> MeleeAttackValues;
    public List<int> RangedAttackValues;

    public bool attackOfOpportunity;
    public bool hasActivated;
    public bool Morale;
    public bool UnderCommand;


    public string[] CardSetNumber =
    {
        "01/60", //Index 0
        "02/60", //Index 1
        "03/60", //Index 2
        "04/60", //Index 3
        "05/60", //Index 4
        "06/60", //Index 5
        "07/60", //Index 6
        "08/60", //Index 7
        "09/60", //Index 8
        "10/60", //Index 9
        "11/60", //Index 10
        "12/60", //Index 11
        "13/60", //Index 12
        "14/60", //Index 13
        "15/60", //Index 14
        "16/60", //Index 15
        "17/60", //Index 16
        "18/60", //Index 17
        "19/60", //Index 18
        "20/60", //Index 19
        "21/60", //Index 20
        "22/60", //Index 21
        "23/60", //Index 22
        "24/60", //Index 23
        "25/60", //Index 24
        "26/60", //Index 25
        "27/60", //Index 26
        "28/60", //Index 27
        "29/60", //Index 28
        "30/60", //Index 29
        "31/60", //Index 30
        "32/60", //Index 31
        "33/60", //Index 32
        "34/60", //Index 33
        "35/60", //Index 34
        "36/60", //Index 35
        "37/60", //Index 36
        "38/60", //Index 37
        "39/60", //Index 38
        "40/60", //Index 39
        "41/60", //Index 40
        "42/60", //Index 41
        "43/60", //Index 42
        "44/60", //Index 43
        "45/60", //Index 44
        "46/60", //Index 45
        "47/60", //Index 46
        "48/60", //Index 47
        "49/60", //Index 48
        "50/60", //Index 49
        "51/60", //Index 50
        "52/60", //Index 51
        "53/60", //Index 52
        "54/60", //Index 53
        "55/60", //Index 54
        "56/60", //Index 55
        "57/60", //Index 56
        "58/60", //Index 57
        "59/60", //Index 58
        "60/60"  //Index 59
    };

    public string[] CharacterAlignment = {
        "Lawful_Good", //Index 0
        "Neutral_Good", //Index 1
        "Chaotic_Good", //Index 2
        "Lawful_Neutral", //Index 3
        "Neutral", //Index 4
        "Chaotic_Neutral", //Index 5
        "Lawful_Evil", //Index 6
        "Neutral_Evil", //Index 7
        "Chaotic_Evil", //Index 8
        "Any" //Index 9
    };

    public string[] CharacterSize =
    {
        "Small", //index 0
        "Medium", //index 1
        "Large", //index 2
        "Huge" //index 3
    };

    public string[] CreatureType = 
        {
        "Aberration", //Index 0
        "Animal", //Index 1
        "Celestial", //Index 2
        "Construct", //Index 3
        "Dragon", //Index 4 
        "Elemental", //Index 5
        "Fey", //Index 6 
        "Fiend", //Index 7
        "Giant", //Index 8 
        "Humanoid", //Index 9 
        "Magical_Beast", //Index 10 
        "Monstrous_Humanoid", //Index 11
        "Ooze", //Index 12
        "Outsider", //Index 13
        "Plant", //Index 14
        "Undead", //Index 15
        "Vermin" //Index 16
    };

    public string[] CreatureSubTypes = 
    {
        "Air", //Index 0
        "Angel", //Index 1
        "Aquatic", //Index 2
        "Archon", //Index 3
        "Augmented", //Index 4
        "Chaotic", //Index 5
        "Cold", //Index 6
        "Demon", //Index 7
        "Devil", //Index 8
        "Dwarf", //Index 9
        "Earth", //Index 10
        "Elf", //Index 11
        "Evil", //Index 12
        "Extraplanar", //Index 13
        "Fire", //Index 14
        "Gnoll", //Index 15
        "Gnome", //Index 16
        "Goblinoid", //Index 17
        "Good", //Index 18
        "Halfling", //Index 19
        "Human", //Index 20
        "Incorporeal", //Index 21
        "Lawful", //Index 22
        "Native", //Index 23
        "Orc", //Index 24
        "Psionic", //Index 25
        "Reptilian", //Index 26
        "Shapechanger", //Index 27
        "Swarm", //Index 28
        "Water" //Index 29
    };

    public string[] MoveType = {
        "Standard", //Index 0
        "Flight", //Index 1
        "Burrow" //Index 2
    };


    public string[] SpecialAbilities = 
    {
        "Any", //Index 0
        "Any Warband", //Index 1
        "Beastmaster", //Index 2
        "Blind Fight", //Index 3
        "Blindsight", //Index 4
        "Breathweapon", //Index 5
        "Burrow", //Index 6
        "Charge", //Index 7
        "Cleave", //Index 8
        "Commader", //Index 9
        "Conceal", //Index 10
        "Consititution Drain", //Index 11
        "Countersong", //Index 12
        "Cowardly", //Index 13
        "Death Attack", //Index 14
        "Death Burst", //Index 15
        "Death Strike", //Index 16
        "Deflect Arrows", //Index 17
        "Difficult", //Index 18
        "DR", //Index 19
        "Dual Activation", //Index 20
        "Fearless",//Index 21
        "Feed", //Index 22
        "Flight", //Index 23
        "Follower", //Index 24
        "Frightened", //Index 25
        "Gaze Attack", //Index 26
        "Heal", //Index 27
        "Helpless", //Index 28
        "Hide", //Index 29
        "Hurling Charge", //Index 30
        "Immediate Action", //Index 31
        "Immune Effect", //Index 32
        "Improved Countersong", //Index 33
        "Incited", //Index 34
        "Inhibited", //Index 35
        "Incorporeal", //Index 36
        "Independent", //Index 37
        "Invisible", //Index 38
        "Leap", //Index 39
        "Level Drain",  //Index 40
        "Melee Reach", //Index 41
        "Melee Sneak Attack", //Index 42
        "Minions", //Index 43
        "Mobility", //Index 44
        "Not Subject to Commader Effects", //Index 45
        "Phalnx Fighting", //Index 46
        "Phase Out", //Index 47
        "Poisonous", //Index 48
        "Pounce", //Index 49
        "Powerful Charge", //Index 50
        "Precise Shot", //Index 51
        "Psionics", //Index 52
        "Push", //Index 53
        "Pull", //Index 54
        "Pushback", //Index 55
        "Range", //Index 56
        "Range Sneak Attack", //Index 57
        "Relay Orders", //Index 58
        "Rend", //Index 59
        "Replace", //Index 60
        "Requires Creature", //Index 61
        "Resist Energy", //Index 62
        "Reroll", //Index 63
        "Scout", //Index 64
        "Self", //Index 65
        "Sidestep", //Index 66
        "Sight", //Index 67
        "Slide", //Index 68
        "Slow Effect", //Index 69
        "Slow Melee Attack", //Index 70
        "Slow Ranged Attack", //Index 71
        "Smite Creature", //Index 72
        "Spell Resistance", //Index 73
        "Spell Resistance All", //Index 74
        "Spring Attack", //Index 75
        "Squeezing", //Index 76
        "Stacking", //Index 77
        "Stagger", //Index 78
        "Stench", //Index 79
        "Stunned", //Index 80
        "Stunning Attack", //Index 81
        "Summon", //Index 82
        "Summoned", //Index 83
        "Swift Action", //Index 84
        "Tiny Reach", //Index 85
        "Touch", //Index 86
        "Trample", //Index 87
        "Turn Undead", //Index 88
        "Tyrannical Morale", //Index 89
        "Uncanny Dodge", //Index 90
        "Unique", //Index 91
        "Vulnerable Energy", //Index 92
        "Wandering Monster", //Index 93
        "Whirlwind Attack", //Index 94
        "Wild" //Index 95
    };


    protected virtual void AttackOfOpportunity()
    {
        return;
    }

    protected virtual void MeleeAttack()
    {
        return;
    }

}
