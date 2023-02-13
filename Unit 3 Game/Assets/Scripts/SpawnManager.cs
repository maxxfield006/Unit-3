using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obsticles;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObsticles", 3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObsticles()
    {
        
        Instantiate(obsticles, new Vector3(obsticles.transform.position.x, 1, obsticles.transform.position.z), obsticles.transform.rotation);
    }
}
