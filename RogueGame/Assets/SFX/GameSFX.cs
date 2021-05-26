using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSFX : MonoBehaviour
{
public AudioSource GrassStep;
public AudioSource DaggerWoosh;
public AudioSource LittleMonsterLaugh;
public AudioSource ArcadeCoin;

    public void PlayGrassStep() {
    GrassStep.Play ();
}
    public void PlayDaggerWoosh() {
    DaggerWoosh.Play ();
}
    public void PlayLittleMonsterLaugh() {
    LittleMonsterLaugh.Play ();
}
    public void PlayarcadeCoin()
    {
        ArcadeCoin.Play();
    }

}
