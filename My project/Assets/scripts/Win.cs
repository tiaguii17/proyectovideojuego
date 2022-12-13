using UnityEngine.SceneManagement;
using UnityEngine;

public class Win : MonoBehaviour
{
   
    void OnCollisionEnter(Collision col)
    {
        if(col.transform.gameObject.name == "Player")
        {
       
            SceneManager.LoadScene(0);
        }
    }
}
