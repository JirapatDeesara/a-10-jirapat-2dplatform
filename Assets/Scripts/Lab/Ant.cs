using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy // Ant แดงเพราะว่ามี Abstract 
{
    // ประกาศให้ใช้ override ทับ Abstract ในตัวลูก
    public override void Behaviour()
    {
        Debug.Log("Ant.Behaviour");
    }// end override Behaviour
}// End Ant
