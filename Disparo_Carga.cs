using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_Carga : MonoBehaviour
{
    public float Velocidad = 10;
    private Rigidbody2D rigidbody;
    private RobotController robotController2;

    public void SetRobot2(RobotController RobotController2)
    {
        robotController2 = RobotController2;
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        Destroy(this.gameObject, 5);
    }

    void Update()
    {
        rigidbody.velocity = new Vector2(Velocidad, rigidbody.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D Other)
    {
        var tag = Other.gameObject.tag;

    }
    private void OnTriggerEnter2D(Collider2D Other)
    {
        var tag = Other.gameObject.tag;
        if (tag == "Enemigo")
        {
            Destroy(this.gameObject);
            Destroy(Other.gameObject);
            robotController2.Quitar_Vida(2);
        }

    }
}
