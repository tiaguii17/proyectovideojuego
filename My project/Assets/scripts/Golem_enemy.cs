
using UnityEngine;

public class Golem_enemy : MonoBehaviour
{
    public Transform target;
    public float vel;
    public float EnemyLife = 15;
    public Animator anim;
    [SerializeField]
    private jugador jugador;
    protected float contador = 0;
    public bool IsDead = false;
 


    void Update()
    {
        Perseguir();
        Look();
        Dead();
       
    }

    public void Perseguir()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 25)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, vel * Time.deltaTime);
            anim.SetBool("Chase", true);
        }

        if (IsDead == true)
        {
            vel = 0;
        }
    }

    public void Look()
    {
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 25)
        {
            transform.LookAt(target);
        }
    }

    public void Dead()
    {
        if (EnemyLife <= 0)
        {
            IsDead = true;
            anim.SetBool("die", true);
            contador += Time.deltaTime;
            if (contador >= 4)
            {
                Destroy(transform.gameObject);
            }

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
