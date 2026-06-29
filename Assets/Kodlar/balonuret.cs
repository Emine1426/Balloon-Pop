using UnityEngine;

public class balonuret : MonoBehaviour
{

    public GameObject[] balon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("klonla", 0, 0.5f);
    }
    void klonla()
    {
        if (skor.oyunBitti) return;
        float rastgelesayi = Random.Range(-10f, 10f);
        int rastgelebalonsayisi = Random.Range(0, balon.Length);

        Vector2 pozisyon = new Vector2(rastgelesayi, transform.position.y);

        Instantiate(balon[rastgelebalonsayisi], pozisyon, transform.rotation);

    }


    // Update is called once per frame
    void Update()
    {

    }
}
