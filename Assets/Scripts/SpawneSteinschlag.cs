using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneSteinschlag : MonoBehaviour
{

    [SerializeField] GameObject steinschlag_prefab;


    void SpawnSteinschlag()
    {
        float y_pos = 13f; // über dem Sichtfeld
        float x_pos = Random.Range(-8f, 8f);
        Vector2 position = new Vector2(x_pos, y_pos);
        GameObject steinschlag_active = Instantiate(steinschlag_prefab, position, Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(starteSteinschlag());
    }

    IEnumerator starteSteinschlag()
    {
        while (true)
        {
            SpawnSteinschlag();
            yield return new WaitForSeconds(2f);
        }
    }
}
