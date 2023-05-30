using UnityEngine;

public class BoatManager : MonoBehaviour
{
    [SerializeField] private int mapSize = 10;
    [SerializeField] private float speed = 5;
    [SerializeField] private Rigidbody boatRigidbody;
    [SerializeField] private Vector3 centralPivotPoint;

    private float boatHeightPosition = 10f;

    public enum BoatState
    {
        Moving,
        Stopped
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Run the boatmovement script once certain conditions are met
    private void BoatEvent()
    {

    }

    /* Move the boat from A to B we calculate position A by taking the central pivot point and subtracting the map size to get a radius,
    afterwards we apply a random rotation to the radius to get a random position on the map. By doing this we have our A position. We then invert it to get our B position.
    We then use Vector3.Lerp to move the boat from A to B. This way we make sure that A and B always have a set distance between them. */

    private void BoatMovement()
    {
        var a = new Vector3(centralPivotPoint.x - mapSize, boatHeightPosition, centralPivotPoint.z);


        

        boatRigidbody.MovePosition(Vector3.Lerp(a, b, Time.deltaTime * speed));
    }
}
