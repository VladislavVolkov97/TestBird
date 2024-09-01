using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

   public Rigidbody2D rigidbody;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // animator.SetBool("Fly", false);
        if (Input.GetKey(KeyCode.Space) )
        {
            animator.SetBool("Fly", true);
            // animator.StartPlayback();


            rigidbody.velocity = Vector2.up * 10;
            // rigidbody.rotation = 21;
        }
        else /*if (Input.GetKeyUp(KeyCode.Space))*/ { animator.SetBool("Fly", false); }
        //animator.StopPlayback(); }
       // rigidbody.rotation = -21;
    }
}
