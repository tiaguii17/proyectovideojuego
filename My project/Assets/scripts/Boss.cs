
using UnityEngine;

public class Boss : EnemyOne
{
    
    void Update()
    {
        Perseguir();
        Look();
        Dead();
    }

   
}
