
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    public Transform target;
    public float vel;
    void Update()
    {
        Perseguir();
        Look();
    }

    void Perseguir()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 25)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, vel * Time.deltaTime);
        }
    }

    void Look()
    {
        transform.LookAt(target);
    }
}