using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRb;
    private Animator playerAnimations;

    public int jumpForce;
    public int gravityModifier;

    bool isGrounded;
    int playerLives = 3;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnimations = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            playerAnimations.SetTrigger("Jump_trig");
        }
        if (playerLives == 0)
        {
            playerAnimations.SetBool("Death_b", true);
            playerAnimations.SetInteger("DeathType_int", 2);
            gameOver = true;
            
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
            playerLives -= 1;
            Debug.Log("-1 LIFE");
        }
    }

}
