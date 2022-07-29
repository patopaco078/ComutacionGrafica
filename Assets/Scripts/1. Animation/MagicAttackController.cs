using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class MagicAttackController : MonoBehaviour {

    private Animator animator;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("IsAttack");
        }
    }
}
