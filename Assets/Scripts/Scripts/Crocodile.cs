using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Crocodile : Enemy, IShootable // á´§à¾ÃÒÐµÔ´ Abstract
{
    [field: SerializeField]
    float attackRange;
    public float AttackRange { get { return attackRange; } set { attackRange = value; } }
    // -player: Player
    [SerializeField] private Player player;
    //
    [field: SerializeField]
    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }
    [field: SerializeField]
    Transform bulletSpawnPoint;
    public Transform SpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
    [field: SerializeField] public float WaitTime { get; set; }
    [field: SerializeField] public float ReloadTime { get; set; }

    private void Awake()
    {
        WaitTime = 0.0f;
        ReloadTime = 6.0f;
        DamageHit = 30;
        AttackRange = 6;
    }

    private void Start()
    {
        Init(100);
        healthBar.SetMaxHealth(100);
        player = GameObject.FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        //  Cooldown
        WaitTime += Time.fixedDeltaTime;
        Behaviour();

    }// End Crocodile FixedUpdate
    public override void Behaviour()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        //Attack range (distance < attackRange)
        {
            Shoot();
        }
    }// End Override
    public void Shoot()
    {
        if (WaitTime >= ReloadTime)
        {
            animator.SetTrigger("Shoot");
            //bullet = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            GameObject obj = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            Rock rockScript = obj.GetComponent<Rock>();
            rockScript.Init(20, this);

            WaitTime = 0;
        } // End if bulletTimer

    }
}// End Crocodile