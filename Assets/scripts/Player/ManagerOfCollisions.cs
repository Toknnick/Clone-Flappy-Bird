using UnityEngine;

[RequireComponent(typeof(Player))]
public class ManagerOfCollisions : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Pipe pipe))
            _player.ChangeScore(1);
        else
            _player.Die();
    }
}
