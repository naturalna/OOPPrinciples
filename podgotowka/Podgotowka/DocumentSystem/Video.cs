﻿using System;
using System.Collections.Generic;
using System.Text;


public class Video : MultyMedia
{
    public int? FrameRate { get; set; }
    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = int.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        //zapiswa swoite i wika bazowiqt da si zapi6e negowite      
    }
}

