using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy // Ant ᴧ��������� Abstract 
{
    // ��С������� override �Ѻ Abstract 㹵���١
    public override void Behaviour()
    {
        Debug.Log("Ant.Behaviour");
    }// end override Behaviour
}// End Ant
