using System;
using System.IO;

namespace DVLD_DataAccessLayer
{
    internal class LoggingHelper
    {
        public static void LogError(Exception ex, string ErrorStream)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string logFolderPath = Path.Combine(appPath, "logs");

            if (!Directory.Exists(logFolderPath))
                Directory.CreateDirectory(logFolderPath);

            string logFilePath = Path.Combine(logFolderPath, ErrorStream + ".txt");
            string logMessage = $"[{DateTime.Now}] {ex}\n\n-------------------------------------------------------------------------------------\n\n";

            File.AppendAllText(logFilePath, logMessage);
        }
    }
}
