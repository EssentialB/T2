using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Velocity = -10;
    private static readonly string Animator_State = "Estado";

    private static readonly int Animation_Run = 0;


    private Rigidbody2D rigidbody; 
    private Animator animator;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
        
    void Update()
    {
        var velocidadActualX = rigidbody.velocity.x;
        var velocidadActualY = rigidbody.velocity.y;

        rigidbody.velocity = new Vector2(Velocity, rigidbody.velocity.y);
        Change_Animation(Animation_Run);
    }

    private void Desplazarse(int Position)
    {
        
        rigidbody.velocity = new Vector2(10 * Position, rigidbody.velocity.y); 
        Change_Animation(Animation_Run);
    }
    private void Change_Animation(int Animation)
    {
        animator.SetInteger(Animator_State, Animation);
    }
}
