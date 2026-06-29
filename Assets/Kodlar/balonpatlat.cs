using UnityEngine;

public class balonpatlat : MonoBehaviour
{
    float baslangicX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        baslangicX=transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(baslangicX+ Mathf.Sin(Time.time)*3, transform.position.y);
    }
    private void OnMouseEnter()
    {
        GameObject.Find("balonUretici").GetComponent<AudioSource>().Play();
        skor.skorum++;

        Destroy(gameObject);
    }
}
