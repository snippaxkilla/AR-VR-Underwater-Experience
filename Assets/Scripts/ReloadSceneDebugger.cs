using UnityEngine;

public class ReloadSceneDebugger : MonoBehaviour
{
    [SerializeField] private OVRInput.RawButton resetSceneButton;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || OVRInput.GetDown(resetSceneButton))
        {
            ResetScene();
        }
    }

    private void ResetScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
