using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField]
    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }
    [field: SerializeField]
    Transform bulletSpawnPoint;
    public Transform SpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
    [field: SerializeField] public float WaitTime { get; set; }
    [field: SerializeField] public float ReloadTime { get; set; }
   
    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && WaitTime >= ReloadTime)
        {
            GameObject obj = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(10, this);
           
        }// Input = get keyboard/mouse input to click
    }

    void Start()
    {
        Init(100);
        healthBar.SetMaxHealth(100);
        WaitTime = 0.0f;
        ReloadTime = 1.0f;

        
    }

    void Update()
    {
        Shoot();
    }
    private void FixedUpdate()
    {
        
        WaitTime += Time.deltaTime;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
           
        }
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.DamageHit);
    }// End OnHitwith
}// End Player