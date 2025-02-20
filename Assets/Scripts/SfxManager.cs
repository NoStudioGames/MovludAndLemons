using UnityEngine;

public class SfxManager : MonoBehaviour
{
    [Header("Source")]
    public AudioSource source;
    [Header("AudioClips")]
    public AudioClip angry;
    public AudioClip lemon;
    public AudioClip tomatosplash;
    public AudioClip win;
    public AudioClip lose;




    void Start()
    {
        source = GetComponent<AudioSource>();

        angry = Resources.Load<AudioClip>("angry");
        lemon = Resources.Load<AudioClip>("collect");
        tomatosplash = Resources.Load<AudioClip>("tomato");
        win = Resources.Load<AudioClip>("win");
        lose = Resources.Load<AudioClip>("loss");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound(0);
        }
    }

    public void PlaySound(float sfxId)
    {
        switch (sfxId)
        {
            case 0:
                return;
            case 1:
                source.PlayOneShot(lemon);
                return;
            case 2:
                source.PlayOneShot(win);
                return;
            case 3:
                source.PlayOneShot(lose);
                return;
            case 4:
                source.PlayOneShot(angry);
                return;
            case 5:
                source.PlayOneShot(tomatosplash);
                return;
            default:
                break;
        }

    }

}
