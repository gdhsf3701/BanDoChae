using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timerText; // UI�� ǥ���� Text ��Ҹ� ����
    private float timeElapsed;

    void Update()
    {
        // �ð��� �帥 ��ŭ ����
        timeElapsed += Time.deltaTime;

        // �ð� �������� ��ȯ (���� ��:�� ����)
        int minutes = Mathf.FloorToInt(timeElapsed / 60F);
        int seconds = Mathf.FloorToInt(timeElapsed % 60F);

        // "��:��" �������� UI�� ǥ��
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
