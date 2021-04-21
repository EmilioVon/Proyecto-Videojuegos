using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MENUSFX : MonoBehaviour
{
   public AudioSource ArcadeScoreSound;
   public AudioSource PositiveInterface;
   

   public void PlayArcadeScoreSound() {
       ArcadeScoreSound.Play ();
       
   }
    public void PlayPositiveInterface() {
       PositiveInterface.Play ();
    }
}
