
using UnityEngine;

public class jugador : MonoBehaviour
{
    public int velocidad = 2;
    public Camera fpsCam;
    public float horizontalSpeed;
    public float verticalSpeed;
    public GameObject Proyectil;
    public Transform Ojos;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        Movimiento();
        Camara();
        Disparar();
    }

    void Movimiento()
    {
        float movX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float movY = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(new Vector3(movX, 0, movY));
      
    }
    void Camara()
    {
        float camMovX = Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
        float CamMovY = Input.GetAxis("Mouse Y") * verticalSpeed * Time.deltaTime;
        transform.Rotate(0, camMovX, 0);
        fpsCam.transform.Rotate(-CamMovY, 0, 0);
        
    }
   
    void Disparar()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Proyectil, Ojos.position, transform.rotation);
        }
    }
}
