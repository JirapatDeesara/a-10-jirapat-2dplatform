using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour   // Class Weapon ?? Abstract
{
    // +Damage : int {get; set;}
    [SerializeField] private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    public void Hitdamage(int newDamage)
    {
        Damage = newDamage;
    } // End Health constructor
    // #owner: IShootable
    protected string owner;
    // Method
    // + OnHitWith (Character):void [abstract]
    public abstract void OnHitWith(Character W);
    // End OnHitWith Method on Weapon

    // + Move(): void [Abstracted]
    public abstract void Move();


    // GetShootDirection():int
    public int GetShootDirection()
    {
        return 1;
    }// End GetShootDirection method


}// End Class Weapon