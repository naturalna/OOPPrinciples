using System;

public interface ICommentable
{
    // method that gives permision to the class to give comments
    void Comment(string text);
    string SayComment();
}

