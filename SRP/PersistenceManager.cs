namespace SRP
{
    public class PersistenceManager
    {
        public static void SaveToFile(List<string> tasks, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, string.Join("\n", tasks));
        }
    }
}
