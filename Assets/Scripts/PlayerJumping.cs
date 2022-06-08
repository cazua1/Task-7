using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerJumping : MonoBehaviour
{
    [SerializeField] private float _jumpForse;
    [SerializeField] private Transform _footPosition;
    [SerializeField] private LayerMask _ground;

    private bool _isGrounded;    
    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {        
        Jump();
        ChekingGround();
    }   

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForse);
        }
    }

    private void ChekingGround()
    {
        float radius = 0.5f;
        _isGrounded = Physics2D.OverlapCircle(_footPosition.position, radius, _ground);
    }
}
