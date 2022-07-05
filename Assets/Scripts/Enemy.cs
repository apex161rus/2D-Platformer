using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Enemy : MonoBehaviour
{
    private Animator _animator;
    private bool _isKill;

    public bool IsKill => _isKill;

    private void Start()
    {
        _isKill = false; ;
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _isKill = true;
            Debug.Log("kill");
            _animator.SetBool("Death", true);
        }
    }
}
