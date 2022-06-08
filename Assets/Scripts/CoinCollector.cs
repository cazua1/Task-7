using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    private int _ñounter;

    private void FixedUpdate()
    {
        ShowCoinsCounter();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            Destroy(coin.gameObject);
            _ñounter++;            
        }
    }

    private void ShowCoinsCounter()
    {
        Debug.Log(_ñounter);
    }
}