using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour {
    public AudioClip[] se;

	public void playSE(int num){
        this.GetComponent<AudioSource>().PlayOneShot(se[num]);
	}
}
