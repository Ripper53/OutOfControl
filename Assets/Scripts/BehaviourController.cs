using UnityEngine;

public class BehaviourController : MonoBehaviour {
    public Behaviour Behaviour;

    public void Enable() => Behaviour.enabled = true;
    public void Disable() => Behaviour.enabled = false;

}
