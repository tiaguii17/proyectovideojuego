
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    public Transform target;
    public float vel;
    public float EnemyLife = 15;
    public Animator anim;
    [SerializeField]
    private jugador jugador;


    void Update()
    {
        Perseguir();
        Look();
        Dead();
    }

    void Perseguir()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 25)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, vel * Time.deltaTime);
            anim.SetBool("Chase",true);
        }
    }

    void Look()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 25)
        {
            transform.LookAt(target);
        }
    }

    void Dead()
    {
        if(EnemyLife <= 0)
        {
            Destroy(transform.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.gameObject.tag == "Proyectil")
        {
            EnemyLife = EnemyLife - jugador.damage;
            
        }
    }
} 