using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
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
