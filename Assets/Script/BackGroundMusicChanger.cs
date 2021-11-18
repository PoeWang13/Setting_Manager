using UnityEngine;

public enum CheckPos { X, Y, Z }
public class BackGroundMusicChanger : MonoBehaviour
{
    [SerializeField] private Audio_Manager audio_Manager;
    [SerializeField] private AudioClip onClip;
    [SerializeField] private AudioClip arkaClip;
    [SerializeField] private CheckPos checkPos;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (audio_Manager == null)
            {
                audio_Manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Audio_Manager>();
            }
            if (checkPos == CheckPos.X)
            {
                if (other.transform.position.x >= transform.position.x)
                {
                    audio_Manager.PlayNewBackGroundMusic(onClip);
                }
                else
                {
                    audio_Manager.PlayNewBackGroundMusic(arkaClip);
                }
            }
            else if (checkPos == CheckPos.Y)
            {
                if (other.transform.position.y >= transform.position.y)
                {
                    audio_Manager.PlayNewBackGroundMusic(onClip);
                }
                else
                {
                    audio_Manager.PlayNewBackGroundMusic(arkaClip);
                }
            }
            else if (checkPos == CheckPos.Z)
            {
                if (other.transform.position.z >= transform.position.z)
                {
                    audio_Manager.PlayNewBackGroundMusic(onClip);
                }
                else
                {
                    audio_Manager.PlayNewBackGroundMusic(arkaClip);
                }
            }
        }
    }
}