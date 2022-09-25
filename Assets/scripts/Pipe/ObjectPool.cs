using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;

    private int _countOfPrefabs = 8;
    protected List<GameObject> Pool = new();

    protected void Initialize(GameObject[] prefabs)
    {
        GameObject spawned;

        for (int i = 0; i < _countOfPrefabs; i++)
        {
            spawned = Instantiate(prefabs[Random.Range(0, prefabs.Length)], _container.transform);
            spawned.SetActive(false);
            Pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = Pool.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }
}
