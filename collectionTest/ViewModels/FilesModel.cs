using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using collectionTest.Models;


namespace collectionTest.ViewModels
{
    internal class FilesModel
    { 
        public ObservableCollection<ExtendedSftpItem> AllFiles { get; set; }
        public SelectionMode SelectionMode = SelectionMode.Single;
        public ObservableCollection<ExtendedSftpItem> SelectedItems = new ObservableCollection<ExtendedSftpItem>();
        public string CurrentDirectory { get; set; }

        public FilesModel()
        {
            AllFiles = new ObservableCollection<ExtendedSftpItem>();
            var r = new Random();
            for (int i = 0; i < 50; i++)
            {
                AllFiles.Add(new ExtendedSftpItem("File", "File" + i, r.Next(1000)));
            }
            CurrentDirectory = "/home/user";
        }
    }
}
