namespace Builder_Example.Example2.Realization
{
    public class Report
    {
        public static string Header
        {
            get => _header;
            set => _header = value;
        }
        public static string Title
        {
            get => _title;
            set => _title = value;
        }
        public static string Content
        {
            get => _content;
            set => _content = value;
        }
        public static string Table
        {
            get => _table;
            set => _table = value;
        }
        public static int PageNumber
        {
            get => _pageNumber;
            set => _pageNumber = value;
        }
        
        private static string _header;
        private static string _title;
        private static string _content;
        private static string _table;
        private static int _pageNumber;
        
        public override string ToString()
        {
            return $"Header: {_header}\n " +
                   $"Title: {_title}\n " +
                   $"Content: {_content}\n " +
                   $"Table: {_table}\n " +
                   $"Page number: {_pageNumber}";
        }
        
        public class Builder
        {
            public Builder GetHeader(string header)
            {
                Header = header;
                return this;
            }
            public Builder GetTitle(string title)
            {
                Title = title;
                return this;
            }
            public Builder GetContent(string content)
            {
                Content = content;
                return this;
            }
            public Builder GetTable(string table)
            {
                Table = table;
                return this;
            }
            public Builder GetPageNumber(int pageNumber)
            { 
                PageNumber = pageNumber; 
                return this;
            }
        
            public Report Build()
            {
                return new Report();
            }
        }
    }
}