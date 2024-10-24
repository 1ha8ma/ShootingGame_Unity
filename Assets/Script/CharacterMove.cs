using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    //���s���x
    private float speed = 0.5f;
    //��]���x
    private float rotateSpeed = 0.3f;
    //�A�j���[�V�����I�u�W�F�N�g
    Animator animator;
    //�����A����
    private float horizonalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (verticalInput != 0)
        {
            transform.position += transform.forward * speed * verticalInput;
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsRunning", true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("IsRunning", true);
        }

        transform.Rotate(new Vector3(0, rotateSpeed * horizonalInput, 0));
    }
}
