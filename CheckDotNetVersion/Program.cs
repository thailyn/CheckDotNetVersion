using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDotNetVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"SOFTWARE\Microsoft\NET Framework Setup\NDP";
            List<string> displayFrameworkName = new List<string>();

            RegistryKey installedVersions = Registry.LocalMachine.OpenSubKey(path);
            string[] versionNames = installedVersions.GetSubKeyNames();

            for (int i = 1; i <= versionNames.Length - 1; i++)
            {
                string versionName = versionNames[i].ToString();
                RegistryKey version = installedVersions.OpenSubKey(versionNames[i]);
                System.Console.WriteLine("Microsoft .NET Framework " + versionName);

                System.Console.WriteLine("Key Name: " + version.Name);

                string[] valueNames = version.GetValueNames();
                for (int j = 0; j < valueNames.Length; j++)
                {
                    object value = version.GetValue(valueNames[j]);
                    if (value == null)
                    {
                        System.Console.WriteLine(valueNames[j] + ": null");
                    }
                    else
                    {
                        System.Console.WriteLine(valueNames[j] + ": " + value.ToString());
                    }
                }

                System.Console.WriteLine();
            }

            System.Console.ReadLine();

            //return display_framwork_name;
        }
    }
}
