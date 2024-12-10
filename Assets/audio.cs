using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class audio : MonoBehaviour
{
    public AudioSource source1;
    public AudioSource source2;
    // Start is called before the first frame update

    [YarnCommand("play_drone")]
    public void PlayAudio()
    {
    source1.Play();
    }
    [YarnCommand("stop_drone")]
    public void PauseAudio()
    {
        source1.Pause();
    }

}
