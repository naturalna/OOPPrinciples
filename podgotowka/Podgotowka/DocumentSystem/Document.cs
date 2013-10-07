using System;
using System.Collections.Generic;
using System.Text;


public abstract class Document : IDocument
{
    //fields
    private string name;
    private string content;
    //prop
    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }
    public string Content
    {
        get { return this.content; }
       protected set { this.content = value; }
    }
    //methods
    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value; 
        }
        else
        {
            throw new ArgumentException("No such property");
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name",this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }
    public override string ToString()
    {
        List<KeyValuePair<string, object>> properties =
            new List<KeyValuePair<string, object>>();
        this.SaveAllProperties(properties);
        properties.Sort((a, b) => a.Key.CompareTo(b.Key));
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append("[");
        bool first = true;
        foreach (var prop in properties)
        {
            if (prop.Value != null)
            {
                if (!first)
                {
                    result.Append(";");
                }
                result.AppendFormat("{0}={1}", prop.Key, prop.Value);
                first = false;
            }
        }
        result.Append("]");
        return result.ToString();
    }
}

