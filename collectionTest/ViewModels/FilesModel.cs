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
        public ObservableCollection<FileLike> AllFiles { get; set; }
        public SelectionMode SelectionMode = SelectionMode.Single;
        public ObservableCollection<FileLike> SelectedItems = new ObservableCollection<FileLike>();
        public string CurrentDirectory { get; set; }

        public FilesModel()
        {
            AllFiles = new ObservableCollection<FileLike>();
            var r = new Random();
            for (int i = 0; i < 50; i++)
            {
                AllFiles.Add(new FileLike("File", "File" + i, r.Next(1000)));
            }
            CurrentDirectory = "/home/user";
        }
    }
}
