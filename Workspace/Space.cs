using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    class Space
    {
        private List<string> files = new List<string>();
        private List<string> folders = new List<string>();
        private List<string> links = new List<string>();

        public List<string> Files
        {
            get { return files; }
        }

        public List<string> Folders
        {
            get { return folders; }
        }

        public List<string> Links
        {
            get { return links; }
        }

        private void AddItem(ref List<string> list, string item)
        {
            list.Add(item);
        }

        private void RemoveItem(ref List<string> list, string item)
        {
            list.Remove(item);
        }

        public void AddFile(string file)
        {
            AddItem(ref files, file);
        }

        public void AddFolder(string folder)
        {
            AddItem(ref folders, folder);
        }

        public void AddLink(string link)
        {
            AddItem(ref links, link);
        }

        public void RemoveFile(string file)
        {
            RemoveItem(ref files, file);
        }

        public void RemoveFolder(string folder)
        {
            RemoveItem(ref folders, folder);
        }

        public void RemoveLink(string link)
        {
            RemoveItem(ref links, link);
        }
    }
}
