using System;

[AttributeUsage(AttributeTargets.Enum|AttributeTargets.Class|AttributeTargets.Constructor|
 AttributeTargets.Interface|AttributeTargets.Method,AllowMultiple = false)]
public class VersionAttribute : System.Attribute
{
    private string major;
    public string Major
    {
        get { return this.major; }
        set { this.major = value; }
    }
    private string minor;
    public string Minor
    {
        get { return this.minor; }
        set { this.minor = value; }
    }
    public VersionAttribute(string majorNum, string minorNum)
    {
        this.Major = majorNum;
        this.Minor = minorNum;
    }
}
