using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticles : MonoBehaviour
{
    float obsticleSpeed ;

    private PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        obsticleSpeed = Random.Range(10, 20);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * obsticleSpeed);
        }
        
        if (gameObject.transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }
}
