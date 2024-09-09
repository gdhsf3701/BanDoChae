using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timerText; // UI에 표시할 Text 요소를 연결
    private float timeElapsed;

    void Update()
    {
        // 시간이 흐른 만큼 더함
        timeElapsed += Time.deltaTime;

        // 시간 형식으로 변환 (정수 초:초 형식)
        int minutes = Mathf.FloorToInt(timeElapsed / 60F);
        int seconds = Mathf.FloorToInt(timeElapsed % 60F);

        // "초:초" 형식으로 UI에 표시
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
