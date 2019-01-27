using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {

            DataSet dataSet = new DataSet("libaryDataBase");
            DataTable authorTable = new DataTable("author");
            DataColumn authorIdColumn = new DataColumn();
            authorIdColumn.AutoIncrementSeed = 1;
            authorIdColumn.AutoIncrementStep = 1;
            authorIdColumn.AutoIncrement = true;
            authorIdColumn.Unique = true;
            authorIdColumn.ColumnName = "id";
            authorIdColumn.DataType = typeof(int);
            authorTable.Columns.Add(authorIdColumn);

            DataColumn authorNameColumn = new DataColumn("FullName");
            authorNameColumn.DataType = typeof(string);
            authorTable.Columns.Add(authorNameColumn);


            DataTable bookTable = new DataTable("books");
            DataColumn bookIdColumn = new DataColumn();
            bookIdColumn.AutoIncrementSeed = 1;
            bookIdColumn.AutoIncrementStep = 1;
            bookIdColumn.AutoIncrement = true;
            bookIdColumn.Unique = true;
            bookIdColumn.ColumnName = "id";
            bookIdColumn.DataType = typeof(int);
            bookTable.Columns.Add(bookIdColumn);

            DataColumn bookNameColumn = new DataColumn("Name");
            bookNameColumn.DataType = typeof(string);
            bookTable.Columns.Add(bookNameColumn);

            DataColumn bookAuthorIdColumn = new DataColumn("AuthorId");
            bookAuthorIdColumn.DataType = typeof(int);

            DataRelation dataRelation = new DataRelation("BookAuthorFK", "author", "books", new string[] { "id" }, new string[] { "AuthorId" }, false);
        }
    }
}
