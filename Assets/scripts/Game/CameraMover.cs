using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Update()
    {
        transform.position = new Vector3(_player.transform.position.x + 1.5f, transform.position.y,transform.position.z);
    }
}
