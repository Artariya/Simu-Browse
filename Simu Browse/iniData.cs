﻿using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Simu_Browse
{
    class iniData
    {
        private static readonly string iniFilePath = "settings.ini";

        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static long WriteData(string section, string key, string data)
        {
            return WritePrivateProfileString(section, key, data, Path.Combine(Application.StartupPath, iniFilePath));
        }
        public static string ReadData(string section, string key, string defaultValue = null)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, defaultValue, temp, 255, Path.Combine(Application.StartupPath, iniFilePath));
            return temp.ToString();
        }
    }
}
