
using UnityEngine;

public class EnemyTwo : EnemyOne
{
    
    void Update()
    {
        Perseguir();
        Look();
        Dead();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.gameObject.tag == "Proyectil")
        {
            EnemyLife = EnemyLife - jugador.damage;

        }
    }
}
