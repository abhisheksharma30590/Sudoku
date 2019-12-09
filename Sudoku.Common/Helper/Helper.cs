using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Common.Helper
{
    public static class Helper
    {
        public static List<T> XMLToList<T>(string xmlFile) where T : class, new()
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(xmlFile);
                return ds.Tables[0].DataTableToList<T>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
