using UnityEngine;

[System.Serializable]
public struct Reserve {
    [SerializeField]
    private int value, min, max;
    public int Value {
        get => value;
        set {
            ModifiedValue?.Invoke(this, ref value);
            if (value < min)
                value = min;
            else if (value > max)
                value = max;
            this.value = value;
        }
    }
    public int Min {
        get => min;
        set {
            ModifiedMin?.Invoke(this, ref value);
            min = value;
            if (this.value < value)
                Value = value;
        }
    }
    public int Max {
        get => max;
        set {
            ModifiedMax?.Invoke(this, ref value);
            max = value;
            if (this.value > value)
                Value = value;
        }
    }

    public delegate void ModifiedEvent(Reserve source, ref int value);
    public event ModifiedEvent ModifiedValue, ModifiedMin, ModifiedMax;
}
