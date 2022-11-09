
using UnityEngine;

public class jugador : MonoBehaviour
{
    public int velocidad = 2;

    public bool yaPasaste = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        Movimiento();
        
    }

    void Movimiento()
    {
        float movX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float movY = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(new Vector3(movX, 0, movY));
        
        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, -1.5f, 0);
        }
        if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0, 1.5f, 0);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.transform.gameObject.name == "portal")
        {
            if (yaPasaste == true)
            {
                transform.localScale += new Vector3(0.20f, 0.20f, 0.20f);
                yaPasaste = false;
            }
            else
            {
                transform.localScale += new Vector3(-0.20f, -0.20f, -0.20f);
                yaPasaste = true;

            }
        }
    }

}
