using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator animator;
    private CharacterController characterController;

    public float gravity = 1f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //characterController.Move(Vector3.down * gravity * Time.deltaTime);

        animator.SetFloat("vertical", 0);
        animator.SetFloat("horizontal", 0);

        if(Input.GetKey(KeyCode.I))
        {
            animator.SetFloat("vertical", 1);
        } 
        else if (Input.GetKey(KeyCode.M)){
            animator.SetFloat("vertical", -1);
        }

        if (Input.GetKey(KeyCode.J))
        {
            animator.SetFloat("horizontal", -1);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            animator.SetFloat("horizontal", 1);
        }
    }
}
