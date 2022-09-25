using UnityEngine;

public class SwitcherOfPipes : ObjectPool
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private float _delay;

    private float _timeAfterLastSpawn;

    public void SwitchOffAllPipes()
    {
        foreach (var item in Pool)
            item.SetActive(false);
    }

    private void Start()
    {
        Initialize(_prefabs);
    }

    private void Update()
    {
        _timeAfterLastSpawn += Time.deltaTime;

        if (_timeAfterLastSpawn >= _delay)
        {
            if (TryGetObject(out GameObject pipe))
            {
                _timeAfterLastSpawn = 0;
                pipe.SetActive(true);
                pipe.transform.position = transform.position;
                DisableObjectsAbroadScreen();
            }
        }
    }

    private void DisableObjectsAbroadScreen()
    {
        Vector3 disablePoint = _camera.ViewportToWorldPoint(new Vector2(0, 0.5f));

        foreach (var item in Pool)
        {
            if (item.activeSelf == true)
            {
                if (item.transform.position.x < disablePoint.x)
                    item.SetActive(false);
            }
        }
    }

}
