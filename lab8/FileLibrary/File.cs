using System.Collections.Generic;
using System.IO;
using System.Linq;
using Transport;

namespace FileLibrary
{
    public class FileWork
    {
        public static List<ITransport> ReadFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            List<ITransport> transportList = new List<ITransport>();
            ITransport transport = null;
            string line;
            List<string> lineElements = new List<string>();

            while ((line = reader.ReadLine()) != null)
            {
                lineElements = line.Split(' ').ToList<string>();

                switch (lineElements[0])
                {
                    case "автобус":
                        transport = new Bus(lineElements[0], int.Parse(lineElements[1]), lineElements[2],
                            lineElements[3], new double[] { double.Parse(lineElements[4]),
                            double.Parse(lineElements[5]) }, int.Parse(lineElements[6]));
                        break;
                    case "поезд":
                        transport = new Train(lineElements[0], int.Parse(lineElements[1]), lineElements[2],
                            lineElements[3], new double[] { double.Parse(lineElements[4]), double.Parse(lineElements[5]),
                            double.Parse(lineElements[6]), double.Parse(lineElements[7]) }, int.Parse(lineElements[8]));
                        break;
                    case "самолет":
                        transport = new Airplane(lineElements[0], int.Parse(lineElements[1]), lineElements[2],
                            lineElements[3], new double[] { double.Parse(lineElements[4]), double.Parse(lineElements[5]),
                            double.Parse(lineElements[6]) }, int.Parse(lineElements[7]));
                        break;
                }
                transportList.Add(transport);
            }

            reader.Close();

            return transportList;
        }
    }
}
