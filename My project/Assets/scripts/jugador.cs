using UnityEngine.SceneManagement;
using UnityEngine;

public class jugador : MonoBehaviour
{
    public static int life = 4;
    public static int velocidad = 10;
    public Camera fpsCam;
    public float horizontalSpeed;
    public float verticalSpeed;
    float rotX;
    float rotY;
    public GameObject Proyectil;
    public Transform Ojos;
    public float tears = 0;
    public static float damage = 3.50f;
    [SerializeField]
    private ObjDmg objDmg;
   
    void Update()
    {
        Movimiento();
        Disparar();
        Died();

        rotX += Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
        rotY += Input.GetAxis("Mouse Y") * verticalSpeed * Time.deltaTime;
        rotY = Mathf.Clamp(rotY, -90f, 90f);
        fpsCam.transform.localRotation = Quaternion.Euler(-rotY, 0f, 0f);
        transform.rotation = Quaternion.Euler(0f, rotX, 0f);
    }

    void Movimiento()
    {
        float movX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float movY = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(new Vector3(movX, 0, movY));
      
    }
    
   
    void Disparar()
    {
        if (tears <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(Proyectil, Ojos.position, Ojos.rotation);
                tears = 1;
                
            }


        }
        if(tears > 0)
        {
            tears -= Time.deltaTime;
        }
        
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.name == "ObjetoDeDaño")
        {
            damage = damage + objDmg.damage;
        }
        if (col.transform.gameObject.name == "ObjetoPotenciador")
        {
            damage = damage + 5f; ;
            velocidad = 15;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.gameObject.tag == "Enemy")
        {
            life--;
        }
    }
    void Died()
    {
        if(life == 0)
        {
            SceneManager.LoadScene(0);
            life = 4;
        }
    }

  
}
