using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Enemy : MonoBehaviour
{
    private Animator _animator;
    private bool _isAlive;

    public bool IsAlive => _isAlive;

    private void Start()
    {
        _isAlive = false; ;
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        const string _isKill = "Death";

        if (collision.TryGetComponent<Player>(out Player player))
        {
            _isAlive = true;
            Debug.Log("kill");
            _animator.SetBool(_isKill, true);
        }
    }
}
