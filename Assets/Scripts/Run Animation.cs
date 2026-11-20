using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Vector2 startPos;
    private Animator playerAnimator;
    private Rigidbody2D rigidbody2D;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        
        playerAnimator.SetBool("Run", false);
        
        rigidbody2D = GetComponent<Rigidbody2D>();
        
        startPos = gameObject.transform.position;
    }
    
    void Update()
    {
        if (rigidbody2D.linearVelocityX >0|| rigidbody2D.linearVelocityX <0)
        {
            playerAnimator.SetBool("Run", true);
        }
        else
        { 
            playerAnimator.SetBool("Run", false);
        }
    }
    public void ResetOnDeezSpawn()
    {
        gameObject.transform.position = startPos;
    }
}