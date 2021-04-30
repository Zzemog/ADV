using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_movement : MonoBehaviour
{
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    Animator animator;
    public Camera camara;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camara.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                agent.destination = hit.point;
            }
        }
        animator.SetFloat("horizontal", transform.InverseTransformDirection(agent.velocity).x);
        animator.SetFloat("vertical", transform.InverseTransformDirection(agent.velocity).z);
    }
}
