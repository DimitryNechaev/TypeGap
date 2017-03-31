﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeGap
{
    internal class Resx
    {
        public static string AjaxService => GetResource("AjaxService.ts");

        public static string GeneratedNotice => GetResource("GeneratedNotice.ts");

        private static string GetResource(string path)
        {
            var assy = Assembly.GetExecutingAssembly();
            path = assy.GetName().Name + ".Resources." + path;
            using (var sr = new StreamReader(assy.GetManifestResourceStream(path)))
                return sr.ReadToEnd();
        }

    }
}