using UnityEngine;

public class Death : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart;

    void Awake()
    {
        lose = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "box")
        {
            lose = true;
            restart.SetActive(true);
        }


    }
}
