using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _number;

    public int Number => _number;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Debug.Log(_number);
            Destroy(gameObject);
        }
    }
}
