using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    public float vel;
    // Start is called before the first frame update
    public Vector2 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        direction.Normalize();

        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);


        var scale = transform.localScale;
        if (direction.x < 0)
        {
            scale.x = -0.35f;
        }
        else if (direction.x > 0)
        {
            scale.x = 0.35f;
        }
        transform.localScale = scale;


        // rb.velocity.Set(Input.GetAxisRaw("Horizontal")*vel*Time.deltaTime, Input.GetAxisRaw("Vertical")*vel*Time.deltaTime);

    }

    private void FixedUpdate()
    {
        rb.velocity = direction * vel * Time.fixedDeltaTime;

    }

}

