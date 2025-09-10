namespace StrHelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "AUEB";
            string str2 = "  Athens University of Economics and Business  ";

            string upper  = str1.ToUpper();
            string lower = str1.ToLower();
            string trimmed = str2.Trim();
            string replaced = str1.Replace("AUEB", "Athens University of Economics and Business");
            string substring = str1.Substring(0, 2);    
            string[] split = str2.Split(' '); // Split by space
            string joined = string.Join(", ", split); // Join with comma and space  
            bool contains = str1.Contains("AUEB");
            bool startsWith = str1.StartsWith("AUEB");
            bool endsWith = str1.EndsWith("AUEB");  
            int indexOf = str1.IndexOf("UEB");
            int length = str1.Length;   
            string formatted = string.Format("Welcome to {0}", str1);
            string joined2 = string.Concat(str1, " - ", str2);  



        }
    }
}
