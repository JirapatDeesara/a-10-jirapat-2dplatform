using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy // แดงเพราะติด Abstract
{
    // -attackRange: float
    private float attackRange;
    // -player: Player
    private Player player;
    //แก้แดง
    public override void Behaviour()
    {
        Debug.Log("Crocodile.Behaviour");
    }// End Override
}// End Crocodile
