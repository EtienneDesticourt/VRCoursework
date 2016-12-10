using UnityEngine;
using System.Collections;

public class ParticleTriggerBehaviour : MonoBehaviour {
    ParticleSystem left1, left2, right1, right2, forLeft1, forLeft2, forRight1, forRight2, back1, back2, back3, back4, down1, down2, up1, up2;

	// Use this for initialization
	void Start () {
        left1 = GameObject.Find("Thruster Left 1/Cube").GetComponent<ParticleSystem>();
        left2 = GameObject.Find("Thruster Left 2/Cube").GetComponent<ParticleSystem>();
        right1 = GameObject.Find("Thruster Right 1/Cube").GetComponent<ParticleSystem>();
        right2 = GameObject.Find("Thruster Right 2/Cube").GetComponent<ParticleSystem>();
        forLeft1 = GameObject.Find("Thruster Forward Left 1/Cube").GetComponent<ParticleSystem>();
        forLeft2 = GameObject.Find("Thruster Forward Left 2/Cube").GetComponent<ParticleSystem>();
        forRight1 = GameObject.Find("Thruster Forward Right 1/Cube").GetComponent<ParticleSystem>();
        forRight2 = GameObject.Find("Thruster Forward Right 2/Cube").GetComponent<ParticleSystem>();
        back1 = GameObject.Find("Thruster Backward 1/Cube").GetComponent<ParticleSystem>();
        back2 = GameObject.Find("Thruster Backward 2/Cube").GetComponent<ParticleSystem>();
        back3 = GameObject.Find("Thruster Backward 3/Cube").GetComponent<ParticleSystem>();
        back4 = GameObject.Find("Thruster Backward 4/Cube").GetComponent<ParticleSystem>();
        down1 = GameObject.Find("Thruster Down 1/Cube").GetComponent<ParticleSystem>();
        down2 = GameObject.Find("Thruster Down 2/Cube").GetComponent<ParticleSystem>();
        up1 = GameObject.Find("Thruster Up 1/Cube").GetComponent<ParticleSystem>();
        up2 = GameObject.Find("Thruster Up 2/Cube").GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TriggerLeftParticles()
    {
        left1.Play();
        left2.Play();
    }

    public void TriggerRightParticles()
    {
        right1.Play();
        right2.Play();
    }

    public void TriggerUpParticles()
    {
        up1.Play();
        up2.Play();
    }

    public void TriggerDownParticles()
    {
        down1.Play();
        down2.Play();
    }

    public void TriggerForwardLeftParticles()
    {
        forLeft1.Play();
        forLeft2.Play();
    }

    public void TriggerForwardRightParticles()
    {
        forRight1.Play();
        forRight2.Play();
    }

    public void TriggerForwardParticles()
    {
        TriggerForwardLeftParticles();
        TriggerForwardRightParticles();
    }

    public void TriggerBackwardParticles()
    {
        back1.Play();
        back2.Play();
        back3.Play();
        back4.Play();
    }

    public void TurnOffAll()
    {
        up1.Stop();
        up2.Stop();
        back1.Stop();
        back2.Stop();
        back3.Stop();
        back4.Stop();
        forRight1.Stop();
        forRight2.Stop();
        forLeft1.Stop();
        forLeft2.Stop();
        down1.Stop();
        down2.Stop();
        right1.Stop();
        right2.Stop();
        left1.Stop();
        left2.Stop();
    }
}
