using System;
using System.Collections.Generic;
using System.Text;

public class DocumentSystem
{
    private static IList<IDocument> allDocs = new List<IDocument>();
    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }
    private static IList<string> ReadAllCommands()
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
            ExecuteCommand(cmd, parameters);
        }
    }
    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
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
        AddDocument(new PDFDocument(), attributes);
    }
    private static void AddWordDocument(string[] attributes)
    {
        AddDocument(new WordDocument(), attributes);
    }
    private static void AddExcelDocument(string[] attributes)
    {
        AddDocument(new ExcelDocument(), attributes);
    }
    private static void AddAudioDocument(string[] attributes)
    {
        AddDocument(new AudioDocument(), attributes);
    }
    private static void AddVideoDocument(string[] attributes)
    {
        AddDocument(new VideoDocument(), attributes);
    }
    private static void ListDocuments()
    {
        if (allDocs.Count > 0)
        {
            foreach (var doc in allDocs)
            {
                Console.Write(doc);
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
        bool documentFound = false;
        foreach (var doc in allDocs)
        {
            if (doc.Name == name)
            {
                if (doc is IEditable)
                {
                    ((IEditable)doc).ChangeContent(content);
                    Console.WriteLine("Document content changed: " + doc.Name);
                }
                else
                {
                    Console.WriteLine("Document is not editable: " + doc.Name);
                }
                documentFound = true;
            }
        }
        if (!documentFound)
        {
            Console.WriteLine("Document not found: " + name);
        }
    }
    private static void AddDocument(IDocument document, string[] attributes)
    {
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
    public class AudioDocument : MultyMedia
    {
        public int? SampleRate { get; set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "samplerate")
            {
                this.SampleRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
        }
    }
    public abstract class Binary : Document
    {
        public int? Size { get; protected set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
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
    public abstract class Document : IDocument
    {
        private string name;
        private string content;
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
            output.Add(new KeyValuePair<string, object>("name", this.Name));
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
    public class ExcelDocument : OfficeDocument
    {
        public int? RowsNumber { get; protected set; }
        public int? CollsNumber { get; protected set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "rows")
            {
                this.RowsNumber = int.Parse(value);
            }
            else if (key == "cols")
            {
                this.CollsNumber = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("rows", this.RowsNumber));
            output.Add(new KeyValuePair<string, object>("colls", this.CollsNumber));
        }
    }
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
    public abstract class MultyMedia : Binary
    {
        public int? Length { get; protected set; }
        public override void LoadProperty(string key, string value)
        {
            if (key == "length")
            {
                this.Length = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }
    }
    public class PDFDocument : Binary
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
    public class TextDocument : Document, IEditable
    {
        private string charset;
        public string Charset
        {
            get { return this.charset; }
            set { this.charset = value; }
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
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("charset", this.Charset));
            base.SaveAllProperties(output);
        }
    }
    public class VideoDocument : MultyMedia
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
        }
    }
    public class WordDocument : OfficeDocument, IEditable
    {
        public int? Numbercharacters { get; set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.Numbercharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("chars", this.Numbercharacters));
        }
    }
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
}