using UnityEngine;
using UnityEngine.InputSystem;

public class CartMove : MonoBehaviour
{
    private Rigidbody _rb;
    
    [SerializeField] private float cartSpeed = 10f;
    [SerializeField] private float turnSpeed = 10f;

    private Vector3 _inputMove;
    private float _turnInput = 0f;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = transform.right * _inputMove.x + transform.forward * _inputMove.y;
        _rb.linearVelocity = new Vector3(moveDirection.x * cartSpeed, _rb.linearVelocity.y, moveDirection.z * cartSpeed);

        _rb.AddRelativeTorque(0, _turnInput * turnSpeed, 0);
    }

    public void InputMove(InputAction.CallbackContext context)
    {
        _inputMove = context.ReadValue<Vector2>();
    }

    public void InputTurn(InputAction.CallbackContext context)
    {
        _turnInput = context.ReadValue<float>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("collides");
            
        }
    }
}
