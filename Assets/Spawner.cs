using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Coal;
   
    private float startDelay;
    // Start is called before the first frame update
    void Start()
    {
        float spawnInterval = Random.Range(3, 5);
        InvokeRepeating("spawncoal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {


        

    }
    void spawncoal()
    {
        GameObject coal = Instantiate(Coal, transform.position, transform.rotation);
    }
}
