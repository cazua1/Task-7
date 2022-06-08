using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int _coinCounter;

    private void FixedUpdate()
    {
        ShowCoinsCounter();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            Destroy(coin.gameObject);
            _coinCounter++;            
        }
    }

    private void ShowCoinsCounter()
    {
        Debug.Log(_coinCounter);
    }
}