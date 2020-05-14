using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ScreenScraper
{
    internal class FileWorker
    {
        public enum Mode
        {
            XML,
            TXT
        };

        private string path = "./OutputData";
        public void Write<T>(T data, Mode mode)
        {
            if (mode == Mode.XML)
            {
                var doc = new XDocument();
                using (var writer = doc.CreateWriter())
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, data);
                }
                doc.Save(path+".xml");
            }
            else if (mode == Mode.TXT)
            {
                using (StreamWriter file = new StreamWriter(path+".txt"))
                {
                    file.WriteLine(data);
                }
            }
            else
                throw new NotImplementedException();
        }
        public void WriteEach<T>(List<T> data, Mode mode)
        {
            if (mode == Mode.XML)
            {
                var doc = new XDocument();
                using (var writer = doc.CreateWriter())
                {
                    foreach(var elT in data)
                    {
                        var serializer = new XmlSerializer(typeof(T));
                        serializer.Serialize(writer, elT);
                    }
                }
                doc.Save(path + ".xml");
            }
            else if (mode == Mode.TXT)
            {
                using (StreamWriter file = new StreamWriter(path + ".txt"))
                {
                    foreach (var elT in data)
                    {
                        file.WriteLine(elT);
                    }
                }
            }
            else
                throw new NotImplementedException();
        }

        public void WriteEachPoint(List<PointData> datas, Mode mode)
        {
            if (mode == Mode.XML)
            {
                Write(datas, mode);
            }
            else if (mode == Mode.TXT)
            {
                using (StreamWriter file = new StreamWriter(path + ".txt"))
                {
                    foreach (var data in datas)
                    {
                        string toPrint = "Point name: {0} \r\nGlobal position: {1}\r\nRelative position: {2}\r\nColor: {3}\r\n";
                        toPrint = String.Format(toPrint, data.Name, data.gPoint, data.wPoint, data.PixelColor);
                        file.WriteLine(toPrint);
                    }
                }
            }
            else
                throw new NotImplementedException();
        }
    }
}