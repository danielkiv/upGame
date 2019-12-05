//player's status bar
using UnityEngine;
using UnityEngine.UI;

public class StatusIndicator : MonoBehaviour
{
    [SerializeField]
    private RectTransform HealthBar;

    void Start()
    {
        if (HealthBar == null)
        {
            Debug.LogError("No healthbar reference");
        }
    }

    //player health bar
    public void setHealth(int Current, int Max)
    {
        float Value = (float) Current / Max;

        HealthBar.localScale = new Vector3(Value, HealthBar.localScale.y, HealthBar.localScale.z);
    }
}
