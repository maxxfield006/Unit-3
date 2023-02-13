using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticles : MonoBehaviour
{
    public float obsticleSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * obsticleSpeed);

        if (gameObject.transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }
}
