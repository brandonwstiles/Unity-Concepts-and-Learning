using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightControllerNoPool : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
    private GameObject fireballPrefab;
    [SerializeField]
    private Transform fireballSpawnLocation;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void CastFireball()
    {
        Instantiate(fireballPrefab, fireballSpawnLocation.position, Quaternion.identity);
    }
}
