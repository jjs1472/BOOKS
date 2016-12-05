using System;
using System.IO;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Search;
using Lucene.Net.Documents;
using Lucene.Net.Store;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.QueryParsers;

namespace RoadBook.CsharpBasic.Chapter12.Examples
{
    public class LuceneBasic
    {
        string indexPath = Environment.CurrentDirectory + "\\LuceneIndex";
        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;
        
        System.Collections.Generic.List<Document> _docs;
        Lucene.Net.Store.Directory _directory;
        Analyzer _analyzer;

        public void run()
        {
            crawl();
            index();

            search("csharp");
            search("programming");
        }

        private void crawl()
        {
            System.Collections.Generic.List<Book> bookList = new System.Collections.Generic.List<Book>()
            {
                new Book { ID = "P001", TITLE = "Csharp Programming Basic", DESCRIPTION = "C# 초급자들을 위한 기본서", PRICE = 35000 },
                new Book { ID = "P002", TITLE = "Csharp Programming Advance", DESCRIPTION = "C# 고급자들을 위한 고급기술 서적", PRICE = 40000 },
                new Book { ID = "P003", TITLE = "Java Programming With Lambda", DESCRIPTION = "Lambda Expression을 이용한 자바 프로그래밍", PRICE = 27000 },
                new Book { ID = "P004", TITLE = "Data Science With Python", DESCRIPTION = "파이썬을 이용한 데이터 사이언스", PRICE = 48000 },
                new Book { ID = "P005", TITLE = "Apache Lucene", DESCRIPTION = "검색엔진 구축을 위한 Lucene", PRICE = 25000 },
                new Book { ID = "P006", TITLE = "MS-SQL Database Management", DESCRIPTION = "MS-SQL 관리", PRICE = 32000 }
            };

            _docs = new System.Collections.Generic.List<Document>();
            foreach (var book in bookList)
            {
                var data = new Document();
                data.Add(new Field("ID", book.ID, Field.Store.YES, Field.Index.NOT_ANALYZED));
                data.Add(new Field("TITLE", book.TITLE, Field.Store.YES, Field.Index.ANALYZED));
                data.Add(new Field("DESCRIPTION", book.DESCRIPTION, Field.Store.YES, Field.Index.NOT_ANALYZED));
                data.Add(new Field("PRICE", book.PRICE.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));

                _docs.Add(data);
            }
        }

        private void index()
        {
            _directory = FSDirectory.Open(new DirectoryInfo(indexPath));

            _analyzer = new StandardAnalyzer(luceneVersion);

            using (var writer = new IndexWriter(_directory, _analyzer, true, IndexWriter.MaxFieldLength.LIMITED))
            {
                foreach (var doc in _docs)
                {
                    writer.AddDocument(doc);
                }
                writer.Optimize();
            }
        }

        private void search(string q)
        {
            IndexReader indexReader = IndexReader.Open(_directory, true);
            Searcher indexSearch = new IndexSearcher(indexReader);

            var queryParser = new QueryParser(luceneVersion, "TITLE", _analyzer);
            var query = queryParser.Parse(q);

            Console.WriteLine("[검색어] {0}", query);
            
            TopDocs resultDocs = indexSearch.Search(query, indexReader.MaxDoc);

            var hits = resultDocs.ScoreDocs;

            int currentRow = 0;
            foreach (var hit in hits)
            {
                var documentFromSearch = indexSearch.Doc(hit.Doc);
                Console.WriteLine("* Result {0}", ++currentRow);
                Console.WriteLine("\t-도서명 : {0}", documentFromSearch.Get("TITLE"));
                Console.WriteLine("\t-요약 : {0}", documentFromSearch.Get("DESCRIPTION"));
                Console.WriteLine("\t-가격 : {0}", documentFromSearch.Get("PRICE"));
            }

            Console.WriteLine();
        }
    }

    public class Book
    {
        /// <summary>
        /// 도서 고유번호
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 도서명
        /// </summary>
        public string TITLE { get; set; }
        /// <summary>
        /// 요약
        /// </summary>
        public string DESCRIPTION { get; set; }
        /// <summary>
        /// 가격
        /// </summary>
        public int PRICE { get; set; }
    }
}
