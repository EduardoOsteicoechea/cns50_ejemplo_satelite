using System.Collections.Generic;

namespace GestProjectManager.Data
{
    internal class CreateSelectSQLCommandString
    {
        public string CommandString { get; set; }
        public CreateSelectSQLCommandString(
            List<string> columnNames, 
            string filterValueColumn = null, 
            string tableName = "", 
            string filterMode = ""
        )
        {
            string columnList = string.Join(", ", columnNames);

            if(filterMode == "AllDates" || filterValueColumn == null)
            {
                CommandString = $"SELECT {columnList} FROM {tableName}";
            } 
            else
            {
                CommandString = $"SELECT * FROM {tableName} ";
                CommandString += $"WHERE({filterValueColumn} >= {ValueHolder.FilterStartDate.ToString().Split(' ')[0]} AND {filterValueColumn} <= {ValueHolder.FilterEndDate.ToString().Split(' ')[0]}) ";
                CommandString += $"OR {filterValueColumn} IS NULL";
            };
        }
    }
}
