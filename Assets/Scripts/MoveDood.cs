using UnityEngine;

public class MoveDood : MonoBehaviour
{
    public Transform dood;
    [SerializeField]
    private float speed = 15f;
    public GameObject Dood;

    void OnMouseDrag()
    {
        if (!Death.lose)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.x = mousePos.x > 2.5f ? 2.5f : mousePos.x;
            mousePos.x = mousePos.x < -2.5f ? -2.5f : mousePos.x;
            dood.position = Vector2.MoveTowards(dood.position, new Vector2(mousePos.x, dood.position.y),
                speed * Time.deltaTime);
        }
    }
    void Update()
    {
        if (Death.lose)
            Destroy(Dood);
    }
    
}
