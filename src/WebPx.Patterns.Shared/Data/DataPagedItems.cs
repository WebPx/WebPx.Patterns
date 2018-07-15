using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebPx.Data
{
    [Serializable]
    public class DataPagedItems<T>
    {
        public DataPagedItems(IEnumerable<T> tuples = null, int totalRowCount = 0)
        {
            this.Tuples = tuples;
            this.TotalRowCount = totalRowCount;
        }

        [XmlElement]
        public IEnumerable<T> Tuples { get; set; }

        [XmlAttribute]
        public int TotalRowCount { get; set; }
    }

    public static class DataPagedItems
    {
        public static DataPagedItems<T> Execute<T>(this IQueryable<T> query, int startRowIndex = 0, int maximumRows = 0)
        {
            if (query == null)
                throw new ArgumentNullException(nameof(query));
            int count = query.Count();
            if (startRowIndex > 0)
                query = query.Skip(startRowIndex);
            if (maximumRows > 0)
                query = query.Take(maximumRows);
            return new DataPagedItems<T>(query.ToArray(), count);
        }
    }
}
