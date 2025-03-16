using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] private float moveSpeed = 5f;
  
  private PlayerControls controls; 
  private Vector2 moveInput;

  private void Awake() 
  {
    controls = new PlayerControls();  
  }

 private void OnEnable() 
 {
    controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
    controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;
    controls.Enable();
 }

 private void OnDisable() 
 {
    controls.Disable();   
 }

 private void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0f, moveInput.y) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }

}