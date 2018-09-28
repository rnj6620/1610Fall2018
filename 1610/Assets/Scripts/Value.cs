using UnityEngine;
using UnityEngine.Events;

public class Value : MonoBehaviour
{
    public FloatData Data;
    
    public void AddValueToObject(FloatData data)
    {
        Data.Value += data.Value;
    }

    public void SubtractValueToObject(FloatData data)
    {
        Data.Value -= data.Value;
    }

    public void MultiplyValueToObject(FloatData data)
    {
        Data.Value *= data.Value;
    }

    public void DivideValueToObject(FloatData data)
    {
        Data.Value /= data.Value;
    }
}
