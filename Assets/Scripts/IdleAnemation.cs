using UnityEngine;

public class IdleAnemation : MonoBehaviour
{
    public RectTransform target;
    public float minScale = 1f;
    public float maxScale = 1.05f;
    public float duration = 1f;

    void Start()
    {
        if (target == null)
            target = GetComponent<RectTransform>();
        StartCoroutine(Pulse());
    }

    System.Collections.IEnumerator Pulse()
    {
        while (true)
        {
            yield return ScaleOverTime(minScale, maxScale);
            yield return ScaleOverTime(maxScale, minScale);
        }
    }

    System.Collections.IEnumerator ScaleOverTime(float from, float to)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            float scale = Mathf.Lerp(from, to, elapsed / duration);
            target.localScale = Vector3.one * scale;
            elapsed += Time.deltaTime;
            yield return null;
        }
        target.localScale = Vector3.one * to;
    }
}
