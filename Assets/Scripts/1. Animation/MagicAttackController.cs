using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class MagicAttackController : MonoBehaviour {

    private Animator animator;
    [SerializeField] ParticleSystem particle;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        if (!particle.isEmitting)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("IsAttack");
                particle.Play();
            }
        }
        
    }
}
