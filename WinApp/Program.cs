﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinApp.WinForm;
using System.Threading;
using System.Reflection;
using Message.Model;

namespace WinApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (SingleInstance.CreateMutex())
            {
                Application.Run(new MainForm());
                SingleInstance.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("程序已经运行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public static class SingleInstance
        {
            private static Mutex mutex = null;

            public static bool CreateMutex()
            {
                return CreateMutex(Assembly.GetEntryAssembly().FullName);
            }

            public static bool CreateMutex(string name)
            {
                bool result = false;
                mutex = new Mutex(true, name, out result);
                return result;
            }

            public static void ReleaseMutex()
            {
                if (mutex != null)
                {
                    mutex.Close();
                }
            }
        }
    }
}
