using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine
{
    public class Index
    {
        private static char directorySeparator = System.IO.Path.DirectorySeparatorChar;
        string _indexDirectoryPath = Environment.CurrentDirectory + directorySeparator + "indexer";

        Lucene.Net.Util.Version luceneVersion = Lucene.Net.Util.Version.LUCENE_30;

        System.Collections.Generic.List<Lucene.Net.Documents.Document> _docs;
        Lucene.Net.Store.Directory _directory;
        Lucene.Net.Analysis.Analyzer _analyzer;

        private Manager.XmlManager _xmlManager;

        public Index()
        {
            _xmlManager = new Manager.XmlManager(Manager.XmlManager.USE_TYPE.READ);
        }

        public void run()
        {
            List<Model.Board> boardList = _xmlManager.readXML();

            _docs = new List<Lucene.Net.Documents.Document>();
            foreach (var board in boardList)
            {
                var data = new Lucene.Net.Documents.Document();
                data.Add(new Lucene.Net.Documents.Field("IDX", board.IDX.ToString(), Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("TITLE", board.TITLE, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("CONTENT", board.CONTENT, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("WRITER_NAME", board.WRITER_NAME, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("CREATE_DATE", board.CREATE_DATE.ToString(), Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("TAG", board.TAG, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("CATEGORY_NAME", board.CATEGORY_NAME, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("REPLY_COMMENT", board.REPLY_COMMENT, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.ANALYZED));
                data.Add(new Lucene.Net.Documents.Field("REPLY_WRITER", board.REPLY_WRITER, Lucene.Net.Documents.Field.Store.YES, Lucene.Net.Documents.Field.Index.NOT_ANALYZED));

                _docs.Add(data);
            }

            _directory = Lucene.Net.Store.FSDirectory.Open(new System.IO.DirectoryInfo(_indexDirectoryPath));

            _analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(luceneVersion);
            
            using (var writer = new Lucene.Net.Index.IndexWriter(_directory, _analyzer, true, Lucene.Net.Index.IndexWriter.MaxFieldLength.LIMITED))
            {
                foreach (var doc in _docs)
                {
                    writer.AddDocument(doc);
                }
                writer.Optimize();
            }
        }
    }
}
