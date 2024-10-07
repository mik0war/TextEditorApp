using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorApp.domain
{
    public interface PathFormatter
    {

        string Format(string path);

        public class Base : PathFormatter
        {
            public string Format(string path)
            {
                string[] pathParts = path.Split('.');

                if (pathParts.Length < 2)
                {
                    throw new ArgumentException("Illegal path (no extension)");
                }

                int extensionIndex = pathParts.Length - 1;
                int lastNamePart = pathParts.Length - 2;

                if (Regex.IsMatch(path, "^.*\\([0-9]+\\)\\..*$"))
                {
                    string[] parts = pathParts[lastNamePart].Split("(");
                    parts[parts.Length - 1] = 
                        parts[parts.Length - 1].Substring(0, parts[parts.Length - 1].Length - 1);
                    int number = Int32.Parse(parts[parts.Length - 1]);

                    parts[parts.Length-1] = "(" + (number+1) + ")";
                    pathParts[lastNamePart] = string.Join("", parts);
                }
                else
                {
                    pathParts[lastNamePart] = pathParts[lastNamePart] + "(1)";
                }
                pathParts[extensionIndex] = "." + pathParts[extensionIndex];

                return string.Join("", pathParts);


            }
        }
    }
}
