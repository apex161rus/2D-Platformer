using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Transform _graundCheck;
    [SerializeField] private float _checRadius = 0.3f;
    [SerializeField] private LayerMask _graund;

    private Animator _animator;
    private float _jumpheigt = 5.60f;
    private bool _isAnimator = false;
    private bool _isGround;
    private string _isMove;

    private void Start()
    {
        _isMove = "isMove";
        _animator = GetComponent<Animator>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    } 

    private void Update()
    {
        CheckingGraund();
        InputMovementVector();
        Jump();
    }

    private bool CheckingGraund()
    {
        return _isGround = Physics2D.OverlapCircle(_graundCheck.position, _checRadius, _graund);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isGround)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpheigt, ForceMode2D.Impulse);        
        }
    }

    private void InputMovementVector()
    {
        float _speed = 4;

        if (Input.GetKey(KeyCode.D))
        {
            _isAnimator = true;
            _animator.SetBool(_isMove, _isAnimator && _isGround);
            transform.eulerAngles = new Vector3(0, 0, 0);
            transform.Translate(_speed * Time.deltaTime * 1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _isAnimator = true;
            _animator.SetBool(_isMove, _isAnimator && _isGround);
            transform.eulerAngles = new Vector3(0, 180, 0);
            transform.Translate(_speed * Time.deltaTime * 1, 0, 0);
        }
        else
        {
            _isAnimator = false;
            _animator.SetBool(_isMove, _isAnimator);
        }
    }
}
