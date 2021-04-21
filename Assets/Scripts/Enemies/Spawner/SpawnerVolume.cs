using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class SpawnerVolume : MonoBehaviour
{
    private BoxCollider collider;
    // Start is called before the first frame update

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
    }

    void Start()
    {
        
    }
    public Vector3 GetPositionInBounds()
    {
        Bounds bound = collider.bounds;
        return new Vector3(
            x: Random.Range(bound.min.x, bound.max.x),
            transform.position.y,
            z: Random.Range(bound.min.z, bound.max.z));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
