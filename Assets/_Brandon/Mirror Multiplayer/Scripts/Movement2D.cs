using UnityEngine;

public class Movement2D : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 1;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MoveLeft(moveSpeed);
            spriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            MoveRight(moveSpeed);
            spriteRenderer.flipX = false;
        }
    }

    public void MoveLeft(float moveSpeed)
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        
    }

    public void MoveRight(float moveSpeed)
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        Physics.Raycast(ray, out hit);
    }
}
