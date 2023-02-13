using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsticles;
    private PlayerController player;


    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("spawnObsticles", 3, Random.Range(2,5));

        player = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObsticles()
    {
        int randomObsticle = Random.Range(0, 3);
        GameObject currentObsticle = obsticles[randomObsticle];

        if (player.gameOver == false)
        {
            Instantiate(currentObsticle, new Vector3(currentObsticle.transform.position.x, 0, currentObsticle.transform.position.z), currentObsticle.transform.rotation);
        }
        
    }
}
