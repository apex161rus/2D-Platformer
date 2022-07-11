using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Enemy : MonoBehaviour
{
    private Animator _animator;
    private bool _isAlive;
    private string _isKill;

    public bool IsAlive => _isAlive;

    private void Start()
    {
        _isKill = "Death";
        _isAlive = false; ;
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _isAlive = true;
            Debug.Log("kill");
            _animator.SetBool(_isKill, true);
        }
    }
}
