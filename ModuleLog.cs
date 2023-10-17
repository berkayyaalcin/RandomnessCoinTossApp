using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RandomnessCoinTossApp
{
    class ModuleLog
    {
        string _logDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string _logOutputFileName = "OutputLog.txt";
        string _logErrorFileName = "ErrorLog.txt";

        public ModuleLog()
        {
            _logDirectory += "Logs";

            if (!Directory.Exists(_logDirectory))
            {
                Directory.CreateDirectory(_logDirectory);
            }

            
        }

        public void OutputLog(int attempts, int heads, int tails, double finalAtttempts)
        {
            if (!File.Exists(Path.Combine(_logDirectory, _logErrorFileName)))
                File.Create(Path.Combine(_logDirectory, _logOutputFileName));

            DateTime now = DateTime.Now;

            string outputLogMessage = $"{now} - Deneme: {attempts} - Yazı: {heads} - Tura: {tails} - Atış: {finalAtttempts}\n";

            File.AppendAllText(Path.Combine(_logDirectory, _logOutputFileName), outputLogMessage);
        }

        public void ErrorLog(Exception ex)
        {
            if(!File.Exists(Path.Combine(_logDirectory, _logErrorFileName)))
                File.Create(Path.Combine(_logDirectory, _logErrorFileName));

            DateTime now = DateTime.Now;

            string errorLogMessage = $"{now} - Uygulamada {ex} oluştu. Lütfen Kontrol ediniz.\n";

            File.AppendAllText(Path.Combine(_logDirectory, _logErrorFileName), errorLogMessage);

        }
    }
}