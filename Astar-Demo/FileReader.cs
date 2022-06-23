namespace Astar_Demo
{
    public class FileReader
    {
        public string ReadFile(string location)
        {
            return System.IO.File.ReadAllText(location);
        }
        
        
    }
}
