using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Files
{
    public class xCode
    {
        public delegate void percent(double cent);
        public bool CopyFile(string fromPath, string toPath, int eachReadLength, percent p)
        {
            int toCopyLength = 0;
            FileStream fromFile, toFile;
            try {
                fromFile = new FileStream(fromPath, FileMode.Open, FileAccess.Read);
            }
            catch {
                return false; 
            }
            try
            {
                toFile = new FileStream(toPath, FileMode.Append, FileAccess.Write);
            }
            catch
            {
                fromFile.Close();
                return false;
            }
            try {
                if (eachReadLength < fromFile.Length)
                {
                    byte[] buffer = new byte[eachReadLength];
                    long copied = 0;
                    while (copied <= fromFile.Length - eachReadLength)
                    {
                        toCopyLength = fromFile.Read(buffer, 0, eachReadLength);
                        fromFile.Flush();
                        toFile.Write(buffer, 0, eachReadLength);
                        toFile.Flush();
                        toFile.Position = fromFile.Position;

                        p((fromFile.Length - eachReadLength)/copied);

                        copied += toCopyLength;
                    }
                    int left = (int)(fromFile.Length - copied);
                    toCopyLength = fromFile.Read(buffer, 0, left);
                    fromFile.Flush();
                    toFile.Write(buffer, 0, left);
                    toFile.Flush();
                    p(1);
                }
                else
                {
                    byte[] buffer = new byte[fromFile.Length];
                    fromFile.Read(buffer, 0, buffer.Length);
                    fromFile.Flush();
                    toFile.Write(buffer, 0, buffer.Length);
                    toFile.Flush();
                    p(1);
                }
            } catch {
                try { fromFile.Close(); } catch { }
                try { toFile.Close(); } catch { }
                return false;
            }
            fromFile.Close();
            toFile.Close();
            return true;
        }
    }
}
