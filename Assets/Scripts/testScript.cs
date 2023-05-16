using UnityEngine;

public class testScript : MonoBehaviour
{
    public InterpolateFog fogscript;
    // Start is called before the first frame update
    void Start()
    {
        fogscript.FogChange(InterpolateFog.FogStates.S100);
    }
}