using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    private bool isPlaying = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isPlaying)
            {
                audioSource.Pause(); 
                isPlaying = false;
            }
            else
            {
                audioSource.Play(); 
                isPlaying = true;
            }
        }
    }
}
