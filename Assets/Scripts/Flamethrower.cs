using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamethrower : MonoBehaviour {

    [SerializeField] private float attackDuration;
    [SerializeField] private GameObject collider;
    [SerializeField] private ParticleSystem flame;

    private void Awake()
    {
        collider.SetActive(false);
    }

    private void Update()
    {
        if (!collider.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                flame.Play();
                collider.SetActive(true);
                StartCoroutine("DisableCollider");
            }
        }
    }

    IEnumerator DisableCollider()
    {
        yield return new WaitForSeconds(attackDuration);
        collider.SetActive(false);
        flame.Stop();
    }
}
