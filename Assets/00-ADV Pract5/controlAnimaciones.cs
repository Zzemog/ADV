using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class controlAnimaciones : MonoBehaviour
{
    public Animator animator;
    public string booleanParameter;

    bool b = false;

    private void OnTriggerEnter(Collider other)
    {
        b = !b;
        animator.SetBool(booleanParameter, b);
    }
}
