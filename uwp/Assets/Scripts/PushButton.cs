using UnityEngine;

public class PushButton : MonoBehaviour {

    // Use this for initialization
    bool spheresDropped;
    bool scaledUp;
    void Start () {
        spheresDropped = false;
        scaledUp = true;
    }
	void OnSelect()
    {
        if (spheresDropped)
        {
            this.BroadcastMessage("OnReset");
            spheresDropped = false;
        }
        else
        {
            this.BroadcastMessage("OnDrop");
            spheresDropped = true;
        }
        if (scaledUp)
        {
            this.BroadcastMessage("ScaleDown");
            scaledUp = false;
        }
        else
        {
            scaledUp = true;
            this.BroadcastMessage("ScaleUp");
        }
    }
}
