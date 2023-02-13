using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    int speed = 10;
    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //using this playerController thing we can use variables from the player controller in other scripts
        player = GameObject.Find("Player").GetComponent<PlayerController>();


        if (player.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        resetPos();
    }

    void resetPos()
    {
        if (transform.position.x < -11)
        {
            transform.position = new Vector3(45, transform.position.y, transform.position.z);
        }
    }
}
