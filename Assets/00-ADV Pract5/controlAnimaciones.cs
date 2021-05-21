using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(Collider))]
public class controlAnimaciones : MonoBehaviour
{
    public Animator animator;
    public string booleanParameter;
    public PlayableDirector timeline;

    bool b = false;

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "boy")
        {
            b = !b;
            animator.SetBool(booleanParameter, b);
            Invoke("showEnding", 2);
        }
        
    }

    private void showEnding()
    {
        timeline.Play();
    }
}
