using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 10f;
    
    private Animator animator;
    private CharacterController controller;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }
    
    private void Update()
    {
        HandleMovement();
        HandleAttack();
    }
    
    private void HandleMovement()
    {
        // Movement code
    }
    
    private void HandleAttack()
    {
        // Attack logic
    }
}