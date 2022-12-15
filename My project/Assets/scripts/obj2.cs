using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj2 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.transform.gameObject.name == "Player")
        {
            Destroy(transform.gameObject);
        }

    }
}
