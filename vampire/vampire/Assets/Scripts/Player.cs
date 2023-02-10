using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed = 3f;
    public Scanner scanner;
    Rigidbody2D rigidbody;
    SpriteRenderer sprite;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        scanner = GetComponent<Scanner>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed*Time.fixedDeltaTime;
        rigidbody.MovePosition(rigidbody.position + nextVec);
    }

    private void LateUpdate()
    {
        animator.SetFloat("speed", inputVec.magnitude);
        var isLeft = inputVec.x < 0;
        sprite.flipX = isLeft;
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
