using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace RoadBook.CsharpBasic.Chapter12.SearchEngine.Manager
{
    public class XmlManager
    {
        public enum USE_TYPE { WRITE, READ };

        private XDocument _xDoc;

        private static char directorySeparator = System.IO.Path.DirectorySeparatorChar;
        private static string crawlDirectoryPath = Environment.CurrentDirectory + directorySeparator + "crawled";

        public XmlManager(USE_TYPE useType)
        {
            switch (useType)
            {
                case USE_TYPE.WRITE:
                    if (System.IO.Directory.Exists(crawlDirectoryPath))
                    {
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(crawlDirectoryPath);

                        foreach (var file in di.GetFiles())
                        {
                            file.MoveTo(crawlDirectoryPath + directorySeparator + "backup" + directorySeparator + file.Name);
                        }
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(crawlDirectoryPath);
                        System.IO.Directory.CreateDirectory(crawlDirectoryPath + directorySeparator + "backup");
                    }

                    _xDoc = new XDocument(
                                new XDeclaration("1.0", "utf-8", null), 
                                new XElement("result"));
                    break;
                case USE_TYPE.READ:
                    if (System.IO.Directory.Exists(crawlDirectoryPath))
                    {
                        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(crawlDirectoryPath);
                        System.IO.FileInfo[] fi = di.GetFiles();

                        if (fi.Length > 0)
                        {
                            _xDoc = XDocument.Load(fi[0].FullName);
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        public void writeXML(Model.Board board)
        {
            _xDoc.Element("result").Add(
                new XElement("row", 
                    new XElement("idx", board.IDX),
                    new XElement("title", new XCData(board.TITLE)),
                    new XElement("content", new XCData(board.CONTENT)),
                    new XElement("writer_name", new XCData(board.WRITER_NAME)),
                    new XElement("create_date", board.CREATE_DATE),
                    new XElement("modify_date", board.MODIFY_DATE),
                    new XElement("tag", new XCData(board.TAG)),
                    new XElement("category_name", new XCData(board.CATEGORY_NAME)),
                    new XElement("reply_comment", new XCData(board.REPLY_COMMENT)),
                    new XElement("reply_writer", new XCData(board.REPLY_WRITER))
                ));
        }

        public List<Model.Board> readXML()
        {
            return _xDoc.Descendants("row").Select(s => new Model.Board()
            {
                IDX = Convert.ToInt32(s.Element("idx").Value),
                TITLE = s.Element("title").Value,
                CONTENT = s.Element("content").Value,
                WRITER_NAME = s.Element("writer_name").Value,
                CREATE_DATE = Convert.ToDateTime(s.Element("create_date").Value),
                TAG = s.Element("tag").Value,
                CATEGORY_NAME = s.Element("category_name").Value,
                REPLY_COMMENT = s.Element("reply_comment").Value,
                REPLY_WRITER = s.Element("reply_writer").Value
            }).ToList();
        }

        public void saveXML()
        {
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".xml";

            _xDoc.Save(crawlDirectoryPath + directorySeparator + filename);
        }
    }
}
