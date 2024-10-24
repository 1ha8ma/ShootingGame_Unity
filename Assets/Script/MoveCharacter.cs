using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Animator animator;
    float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool keyon = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += transform.forward * speed;
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            keyon = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position -= transform.forward * speed;
            transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            keyon = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed;
            transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
            keyon = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
           // transform.position += transform.right * speed;
            transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
            keyon = true;
        }

        if (keyon)
        {
            animator.SetBool("Walk", true);
        }
        else 
        {
            animator.SetBool("Walk", false);
        }
    }
}
