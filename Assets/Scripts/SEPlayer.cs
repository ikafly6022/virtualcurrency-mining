using UnityEngine;
using UnityEngine.Timeline;

public class SEPlayer : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] private AudioClip[] se = new AudioClip[1];
    public static bool[] seFlag = new bool[1];
    /* インデックスは0から */

    void Awake()
    {
        SEFlagClear();
    } 
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        Play();
    }

    void Play()
    {
        for (byte i = 0; i < se.Length; i++)
        {
            if (seFlag[i] == true)
            {
                audioSource.PlayOneShot(se[i]);
                seFlag[i] = false;
            }
        }
    }

    void SEFlagClear()
    {
        for (byte i = 0; i < se.Length; i++)
        {
            seFlag[i] = false;
        }
    }
}
