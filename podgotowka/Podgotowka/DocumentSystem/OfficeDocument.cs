using System;
using System.Collections.Generic;
using System.Text;


public abstract class OfficeDocument : Binary, IEncryptable
{
    public string Version { get; protected set; }
    private bool isEncr = false;
    public bool IsEncrypted
    {
        get { return this.isEncr; }
    }

    public void Encrypt()
    {
        this.isEncr = true;
    }

    public void Decrypt()
    {
        this.isEncr = false;
    }
    public override void LoadProperty(string key, string value)
    {
        if (key == "version")
        {
            this.Version = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("version", this.Version));
    }
}

