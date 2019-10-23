﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Lmf.Util.Algorithm
{
    public class HashAlgorithm
    {
        public static long hash(byte[] digest, int nTime)
        {
            long rv = ((long)(digest[3 + nTime * 4] & 0xFF) << 24)
                    | ((long)(digest[2 + nTime * 4] & 0xFF) << 16)
                    | ((long)(digest[1 + nTime * 4] & 0xFF) << 8)
                    | ((long)digest[0 + nTime * 4] & 0xFF);
            return rv & 0xffffffffL; /* Truncate to 32-bits */
        }
        /**
         * Get the md5 of the given key.
         */
        public static byte[] computeMd5(string k)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            byte[] keyBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(k));
            md5.Clear();
            //md5.update(keyBytes);
            //return md5.digest();
            return keyBytes;
        }
    }
}
