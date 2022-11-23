using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySht : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform spawnPoint;
    public Transform playerpos;
    public float contador = 0;
    void Update()
    {
        ShootPlayer();
    }

    void ShootPlayer()
    {
        float dist = Vector3.Distance(playerpos.position, transform.position);
  
        if (dist < 25)
        {
         contador += Time.deltaTime;
            if (contador >= 2)
            {
                Instantiate(enemyBullet, spawnPoint.position, transform.rotation);
               
               contador = 0;
            }
        }
    }
}
