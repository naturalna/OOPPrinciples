using System;
using System.Collections.Generic;
using System.Text;

public abstract class Binary : Document
{
    public int? Size { get; protected set; }
    public override void LoadProperty(string key, string value)
    {
        if (key =="size")
        {
            this.Size = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("size", this.Size));
    }
}

