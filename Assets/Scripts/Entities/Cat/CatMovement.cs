using UnityEngine;
using UnityEngine.Events;

public class CatMovement : Entity
{
    Cat cat;

    [Header("Events")]
    [SerializeField] private UnityEvent Dead;
    [SerializeField] private UnityEvent Jumped;

    [SerializeField] private ContactFilter2D platform;

    private new Rigidbody2D rigidbody;
    private Animator animator;

    private bool isGrounded => rigidbody.IsTouching(platform);

    private string currentState;
    private float scale;

    const string IDLE = "cat_stopping";
    const string WALK = "cat_walk";
    const string RUN = "cat_run";
    const string JUMP = "Cat_start_run";

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        cat = GetComponent<Cat>();
    }

    private void Start()
    {
        scale = transform.localScale.x;
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal"))
            Walk();

        if (Input.GetButtonDown("Jump") && isGrounded)
            Jump();
    }

    private void FixedUpdate()
    {
        float direction = Input.GetAxis("Horizontal");

        if (direction > 0)
            transform.localScale = new Vector2(-scale, transform.localScale.y);
        else if (direction < 0)
            transform.localScale = new Vector2(scale, transform.localScale.y);

        if (isGrounded)
        {
            if (Input.GetButton("Horizontal"))
                ChangeAnimationState(WALK);
            else
            {
                //animationDelay = animator.GetCurrentAnimatorClipInfo(0).Length;
                ChangeAnimationState(IDLE);
            }
        }
        else
            ChangeAnimationState(JUMP);
    }

    private void Walk()
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, cat.GetWalkSpeed() * Time.deltaTime);
    }

    private void Jump()
    {
        rigidbody.AddForce(transform.up * cat.GetJumpForce(), ForceMode2D.Impulse);
        Jumped.Invoke();
    }

    //private void Die() => Dead.Invoke();

    private void ChangeAnimationState(string newState)
    {
        //stop the same animation from interrupting itself
        if (currentState == newState) return;

        //play animation
        animator.Play(newState);

        //reassign the current state
        currentState = newState;
    }
}