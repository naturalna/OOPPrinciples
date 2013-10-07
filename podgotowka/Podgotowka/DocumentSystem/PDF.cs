using System;
using System.Collections.Generic;
using System.Text;

public class PDF : Binary
{
    public int? NumberPages { get; protected set; }
    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.NumberPages = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("pages", this.NumberPages));
    }
}

