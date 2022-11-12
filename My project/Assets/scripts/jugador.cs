
using UnityEngine;

public class jugador : MonoBehaviour
{
    public int velocidad = 2;
    public Camera fpsCam;
    public float horizontalSpeed;
    public float verticalSpeed;
    float rotX;
    float rotY;
    public GameObject Proyectil;
    public Transform Ojos;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        Movimiento();
        Disparar();

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
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Proyectil, Ojos.position, transform.rotation);
        }
    }
}
