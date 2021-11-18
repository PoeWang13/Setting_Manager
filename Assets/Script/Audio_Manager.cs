using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections;
public class Audio_Manager : MonoBehaviour
{
    [SerializeField] private AudioSource backGroundSource;
    public void PlayNewBackGroundMusic(AudioClip newClip)
    {
        StartCoroutine(ChanceMusic(newClip));
    }
    IEnumerator ChanceMusic(AudioClip newClip)
    {
        bool chancedMusic = false;
        int chancedDirection = -1;
        while (!chancedMusic)
        {
            yield return null;
            if (chancedDirection == -1)
            {
                if (backGroundSource.volume > 0)
                {
                    backGroundSource.volume += chancedDirection * Time.deltaTime;
                }
                else
                {
                    chancedDirection = 1;
                    backGroundSource.clip = newClip;
                }
            }
            else
            {
                if (backGroundSource.volume < 1)
                {
                    backGroundSource.volume += chancedDirection * Time.deltaTime;
                }
                else
                {
                    chancedMusic = true;
                }
            }
        }
    }
}