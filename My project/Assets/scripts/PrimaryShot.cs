
using UnityEngine;

public class PrimaryShot : MonoBehaviour
{
    public float speedOfTear;
    public float damage = 3.50f;

    void Update()
    {
        transform.Translate(Vector3.forward * speedOfTear * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.transform.gameObject)
        {
            Destroy(transform.gameObject);
        }
        
    }
    
}
