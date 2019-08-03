using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballController : MonoBehaviour
{
    [SerializeField]
    private float fireballSpeed = 1f;
    
    private float fireballTimer = 0f;
    [SerializeField]
    private float fireballRefire = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector2.right * fireballSpeed * Time.deltaTime);

        fireballTimer += Time.deltaTime;
        if (fireballTimer >= fireballRefire)
        {
            fireballTimer = 0;
            Destroy(gameObject);
        }
}
}
