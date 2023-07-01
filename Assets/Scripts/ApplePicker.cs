using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    #region Variables

    public float basketBottomY = -14f;
    public List<GameObject> basketList;
    [Header("Set in Inspector")]
    public GameObject basketPrefab;
    public float basketSpacingY = 2f;
    public int numBaskets = 3;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGo = Instantiate(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + basketSpacingY * i;
            tBasketGo.transform.position = pos;
            basketList.Add(tBasketGo);
        }
    }

    #endregion

    #region Public methods

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGo in tAppleArray)
        {
            Destroy(tGo);
        }

        int basketIndex = basketList.Count - 1;
        GameObject tBasketGo = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("GameOverMenu");
        }
    }

    #endregion
}