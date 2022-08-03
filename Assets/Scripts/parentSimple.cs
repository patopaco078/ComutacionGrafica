using UnityEngine;

public class parentSimple : MonoBehaviour {

    [SerializeField] Transform parent;

    private void Update()
    {
        if (parent != null)
            transform.SetPositionAndRotation(parent.position, parent.rotation);
    }
}
