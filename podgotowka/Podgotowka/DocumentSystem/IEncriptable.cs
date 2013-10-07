using System;
using System.Collections.Generic;
using System.Text;


    public interface IEncryptable
    {
        bool IsEncrypted { get; }
        void Encrypt();
        void Decrypt();

    }

