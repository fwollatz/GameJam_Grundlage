using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{

    public GameObject spieler_prefab;
    public GameObject spieler_active;

    public GameObject steinschlag_prefab;

    void SpawnSpieler()
    {
        float y_pos = 1f; // f steht für float
        float x_pos = -8f;
        Vector2 position = new Vector2(x_pos, y_pos);
        spieler_active = Instantiate(spieler_prefab, position, Quaternion.identity);
    }

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
        SpawnSpieler();
        StartCoroutine(GeneriereCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        if (spieler_active == null) {
            SpawnSpieler();
        }

    }

    IEnumerator GeneriereCountdown()
    {
        while (true)
        {
            SpawnSteinschlag();
            yield return new WaitForSeconds(2f);
        }
    }
}
