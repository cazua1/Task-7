using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int _�ounter;

    private void FixedUpdate()
    {
        ShowCoinsCounter();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            Destroy(coin.gameObject);
            _�ounter++;            
        }
    }

    private void ShowCoinsCounter()
    {
        Debug.Log(_�ounter);
    }
}