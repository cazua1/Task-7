using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))] 

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.transform.SetPositionAndRotation(_spawnPoint.position, Quaternion.identity);
        }
    }
}
