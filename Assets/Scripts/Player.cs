using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    private bool dragging = false;
    private Vector3 offset;
    public Animator animator;

    private float posX;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        posX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        if (dragging && posX > -2.2f && posX < 2.2f && gameManager.isGame)
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, transform.position.z);
        }
        animator.SetBool("dragging", dragging);
        animator.SetBool("isGame", gameManager.isGame);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Lemon")
        {
            gameManager.Score();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Tomato")
        {
            animator.SetTrigger("over");
            gameManager.gotTomato = true;
            gameManager.EndGame();
            Destroy(collision.gameObject);
        }

    }
    private void OnMouseDown()
    {
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
