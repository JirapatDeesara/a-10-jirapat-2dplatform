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
    // ใส่ Private void Start ใน class ลูกทุกตัว
    private void Start()
    {
        Init(100);
        Debug.Log(Health);
        Behaviour();
    }
    public override void Behaviour()
    {
        Debug.Log("Crocodile.Behaviour");
    }// End Override
}// End Crocodile
