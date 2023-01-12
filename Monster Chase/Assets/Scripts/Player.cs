using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;

    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;
    private float movementY;

    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private const string WALK_ANIMATION = "Walk";

    private bool isGrounded;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }
     
    // Update is called once per frame
    private void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
    }

    // FixedUpdate is called at each timestep (Proj Settings > Time > Fixed Timestep)
    private void FixedUpdate()
    {
    }

    private void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
    }

    private void AnimatePlayer()
    {
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);   
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }    
}
