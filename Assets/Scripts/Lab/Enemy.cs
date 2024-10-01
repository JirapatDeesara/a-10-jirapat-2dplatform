using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    // +DamageHit: int {get; set;}

    private int damageHit;
    public int DamageHit 
    {
        get 
        {
            return damageHit;
        }
        set
        { 
           damageHit = value;
        }
    }
    // �ѹ��������§�� Abstract + Behaviour:void

    private void Start()
    {
        Behaviour(); // ���¡����������� class ��� ������¡��˹����� Obj ���
    }// end Start ��� code �ѹ�ѹ
    public abstract void Behaviour();
    // Abstract ����� Body {} �����������Ƿ���׺�ʹ价��ͧ �� ���ӾԹ�¡�������١�ӵ�� ���������������� Rip
    // ��ҡ�Թ����ҧ��Ҵ��

} // End Enemy
