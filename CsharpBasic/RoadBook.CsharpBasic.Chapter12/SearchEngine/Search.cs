using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine
{
    public class Search
    {
        private static char directorySeparator = System.IO.Path.DirectorySeparatorChar;
        string _indexDirectoryPath = Environment.CurrentDirectory + directorySeparator + "indexer";

        Lucene.Net.Store.Directory _directory;
        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;
        Lucene.Net.Analysis.Analyzer _analyzer;

        public Search()
        {
            _directory = Lucene.Net.Store.FSDirectory.Open(new System.IO.DirectoryInfo(_indexDirectoryPath));
            _analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(luceneVersion);
        }

        public void run(string q)
        {
            string[] fields = new string[] { "TITLE", "CONTENT", "TAG", "REPLY_COMMENT" };

            Lucene.Net.Index.IndexReader indexReader = Lucene.Net.Index.IndexReader.Open(_directory, true);
            Lucene.Net.Search.Searcher indexSearch = new Lucene.Net.Search.IndexSearcher(indexReader);

            var queryParser = new Lucene.Net.QueryParsers.MultiFieldQueryParser(luceneVersion, fields, _analyzer);
            
            var query = queryParser.Parse(q);
            
            Console.WriteLine("[검색어] {0}", q);

            Lucene.Net.Search.TopDocs resultDocs = indexSearch.Search(query, indexReader.MaxDoc);

            var hits = resultDocs.ScoreDocs;

            int currentRow = 0;
            foreach (var hit in hits)
            {
                var documentFromSearch = indexSearch.Doc(hit.Doc);
                Console.WriteLine("* Result {0}", ++currentRow);
                Console.WriteLine("\t-제목 : {0}", documentFromSearch.Get("TITLE"));
                Console.WriteLine("\t-내용 : {0}", documentFromSearch.Get("CONTENT"));
                Console.WriteLine("\t-글쓴이 : {0}", documentFromSearch.Get("WRITER_NAME"));
                Console.WriteLine("\t-태그 : {0}", documentFromSearch.Get("TAG"));
                Console.WriteLine("\t-댓글 : {0}", documentFromSearch.Get("REPLY_COMMENT"));
            }

            Console.WriteLine();
        }
    }
}
