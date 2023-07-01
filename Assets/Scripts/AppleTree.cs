using UnityEngine;

public class AppleTree : MonoBehaviour
{
    #region Variables

    [Header("Set in Inspector")]
    public GameObject applePrefab;
    public float chanceToChangeDirections = 0.0001f;
    public float leftAndRightEdge = 10f;
    public float secondsBetweenAppleDroops = 1f;
    public float speed = 1f;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Invoke("DropApple", 2f);
    }

    private void Update()
    {
        if (speed < 0)
        {
            speed -= 0.00015f;
        }
        else
        {
            speed += 0.00015f;
        }

        chanceToChangeDirections += 0.00000015f;
        secondsBetweenAppleDroops -= 0.000001f;
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }

    #endregion

    #region Private methods

    private void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDroops);
    }

    #endregion
}