using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmechanic : MonoBehaviour
{
    public Animator animator;
    public float physics;
    public LayerMask Switch;
    public BoxCollider boxCollider;
    public float detection = 0.1f;


    private void OnTriggerEnter(Collider other)
    {
         animator.SetFloat("Blend", 0);
        
        
        {
                animator.SetFloat("Blend", 1);
        }
        
    }
}
