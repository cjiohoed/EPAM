using System;
using System.IO;

namespace Task2
{
    public class Watcher
    {
        private string _format = "yyyyMMdd_hhmmss";
        private string _fileMask = "*.txt";
        private string _dirMask = "*";

        private ILoggable logger;

        private FileSystemWatcher myWatcher;
        private static string _dir;
        private static string _bkpDir;

        public string BkpDir
        {
            get
            {
                return _bkpDir;
            }

            set
            {
                if (!Directory.Exists(value))
                {
                    Directory.CreateDirectory(value);
                }

                _bkpDir = value;
            }
        }

        public string Dir
        {
            get
            {
                return _dir;
            }

            set
            {
                if (!Directory.Exists(value))
                {
                    throw new Exception("Directory not exists");
                }

                _dir = value;
            }
        }

        public Watcher(string dir, ILoggable logger)
        {
            Dir = dir;
            var parent = new DirectoryInfo(Dir).Parent.FullName;
            BkpDir = Path.Combine(parent, ".bkp");
            this.logger = logger;

        }

        private void Init()
        {
            myWatcher = new FileSystemWatcher
            {
                IncludeSubdirectories = true,
                Path = _dir,
                NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = _fileMask
            };

            myWatcher.Changed += OnChanged;
            myWatcher.Created += OnCreated;
            myWatcher.Deleted += OnDeleted;
            myWatcher.Renamed += OnRenamed;
        }

        public void Start()
        {
            Init();
            myWatcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            CopyAllTextFiles(_dir, GetBackupPath(DateTime.Now.ToString(_format)));
            logger.LogMessage($"Файл {e.Name} изменен.");
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            CopyAllTextFiles(_dir, GetBackupPath(DateTime.Now.ToString(_format)));
            logger.LogMessage($"Файл {e.Name} создан.");
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            CopyAllTextFiles(_dir, GetBackupPath(DateTime.Now.ToString(_format)));
            logger.LogMessage($"Файл {e.Name} удален.");
        }

        private void OnRenamed(object sender, FileSystemEventArgs e)
        {
            CopyAllTextFiles(_dir, GetBackupPath(DateTime.Now.ToString(_format)));
            logger.LogMessage($"Файл {e.Name} переименован.");
        }

        private string GetBackupPath(string date)
        {
            return Path.Combine(_bkpDir, date);
        }

        private void CopyAllTextFiles(string source, string destination)
        {
            Directory.CreateDirectory(destination);

            foreach (string dir in Directory.GetDirectories(source, _dirMask, SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dir.Replace(source, destination));
            }

            foreach (string path in Directory.GetFiles(source, _fileMask, SearchOption.AllDirectories))
            {
                File.Copy(path, path.Replace(source, destination), true);
            }
        }

        private void DeleteFiles(string path)
        {
            foreach (string file in Directory.GetFiles(path, _fileMask, SearchOption.AllDirectories))
            {
                File.Delete(file);
            }
        }

        public string[] GetBackups()
        {
            return Directory.GetDirectories(_bkpDir, "*", SearchOption.TopDirectoryOnly);
        }

        public void Restore(string selectBackup)
        {
            DeleteFiles(_dir);

            selectBackup = Path.Combine(_bkpDir, selectBackup);
            if (Directory.Exists(selectBackup))
            {
                CopyAllTextFiles(selectBackup, _dir);
                logger.LogMessage($"Бэкап восстановлен.");
            }
            else
            {
                throw new ArgumentException("Incorrect backup name");
            }
        }

    }
}
