﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyAspNetCoreDemo.Services
{
    public interface IEncryptionService
    {
        string Encrypt(string input);

        string Decrypt(string cipherText);
    }
}
