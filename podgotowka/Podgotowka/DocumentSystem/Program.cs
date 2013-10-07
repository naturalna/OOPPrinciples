using System;
using System.Collections.Generic;

public class DocumentSystem
{
    private static IList<IDocument> allDocs = new List<IDocument>();
    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();//4ete whodyt ot bgcoder,wry6ta tekst s komandite te sa red po red
        ExecuteCommands(allCommands);//izpylnqwa komandite
    }
    //tozi list pazim cqlata informaciq koqto da izleze na ekrana
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
        AddDocument(new TextDocument(), attributes);
    }

    private static void AddPdfDocument(string[] attributes)
    {
        AddDocument(new PDF(), attributes);
    }

    private static void AddWordDocument(string[] attributes)
    {
        AddDocument(new Word(), attributes);
    }

    private static void AddExcelDocument(string[] attributes)
    {
        AddDocument(new Excel(), attributes);
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AddDocument(new Audio(), attributes);
    }

    private static void AddVideoDocument(string[] attributes)
    {
        AddDocument(new Video(), attributes);
    }

    private static void ListDocuments()
    {
        if (allDocs.Count > 0)
        {
            foreach (var doc in allDocs)
            {
                Console.Write(doc);
                //ToString mi izpiswa key=value i [] 
            }
        }
        else
        {
            Console.WriteLine("No documents found");
        }
    }

    private static void EncryptDocument(string name)
    {
        bool docFound = false;
        foreach (var doc in allDocs)
        {
            if (doc.Name == name)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    Console.WriteLine("Document encrypted: {0}",name );
                    docFound = true;
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: {0}",name);
                    docFound = true;
                }
            }
        }
        if (docFound == false)
        {
            Console.WriteLine("Document not found: {0}",name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool docFound = false;
        foreach (var doc in allDocs)
        {
            if (doc.Name == name)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Decrypt();
                    Console.WriteLine("Document decrypted: {0}", name);
                    docFound = true;
                }
                else
                {
                    Console.WriteLine("Document does not support decryption: {0}", name);
                    docFound = true;
                }
            }
        }
        if (docFound == false)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void EncryptAllDocuments()
    {
        foreach (var doc in allDocs)
        {
            if (doc is IEncryptable)
            {
                ((IEncryptable)doc).Encrypt();
            }
        }
        Console.WriteLine("All documents encrypted");
    }

    private static void ChangeContent(string name, string content)
    {
        foreach (var doc in allDocs)
        {
            if (doc.Name == name)
            {
                ((IEditable)doc).ChangeContent(content);
            }
        }
    }
    //Idocument-kakyw dokument da dobawq w sisykyt
    //realnoto inicializirane stawa po wreme na dobawqneto na dokumenta
    //tuk se splitwa po = i se podawat key i value 
    private static void AddDocument(IDocument document, string[] attributes)
    {
        //pslitwam edin po edin podawam atributite
        foreach (var abtr in attributes)
        {
            string[] separateAtr = abtr.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            document.LoadProperty(separateAtr[0], separateAtr[1]);
        }
        if (document.Name == null)
        {
            Console.WriteLine("Document has no name");
        }
        else
        {
            allDocs.Add(document);
            Console.WriteLine("Document added: {0}",document.Name);
        }
    }
}