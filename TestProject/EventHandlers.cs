using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSArcLib
{
    public delegate void ListCommandEventHandler(ListCommandEventArgs e);
    public delegate void CreateCommandEventHandler(CreateCommandEventArgs e);
    public delegate void ExtractCommandEventHandler(ExtractCommandEventArgs e);
    public delegate void ProgressUpdateEventHandler(ProgressUpdateEventArgs e);

    public class ListCommandEventArgs
    {
        public string Message { get; set; }
        public ICollection<string> FileList { get; set; }

        public ListCommandEventArgs(string msg)
        {
            Message = msg;
        }

        public ListCommandEventArgs(string msg, ICollection<string> fileList) : this(msg)
        {
            FileList = fileList;
        }
    }

    public class CreateCommandEventArgs
    {
        public string Message { get; set; }

        public CreateCommandEventArgs(string msg)
        {
            Message = msg;
        }
    }

    public class ExtractCommandEventArgs
    {
        public string Message { get; set; }

        public ExtractCommandEventArgs(string msg)
        {
            Message = msg;
        }
    }

    public class ProgressUpdateEventArgs
    {
        public int CompletedItems { get; set; }
        public int TotalItems { get; set; }
        public string Message { get; set; }

        public ProgressUpdateEventArgs(string msg, int itemsComplete, int itemsTotal)
        {
            CompletedItems = itemsComplete;
            TotalItems = itemsTotal;
            Message = msg;
        }
    }
}
