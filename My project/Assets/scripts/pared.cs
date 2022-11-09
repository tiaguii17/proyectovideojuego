
using UnityEngine;

public class pared : MonoBehaviour
{
    float timerToRespawn = 0;

    void Respawn()
    {
        var rndX = Random.Range(10, 20);
        var rndZ = Random.Range(10, 20);
        transform.position = new Vector3(rndX, 1.5f, rndZ);
        timerToRespawn = 0;
    }
    
    void OnCollisionStay(Collision col)
    {if (col.transform.gameObject.tag == "Player")
        {
            timerToRespawn += Time.deltaTime;
            Debug.Log("si");
        }
      if (timerToRespawn >= 2f)
        {
            Respawn();
        }
            
    }

}
