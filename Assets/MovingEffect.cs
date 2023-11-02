using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEffect : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Moving", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("walking");
            animator.SetBool("Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            print("idle");
            animator.SetBool("Walking", false);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            print("idle");
            animator.SetBool("Walking", false);
        }
    }
}
