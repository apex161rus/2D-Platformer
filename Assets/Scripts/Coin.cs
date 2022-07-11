using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _price;

    public int Price => _price;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Debug.Log(_price);
            Destroy(gameObject);
        }
    }
}
