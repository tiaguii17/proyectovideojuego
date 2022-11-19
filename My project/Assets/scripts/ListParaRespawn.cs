using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListParaRespawn : MonoBehaviour
{
    public List<Transform> spawnpos = new List<Transform>();
    public GameObject[] posiciones;
    
    void Start()
    {
        transform.position = spawnpos[Random.Range(0, spawnpos.Count)].position;
        Debug.Log(posiciones[0]);
        Debug.Log(posiciones[1]);
        Debug.Log(posiciones[2]);
    }


}
