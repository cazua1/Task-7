using System.Collections;

using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coinPrefab;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private Transform[] _points;

    private Transform _currentPoint;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(_spawnDelay));
    }

    private IEnumerator SpawnEnemy(float spawnDelay)
    {
        var delay = new WaitForSeconds(spawnDelay);

        while (true)
        {
            _currentPoint = _points[Random.Range(0, _points.Length)];
            Instantiate(_coinPrefab, _currentPoint.position, Quaternion.identity);
            yield return delay;
        }
    }
}