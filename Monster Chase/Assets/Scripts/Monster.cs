using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called every fixed framerate frame
    private void FixedUpdate()
    {
        // enemies only moving to the left/right
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }
}
