
using UnityEngine;

public class ObjDmg : MonoBehaviour
{
    
    public float damage = 3.50f;

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.gameObject.name == "Player")
        {
            Destroy(transform.gameObject);
        }
        
    }
}
