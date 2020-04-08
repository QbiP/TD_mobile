using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float upforce = 2;
    [SerializeField] private float forwardforce = 5;
    [SerializeField] private Transform projectilespawn;
    [SerializeField] private Rigidbody bullet1;
    [SerializeField] private Rigidbody bullet2;


    void Update()
    {


        if (Input.GetKeyUp(KeyCode.G)) //&& Ammo >= 1)
        {
            SpawnProjectile1();
        }
        if (Input.GetKeyUp(KeyCode.A)) //&& Ammo >= 1)
        {
            SpawnProjectile2();
        }
    }


    private void SpawnProjectile1()
    {
     //--Ammo;
     Rigidbody Bullet1 = Instantiate(bullet1, projectilespawn.position, projectilespawn.rotation) as Rigidbody;
     Bullet1.velocity =  projectilespawn.forward * (forwardforce*2); //
    }

    private void SpawnProjectile2()
    {
        //--Ammo;
        Rigidbody Bullet2 = Instantiate(bullet2, projectilespawn.position, projectilespawn.rotation) as Rigidbody;
        Bullet2.velocity = upforce * projectilespawn.up / 1.5f + projectilespawn.forward * forwardforce; //
    }

}