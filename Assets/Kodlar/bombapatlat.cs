using UnityEngine;

public class bombapatlat : MonoBehaviour
{
    public AudioClip bombaSesi;

    private void OnMouseEnter()
    {
        if (skor.oyunBitti) return;

        AudioSource.PlayClipAtPoint(bombaSesi, transform.position);

        skor.skorum--;

        if (skor.skorum <= 0)
        {
            skor.skorum = 0;
            skor.oyunBitti = true;
        }

        Destroy(gameObject);
    }
}