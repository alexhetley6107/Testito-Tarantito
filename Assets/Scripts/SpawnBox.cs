using System.Collections;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject[] boxes;
    [SerializeField]
    public static float fallSpeed;

    void Start()
    {
        fallSpeed = 1f;
        StartCoroutine(Spawn());
        StartCoroutine(Accelerate());
    }

    IEnumerator Spawn()
    {
        while(!Death.lose)
        {
            Instantiate(boxes[Random.Range(0,boxes.Length)], 
                new Vector2(Random.Range(-2.5f, 2.5f), 6f), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator Accelerate()
    {
        while (true)
        {
            fallSpeed += 1f;
            yield return new WaitForSeconds(5f);
        }
    }

}
