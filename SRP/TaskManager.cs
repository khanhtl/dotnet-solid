namespace SRP
{
    public class TaskManager
    {
        private readonly List<string> tasks = new();
        private static int count = 0;
        public void AddTask(string text)
        {
            tasks.Add($"{++count}: {text}");
        }
        public void RemoveTask(int index)
        {
            tasks.RemoveAt(index);
        }
        public List<string> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// Violate SRP
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="overwrite"></param>
        //public void SaveToFile(string filename, bool overwrite = false)
        //{
        //    if (overwrite || !File.Exists(filename))
        //    {
        //        File.WriteAllText(filename, string.Join("\n", tasks));
        //    }
        //}
    }
}
