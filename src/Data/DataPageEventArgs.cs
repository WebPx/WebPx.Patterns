using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPx.Data
{
    public sealed class DataPageEventArgs : EventArgs
    {
        public DataPageEventArgs(int startRowIndex = 0, int maximumRows = 0)
        {
            this.StartRowIndex = startRowIndex;
            this.MaximumRows = maximumRows;
        }

        public int StartRowIndex { get; private set; }
        public int MaximumRows { get; private set; }

        public new static readonly DataPageEventArgs Empty = new DataPageEventArgs();
    }
}
