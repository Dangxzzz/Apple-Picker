using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Basket : MonoBehaviour
{
    #region Variables

    [FormerlySerializedAs("scoreGT")] [Header("Set Dynamically")]
    public TextMeshProUGUI scoreGt;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        GameObject scoreGo = GameObject.Find("ScoreCounter");
        scoreGt = scoreGo.GetComponent<TextMeshProUGUI>();
        scoreGt.text = "0";
    }

    private void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            int score = int.Parse(scoreGt.text);
            score += 100;
            scoreGt.text = score.ToString();
            if (score > HighScore.Score)
            {
                HighScore.Score = score;
            }
        }
    }

    #endregion
}