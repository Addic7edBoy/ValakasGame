using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movementScript : MonoBehaviour
{
    public float speed = 5f;
    public bool IsGround;
    Rigidbody2D rig;
    Animator MyAnim;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        MyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move;
        move = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(move * speed, rig.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rig.AddForce(new Vector2(0, 400f));
        }
        MyAnim.SetBool("IsGround", IsGround);
        MyAnim.SetFloat("Speed", Mathf.Abs(rig.velocity.x));

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            IsGround = true;
        }
    }
}