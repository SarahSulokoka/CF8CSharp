using FileManagement.Model;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLList<char> fileList = new();
            GenericNode<char>? node;
            int totalChars = 0;
            string filePath = "C:\\Users\\Sarah\\file.txt";
            char ch;
            int ordinal = 0;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File does not exist.");
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((ordinal = reader.Read()) != -1)
                    { 
                        ch = (char)ordinal;
                        if (ch is '\n' or '\r')
                            continue;

                        node = fileList.FindNode(ch);
                        if (node != null)
                        {
                            node.Count++;
                        }
                        else
                        {
                            fileList.InsertLast(ch);
                        }

                    }
                }
                fileList.Traverse(totalChars);
                fileList.SortByCount();

            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
                return;
            }
        }
    }
}
