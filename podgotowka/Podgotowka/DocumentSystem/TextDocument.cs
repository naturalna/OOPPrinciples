using System;
using System.Collections.Generic;
using System.Text;


public class TextDocument : Document, IEditable
{
    private string charset;
    public string Charset
    {
        get{ return this.charset;}
        set{ this.charset = value;}
    }
    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }
    public override void LoadProperty(string key, string value)
    {
        if (key == "charset")
        {
            this.Charset = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }
    //zapiswam w listyt kakwo protyrti sym namerila i inicializirala 
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string,object>("charset",this.Charset));
        //zapiswa swoite i wika bazowiqt da si zapi6e negowite
        base.SaveAllProperties(output);
    }
}

