using SRP;

var taskManager = new TaskManager();
taskManager.AddTask("Thi công PBI");
taskManager.AddTask("Fix Bug");
string executablePath = AppDomain.CurrentDomain.BaseDirectory;
string filePath = Path.GetFullPath(Path.Combine(executablePath, "../../../")) + "/Tasks.txt";
//taskManager.SaveToFile(filePath, true);
PersistenceManager.SaveToFile(taskManager.GetTasks(), filePath, true);