using UnityEngine;

public class Apple : MonoBehaviour
{
    #region Variables

    public static float BottomY = -20f;

    #endregion

    #region Unity lifecycle

    private void Update()
    {
        if (transform.position.y < BottomY)
        {
            Destroy(gameObject);
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
    }

    #endregion
}