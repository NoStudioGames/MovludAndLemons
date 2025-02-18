using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    private bool dragging = false;
    private Vector3 offset;

    private float posX;
    void Start()
    {
        
    }

    void Update()
    {
        posX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        if (dragging && posX > -2.2f && posX < 2.2f)
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, transform.position.z);
        }
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
