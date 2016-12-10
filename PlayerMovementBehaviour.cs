using UnityEngine;
using System.Collections;

public class PlayerMovementBehaviour : MonoBehaviour {
    private const float rotate_thrust = (float)1;
    private const float move_thrust = 1;
    private Rigidbody myBody;
    private Vector3 myCenterOfMass;
    private PlayerFuelBehaviour myFuelHandler;
    private ParticleTriggerBehaviour myParticleHandler;

    // Use this for initialization
    void Start ()
    {
        myBody = GetComponent<Rigidbody>();
        myCenterOfMass = myBody.centerOfMass;
        myFuelHandler = gameObject.GetComponent<PlayerFuelBehaviour>();
        myParticleHandler = gameObject.GetComponent<ParticleTriggerBehaviour>();
    }

    public void Move(Vector3 direction)
    {
        if (myFuelHandler.HasFuel())
        {
            Vector3 localForce = myBody.transform.TransformDirection(direction * move_thrust);
            myBody.AddForce(localForce);
            myFuelHandler.DecreaseFuel();
            if (direction == Vector3.left)
            {
                myParticleHandler.TriggerLeftParticles();
            }
            else if (direction == Vector3.right)
            {
                myParticleHandler.TriggerRightParticles();
            }
            else if (direction == Vector3.up)
            {
                myParticleHandler.TriggerForwardParticles();
            }
            else if (direction == Vector3.down)
            {
                myParticleHandler.TriggerBackwardParticles();
            }
            else if (direction == Vector3.forward)
            {
                myParticleHandler.TriggerUpParticles();
            }
            else if (direction == Vector3.back)
            {
                myParticleHandler.TriggerDownParticles();
            }
        }
    }

    public void Rotate(int side)
    {
        if (myFuelHandler.HasFuel())
        {
            myBody.AddTorque(transform.forward * rotate_thrust * side);
            myFuelHandler.DecreaseFuel();
            if (side == 1)
            {
                myParticleHandler.TriggerForwardLeftParticles();
            }
            else
            {
                myParticleHandler.TriggerForwardRightParticles();
            }
        }
    }
}
