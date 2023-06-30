using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class PlayerMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public float moveSpeed;
    public Vector2 moveDirection;
    public Animator animator;
    // Update is called once per frame
    void Update() {
        ProcessInput();
    }
    void FixedUpdate() {
        Move();
    }
    void ProcessInput() {
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(movex, movey).normalized;
        if (moveDirection != Vector2.zero) {
            animator.SetFloat("horizontalidle", moveDirection.x);
            animator.SetFloat("verticalidle", moveDirection.y);
            Weapon weapon = GetComponent<Weapon>();
            weapon.grenadeDir = moveDirection;
        }
    }
    void Move() {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed * Time.deltaTime, moveDirection.y * moveSpeed * Time.deltaTime);
    }
}
