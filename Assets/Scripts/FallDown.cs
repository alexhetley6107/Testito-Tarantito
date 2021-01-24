using System.Collections;
using UnityEngine;

public class FallDown : MonoBehaviour
{
 
    void Update()
    {
        if (transform.position.y < -8f)
            Destroy(gameObject);

        transform.position -= new Vector3 (0, SpawnBox.fallSpeed * Time.deltaTime, 0);
    }

  
}
