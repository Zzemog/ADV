using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float accelDown = 1f;
    public float animConst = 0.02f;
    public Animator animator;
    public CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //charController.Move(Vector3.down * accelDown * Time.deltaTime);
        //animator.SetFloat("vertical", 0);
        //animator.SetFloat("horizontal", 0);
        if (Input.GetKey(KeyCode.W))
        {
            if (animator.GetFloat("vertical") < 1.0f) animator.SetFloat("vertical", animator.GetFloat("vertical") + animConst);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (animator.GetFloat("vertical") > -1.0f) animator.SetFloat("vertical", animator.GetFloat("vertical") - animConst);
        }
        else
        {
            if (animator.GetFloat("vertical") > 0) animator.SetFloat("vertical", animator.GetFloat("vertical") - animConst);
            else if (animator.GetFloat("vertical") < 0) animator.SetFloat("vertical", animator.GetFloat("vertical") + animConst);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (animator.GetFloat("horizontal") < 1.0f) animator.SetFloat("horizontal", animator.GetFloat("horizontal") + animConst);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            if (animator.GetFloat("horizontal") > -1.0f) animator.SetFloat("horizontal", animator.GetFloat("horizontal") - animConst);
        }
        else
        {
            if (animator.GetFloat("horizontal") > 0) animator.SetFloat("horizontal", animator.GetFloat("horizontal") - animConst);
            else if (animator.GetFloat("horizontal") < 0) animator.SetFloat("horizontal", animator.GetFloat("horizontal") + animConst);
        }
    }

   }
