using UnityEngine;

public class bombauret : MonoBehaviour
{
    public GameObject[] bomba;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("klonla", 0, 3);
    }
    void klonla()
    {
        if (skor.oyunBitti) return;
        float rastgelesayi = Random.Range(-10f, 10f);
        int rastgelebalonsayisi = Random.Range(0, bomba.Length);

        Vector2 pozisyon = new Vector2(rastgelesayi, transform.position.y);

        Instantiate(bomba[rastgelebalonsayisi], pozisyon, transform.rotation);

    }
}
