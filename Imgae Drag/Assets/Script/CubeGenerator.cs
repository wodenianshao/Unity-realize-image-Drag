using UnityEngine;
using System.Collections;

public enum aa
{
    a,
    b,
    c,
    d
}

public class CubeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private aa a;
    [Range(0, 1)] [SerializeField] private float point;

    public void Generator()
    {
        GameObject obj = new GameObject();
        obj = Instantiate( cubePrefab) as GameObject;
        if (obj != null)
        {
            obj.transform.SetParent(transform);
            obj.transform.localScale = cubePrefab.transform.localScale;
            obj.transform.position = transform.position;
            obj.transform.rotation = Random.rotation;
        }
    }
}
