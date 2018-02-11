﻿#region Copyright
/* The MIT License (MIT)

Copyright (c) 2014 Anderson Luiz Mendes Matos (Brazil)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion Copyright

using DataTables.AspNet.Mvc5;

namespace DataTables.AspNet.Extensions.DapperExtensions.Tests
{
    public static class TestHelper
    {
        public static Core.IColumn MockColumn(string columnName, string columnField, bool searchable, bool sortable, string searchValue, bool searchRegex)
        { return new Column(columnName, columnField, searchable, sortable, TestHelper.MockSearch(searchValue, searchRegex)); }
        public static Core.IOptions MockOptions()
        { return new Options(); }
        public static Core.ISearch MockSearch(string searchValue, bool isRegex)
        { return new Search(searchValue, isRegex); }
        public static Core.ISort MockSort(string field, int order, string direction)
        { return new Sort(field, order, direction); }
    }



    public class SampleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
