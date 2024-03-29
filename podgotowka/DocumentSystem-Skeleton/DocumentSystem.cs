﻿using System;
using System.Collections.Generic;

public interface IDocument
{
	string Name { get; }
	string Content { get; }
	void LoadProperty(string key, string value);
	void SaveAllProperties(IList<KeyValuePair<string, object>> output);
	string ToString();
}

public interface IEditable
{
	void ChangeContent(string newContent);
}

public interface IEncryptable
{
	bool IsEncrypted { get; }
	void Encrypt();
	void Decrypt();
}

public class DocumentSystem
{
    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();//4ete whodyt ot bgcoder,wry6ta tekst s komandite te sa red po red
        ExecuteCommands(allCommands);//izpylnqwa komandite
    }

    private static IList<string> ReadAllCommands()//4ete whodyt dokato stigne do krai
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            //wzima wsi4ko wyw skobite[]
            //cmd e komandata
            //params sa name content i drugite
            ExecuteCommand(cmd, parameters);//izpylnqwa komandata
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        //razdelq parametrite na cwoistwo=sydyrjanie w masiw 
        //primer
        //cmd= AddTestDocumnet cndAtrib=[name=pe6o.txt,
        //                                 content=333,
        //                                         ...,]
        //conamdi add izpylnqwat edno is sy6to.
        //dobawqt document 
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);//wika metodite za koito prawqt komandite sys syotwetnite cmdAttrib -masiwyt
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }
  
    private static void AddTextDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddPdfDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddWordDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddExcelDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddAudioDocument(string[] attributes)
    {
        // TODO
    }

    private static void AddVideoDocument(string[] attributes)
    {
        // TODO
    }

    private static void ListDocuments()
    {
        // TODO
    }

    private static void EncryptDocument(string name)
    {
        // TODO
    }

    private static void DecryptDocument(string name)
    {
        // TODO
    }

    private static void EncryptAllDocuments()
    {
        // TODO
    }

    private static void ChangeContent(string name, string content)
    {
        // TODO
    }
}
