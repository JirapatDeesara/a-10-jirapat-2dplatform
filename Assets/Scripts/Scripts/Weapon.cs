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
    public IShootable shooter;
    public void Hitdamage(int newDamage)
    {
        Damage = newDamage;
    } // End Health constructor
    // #owner: IShootable
    protected string owner;
    // Method
    // + OnHitWith (Character):void [abstract]
    public abstract void OnHitWith(Character character);
    // End OnHitWith Method on Weapon

    // + Move(): void [Abstracted]
    public abstract void Move();
    // Constructor
    public void Init(int newDamage, IShootable newOwner)
    {
        Damage = newDamage;
        shooter = newOwner;
    }

    // GetShootDirection():int
    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 5f);
    }// End OnTrigger
    public int GetShootDirection()
    {
       float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0)       
            return 1;  // Shoot right
        else return -1;  // Shoot left
    }// End GetShootDirection method




}// End Class Weapon