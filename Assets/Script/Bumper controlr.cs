using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpercontrolr : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = color;

        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolarig = bola.GetComponent<Rigidbody>();
            bolarig.velocity *= multiplier;

            //animator.SetTrigger("hit") ??? gak ada ditutorial
            
            audioManager.PlaySFX(collision.transform.position);
           
            vfxManager.PlayVFX(collision.transform.position);
            scoreManager.AddScore(score);


        }
    }
}
