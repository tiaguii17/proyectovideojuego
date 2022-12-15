
using UnityEngine;

public class PrimaryShot : MonoBehaviour
{
    public float speedOfTear;
    private float contador;
      

    void Update()
    {
        transform.Translate(Vector3.forward * speedOfTear * Time.deltaTime);
        contador += Time.deltaTime;
        if(contador >= 2.2f)
        {
            Destroy(transform.gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.gameObject)
        {
            Destroy(transform.gameObject);
        }
        
    }


}
