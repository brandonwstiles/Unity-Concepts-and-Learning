using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectPooling;

public class KnightControllerPooled : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private GameObject fireballPrefab;
    [SerializeField]
    private Transform fireballSpawnLocation;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        PoolFireballs();
    }

    public void CastFireball()
    {
        
    }

    private void PoolFireballs()
    {
        ObjectPool.CreateObjectPool(this.gameObject ,fireballPrefab, 32);
    }
}
