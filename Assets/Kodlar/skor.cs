using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skor : MonoBehaviour
{
    public TextMeshProUGUI skoryazisi;
    public GameObject yenidenBaslatButonu;
    public AudioSource muzik;

    public static int skorum = 0;
    public static bool oyunBitti = false;

    void Start()
    {
        skorum = 0;
        oyunBitti = false;

        yenidenBaslatButonu.SetActive(false);

        if (muzik != null)
        {
            muzik.Play();
        }
    }

    void Update()
    {
        skoryazisi.text = skorum.ToString();

        if (oyunBitti)
        {
            yenidenBaslatButonu.SetActive(true);

            if (muzik != null && muzik.isPlaying)
            {
                muzik.Stop();
            }
        }
    }

    public void YenidenBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}