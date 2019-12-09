using Sudoku.Common.Common;
using Sudoku.Common.Model;
using Sudoku.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sudoku.Common.Data
{
    public class ProblemRepository
    {
        string xmlFile = Constants.XMlFilePath;
        public void AddProblemStatement(SudokuModel model)
        {
            XmlDocument XmlDocObj = new XmlDocument();
            XmlDocObj.Load(xmlFile);
            XmlNode RootNode = XmlDocObj.SelectSingleNode("problems");
            XmlNode problemNode = RootNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "problem", ""));

            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "problemId", "")).InnerText = Guid.NewGuid().ToString();
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "problemName", "")).InnerText = model.ProblemName;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "createdDate", "")).InnerText = System.DateTime.Now.ToString();

            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell0", "")).InnerText = String.IsNullOrEmpty(model.Cell0) ? "" : model.Cell0;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell1", "")).InnerText = String.IsNullOrEmpty(model.Cell1) ? "" : model.Cell1;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell2", "")).InnerText = String.IsNullOrEmpty(model.Cell2) ? "" : model.Cell2;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell3", "")).InnerText = String.IsNullOrEmpty(model.Cell3) ? "" : model.Cell3;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell4", "")).InnerText = String.IsNullOrEmpty(model.Cell4) ? "" : model.Cell4;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell5", "")).InnerText = String.IsNullOrEmpty(model.Cell5) ? "" : model.Cell5;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell6", "")).InnerText = String.IsNullOrEmpty(model.Cell6) ? "" : model.Cell6;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell7", "")).InnerText = String.IsNullOrEmpty(model.Cell7) ? "" : model.Cell7;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell8", "")).InnerText = String.IsNullOrEmpty(model.Cell8) ? "" : model.Cell8;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell9", "")).InnerText = String.IsNullOrEmpty(model.Cell9) ? "" : model.Cell9;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell10", "")).InnerText = String.IsNullOrEmpty(model.Cell10) ? "" : model.Cell10;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell11", "")).InnerText = String.IsNullOrEmpty(model.Cell11) ? "" : model.Cell11;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell12", "")).InnerText = String.IsNullOrEmpty(model.Cell12) ? "" : model.Cell12;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell13", "")).InnerText = String.IsNullOrEmpty(model.Cell13) ? "" : model.Cell13;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell14", "")).InnerText = String.IsNullOrEmpty(model.Cell14) ? "" : model.Cell14;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell15", "")).InnerText = String.IsNullOrEmpty(model.Cell15) ? "" : model.Cell15;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell16", "")).InnerText = String.IsNullOrEmpty(model.Cell16) ? "" : model.Cell16;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell17", "")).InnerText = String.IsNullOrEmpty(model.Cell17) ? "" : model.Cell17;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell18", "")).InnerText = String.IsNullOrEmpty(model.Cell18) ? "" : model.Cell18;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell19", "")).InnerText = String.IsNullOrEmpty(model.Cell19) ? "" : model.Cell19;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell20", "")).InnerText = String.IsNullOrEmpty(model.Cell20) ? "" : model.Cell20;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell21", "")).InnerText = String.IsNullOrEmpty(model.Cell21) ? "" : model.Cell21;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell22", "")).InnerText = String.IsNullOrEmpty(model.Cell22) ? "" : model.Cell22;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell23", "")).InnerText = String.IsNullOrEmpty(model.Cell23) ? "" : model.Cell23;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell24", "")).InnerText = String.IsNullOrEmpty(model.Cell24) ? "" : model.Cell24;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell25", "")).InnerText = String.IsNullOrEmpty(model.Cell25) ? "" : model.Cell25;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell26", "")).InnerText = String.IsNullOrEmpty(model.Cell26) ? "" : model.Cell26;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell27", "")).InnerText = String.IsNullOrEmpty(model.Cell27) ? "" : model.Cell27;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell28", "")).InnerText = String.IsNullOrEmpty(model.Cell28) ? "" : model.Cell28;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell29", "")).InnerText = String.IsNullOrEmpty(model.Cell29) ? "" : model.Cell29;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell30", "")).InnerText = String.IsNullOrEmpty(model.Cell30) ? "" : model.Cell30;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell31", "")).InnerText = String.IsNullOrEmpty(model.Cell31) ? "" : model.Cell31;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell32", "")).InnerText = String.IsNullOrEmpty(model.Cell32) ? "" : model.Cell32;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell33", "")).InnerText = String.IsNullOrEmpty(model.Cell33) ? "" : model.Cell33;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell34", "")).InnerText = String.IsNullOrEmpty(model.Cell34) ? "" : model.Cell34;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell35", "")).InnerText = String.IsNullOrEmpty(model.Cell35) ? "" : model.Cell35;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell36", "")).InnerText = String.IsNullOrEmpty(model.Cell36) ? "" : model.Cell36;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell37", "")).InnerText = String.IsNullOrEmpty(model.Cell37) ? "" : model.Cell37;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell38", "")).InnerText = String.IsNullOrEmpty(model.Cell38) ? "" : model.Cell38;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell39", "")).InnerText = String.IsNullOrEmpty(model.Cell39) ? "" : model.Cell39;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell40", "")).InnerText = String.IsNullOrEmpty(model.Cell40) ? "" : model.Cell40;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell41", "")).InnerText = String.IsNullOrEmpty(model.Cell41) ? "" : model.Cell41;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell42", "")).InnerText = String.IsNullOrEmpty(model.Cell42) ? "" : model.Cell42;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell43", "")).InnerText = String.IsNullOrEmpty(model.Cell43) ? "" : model.Cell43;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell44", "")).InnerText = String.IsNullOrEmpty(model.Cell44) ? "" : model.Cell44;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell45", "")).InnerText = String.IsNullOrEmpty(model.Cell45) ? "" : model.Cell45;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell46", "")).InnerText = String.IsNullOrEmpty(model.Cell46) ? "" : model.Cell46;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell47", "")).InnerText = String.IsNullOrEmpty(model.Cell47) ? "" : model.Cell47;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell48", "")).InnerText = String.IsNullOrEmpty(model.Cell48) ? "" : model.Cell48;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell49", "")).InnerText = String.IsNullOrEmpty(model.Cell49) ? "" : model.Cell49;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell50", "")).InnerText = String.IsNullOrEmpty(model.Cell50) ? "" : model.Cell50;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell51", "")).InnerText = String.IsNullOrEmpty(model.Cell51) ? "" : model.Cell51;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell52", "")).InnerText = String.IsNullOrEmpty(model.Cell52) ? "" : model.Cell52;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell53", "")).InnerText = String.IsNullOrEmpty(model.Cell53) ? "" : model.Cell53;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell54", "")).InnerText = String.IsNullOrEmpty(model.Cell54) ? "" : model.Cell54;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell55", "")).InnerText = String.IsNullOrEmpty(model.Cell55) ? "" : model.Cell55;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell56", "")).InnerText = String.IsNullOrEmpty(model.Cell56) ? "" : model.Cell56;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell57", "")).InnerText = String.IsNullOrEmpty(model.Cell57) ? "" : model.Cell57;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell58", "")).InnerText = String.IsNullOrEmpty(model.Cell58) ? "" : model.Cell58;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell59", "")).InnerText = String.IsNullOrEmpty(model.Cell59) ? "" : model.Cell59;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell60", "")).InnerText = String.IsNullOrEmpty(model.Cell60) ? "" : model.Cell60;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell61", "")).InnerText = String.IsNullOrEmpty(model.Cell61) ? "" : model.Cell61;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell62", "")).InnerText = String.IsNullOrEmpty(model.Cell62) ? "" : model.Cell62;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell63", "")).InnerText = String.IsNullOrEmpty(model.Cell63) ? "" : model.Cell63;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell64", "")).InnerText = String.IsNullOrEmpty(model.Cell64) ? "" : model.Cell64;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell65", "")).InnerText = String.IsNullOrEmpty(model.Cell65) ? "" : model.Cell65;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell66", "")).InnerText = String.IsNullOrEmpty(model.Cell66) ? "" : model.Cell66;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell67", "")).InnerText = String.IsNullOrEmpty(model.Cell67) ? "" : model.Cell67;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell68", "")).InnerText = String.IsNullOrEmpty(model.Cell68) ? "" : model.Cell68;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell69", "")).InnerText = String.IsNullOrEmpty(model.Cell69) ? "" : model.Cell69;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell70", "")).InnerText = String.IsNullOrEmpty(model.Cell70) ? "" : model.Cell70;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell71", "")).InnerText = String.IsNullOrEmpty(model.Cell71) ? "" : model.Cell71;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell72", "")).InnerText = String.IsNullOrEmpty(model.Cell72) ? "" : model.Cell72;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell73", "")).InnerText = String.IsNullOrEmpty(model.Cell73) ? "" : model.Cell73;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell74", "")).InnerText = String.IsNullOrEmpty(model.Cell74) ? "" : model.Cell74;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell75", "")).InnerText = String.IsNullOrEmpty(model.Cell75) ? "" : model.Cell75;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell76", "")).InnerText = String.IsNullOrEmpty(model.Cell76) ? "" : model.Cell76;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell77", "")).InnerText = String.IsNullOrEmpty(model.Cell77) ? "" : model.Cell77;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell78", "")).InnerText = String.IsNullOrEmpty(model.Cell78) ? "" : model.Cell78;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell79", "")).InnerText = String.IsNullOrEmpty(model.Cell79) ? "" : model.Cell79;
            problemNode.AppendChild(XmlDocObj.CreateNode(XmlNodeType.Element, "Cell80", "")).InnerText = String.IsNullOrEmpty(model.Cell80) ? "" : model.Cell80;
            XmlDocObj.Save(xmlFile);
        }

        public List<SudokuModel> ProblemList()
        {
            var list = Helper.Helper.XMLToList<SudokuModel>(Constants.XMlFilePath).ToList();
            foreach (var item in list)
            {
                item.ProblemInput = item.ProblemInput + (String.IsNullOrEmpty(item.Cell0.ToString()) ? "." : item.Cell0.ToString()) +
                    (String.IsNullOrEmpty(item.Cell1.ToString()) ? "." : item.Cell1.ToString()) +
                    (String.IsNullOrEmpty(item.Cell2.ToString()) ? "." : item.Cell2.ToString()) +
                    (String.IsNullOrEmpty(item.Cell3.ToString()) ? "." : item.Cell3.ToString()) +
                    (String.IsNullOrEmpty(item.Cell4.ToString()) ? "." : item.Cell4.ToString()) +
                    (String.IsNullOrEmpty(item.Cell5.ToString()) ? "." : item.Cell5.ToString()) +
                    (String.IsNullOrEmpty(item.Cell6.ToString()) ? "." : item.Cell6.ToString()) +
                    (String.IsNullOrEmpty(item.Cell7.ToString()) ? "." : item.Cell7.ToString()) +
                    (String.IsNullOrEmpty(item.Cell8.ToString()) ? "." : item.Cell8.ToString()) +
                    (String.IsNullOrEmpty(item.Cell9.ToString()) ? "." : item.Cell9.ToString()) +
                    (String.IsNullOrEmpty(item.Cell10.ToString()) ? "." : item.Cell10.ToString()) +
                    (String.IsNullOrEmpty(item.Cell11.ToString()) ? "." : item.Cell11.ToString()) +
                    (String.IsNullOrEmpty(item.Cell12.ToString()) ? "." : item.Cell12.ToString()) +
                    (String.IsNullOrEmpty(item.Cell13.ToString()) ? "." : item.Cell13.ToString()) +
                    (String.IsNullOrEmpty(item.Cell14.ToString()) ? "." : item.Cell14.ToString()) +
                    (String.IsNullOrEmpty(item.Cell15.ToString()) ? "." : item.Cell15.ToString()) +
                    (String.IsNullOrEmpty(item.Cell16.ToString()) ? "." : item.Cell16.ToString()) +
                    (String.IsNullOrEmpty(item.Cell17.ToString()) ? "." : item.Cell17.ToString()) +
                    (String.IsNullOrEmpty(item.Cell18.ToString()) ? "." : item.Cell18.ToString()) +
                    (String.IsNullOrEmpty(item.Cell19.ToString()) ? "." : item.Cell19.ToString()) +
                    (String.IsNullOrEmpty(item.Cell20.ToString()) ? "." : item.Cell20.ToString()) +
                    (String.IsNullOrEmpty(item.Cell21.ToString()) ? "." : item.Cell21.ToString()) +
                    (String.IsNullOrEmpty(item.Cell22.ToString()) ? "." : item.Cell22.ToString()) +
                    (String.IsNullOrEmpty(item.Cell23.ToString()) ? "." : item.Cell23.ToString()) +
                    (String.IsNullOrEmpty(item.Cell24.ToString()) ? "." : item.Cell24.ToString()) +
                    (String.IsNullOrEmpty(item.Cell25.ToString()) ? "." : item.Cell25.ToString()) +
                    (String.IsNullOrEmpty(item.Cell26.ToString()) ? "." : item.Cell26.ToString()) +
                    (String.IsNullOrEmpty(item.Cell27.ToString()) ? "." : item.Cell27.ToString()) +
                    (String.IsNullOrEmpty(item.Cell28.ToString()) ? "." : item.Cell28.ToString()) +
                    (String.IsNullOrEmpty(item.Cell29.ToString()) ? "." : item.Cell29.ToString()) +
                    (String.IsNullOrEmpty(item.Cell30.ToString()) ? "." : item.Cell30.ToString()) +
                    (String.IsNullOrEmpty(item.Cell31.ToString()) ? "." : item.Cell31.ToString()) +
                    (String.IsNullOrEmpty(item.Cell32.ToString()) ? "." : item.Cell32.ToString()) +
                    (String.IsNullOrEmpty(item.Cell33.ToString()) ? "." : item.Cell33.ToString()) +
                    (String.IsNullOrEmpty(item.Cell34.ToString()) ? "." : item.Cell34.ToString()) +
                    (String.IsNullOrEmpty(item.Cell35.ToString()) ? "." : item.Cell35.ToString()) +
                    (String.IsNullOrEmpty(item.Cell36.ToString()) ? "." : item.Cell36.ToString()) +
                    (String.IsNullOrEmpty(item.Cell37.ToString()) ? "." : item.Cell37.ToString()) +
                    (String.IsNullOrEmpty(item.Cell38.ToString()) ? "." : item.Cell38.ToString()) +
                    (String.IsNullOrEmpty(item.Cell39.ToString()) ? "." : item.Cell39.ToString()) +
                    (String.IsNullOrEmpty(item.Cell40.ToString()) ? "." : item.Cell40.ToString()) +
                    (String.IsNullOrEmpty(item.Cell41.ToString()) ? "." : item.Cell41.ToString()) +
                    (String.IsNullOrEmpty(item.Cell42.ToString()) ? "." : item.Cell42.ToString()) +
                    (String.IsNullOrEmpty(item.Cell43.ToString()) ? "." : item.Cell43.ToString()) +
                    (String.IsNullOrEmpty(item.Cell44.ToString()) ? "." : item.Cell44.ToString()) +
                    (String.IsNullOrEmpty(item.Cell45.ToString()) ? "." : item.Cell45.ToString()) +
                    (String.IsNullOrEmpty(item.Cell46.ToString()) ? "." : item.Cell46.ToString()) +
                    (String.IsNullOrEmpty(item.Cell47.ToString()) ? "." : item.Cell47.ToString()) +
                    (String.IsNullOrEmpty(item.Cell48.ToString()) ? "." : item.Cell48.ToString()) +
                    (String.IsNullOrEmpty(item.Cell49.ToString()) ? "." : item.Cell49.ToString()) +
                    (String.IsNullOrEmpty(item.Cell50.ToString()) ? "." : item.Cell50.ToString()) +
                    (String.IsNullOrEmpty(item.Cell51.ToString()) ? "." : item.Cell51.ToString()) +
                    (String.IsNullOrEmpty(item.Cell52.ToString()) ? "." : item.Cell52.ToString()) +
                    (String.IsNullOrEmpty(item.Cell53.ToString()) ? "." : item.Cell53.ToString()) +
                    (String.IsNullOrEmpty(item.Cell54.ToString()) ? "." : item.Cell54.ToString()) +
                    (String.IsNullOrEmpty(item.Cell55.ToString()) ? "." : item.Cell55.ToString()) +
                    (String.IsNullOrEmpty(item.Cell56.ToString()) ? "." : item.Cell56.ToString()) +
                    (String.IsNullOrEmpty(item.Cell57.ToString()) ? "." : item.Cell57.ToString()) +
                    (String.IsNullOrEmpty(item.Cell58.ToString()) ? "." : item.Cell58.ToString()) +
                    (String.IsNullOrEmpty(item.Cell59.ToString()) ? "." : item.Cell59.ToString()) +
                    (String.IsNullOrEmpty(item.Cell60.ToString()) ? "." : item.Cell60.ToString()) +
                    (String.IsNullOrEmpty(item.Cell61.ToString()) ? "." : item.Cell61.ToString()) +
                    (String.IsNullOrEmpty(item.Cell62.ToString()) ? "." : item.Cell62.ToString()) +
                    (String.IsNullOrEmpty(item.Cell63.ToString()) ? "." : item.Cell63.ToString()) +
                    (String.IsNullOrEmpty(item.Cell64.ToString()) ? "." : item.Cell64.ToString()) +
                    (String.IsNullOrEmpty(item.Cell65.ToString()) ? "." : item.Cell65.ToString()) +
                    (String.IsNullOrEmpty(item.Cell66.ToString()) ? "." : item.Cell66.ToString()) +
                    (String.IsNullOrEmpty(item.Cell67.ToString()) ? "." : item.Cell67.ToString()) +
                    (String.IsNullOrEmpty(item.Cell68.ToString()) ? "." : item.Cell68.ToString()) +
                    (String.IsNullOrEmpty(item.Cell69.ToString()) ? "." : item.Cell69.ToString()) +
                    (String.IsNullOrEmpty(item.Cell70.ToString()) ? "." : item.Cell70.ToString()) +
                    (String.IsNullOrEmpty(item.Cell71.ToString()) ? "." : item.Cell71.ToString()) +
                    (String.IsNullOrEmpty(item.Cell72.ToString()) ? "." : item.Cell72.ToString()) +
                    (String.IsNullOrEmpty(item.Cell73.ToString()) ? "." : item.Cell73.ToString()) +
                    (String.IsNullOrEmpty(item.Cell74.ToString()) ? "." : item.Cell74.ToString()) +
                    (String.IsNullOrEmpty(item.Cell75.ToString()) ? "." : item.Cell75.ToString()) +
                    (String.IsNullOrEmpty(item.Cell76.ToString()) ? "." : item.Cell76.ToString()) +
                    (String.IsNullOrEmpty(item.Cell77.ToString()) ? "." : item.Cell77.ToString()) +
                    (String.IsNullOrEmpty(item.Cell78.ToString()) ? "." : item.Cell78.ToString()) +
                    (String.IsNullOrEmpty(item.Cell79.ToString()) ? "." : item.Cell79.ToString()) +
                    (String.IsNullOrEmpty(item.Cell80.ToString()) ? "." : item.Cell80.ToString());
            }
            return list;
        }

        public SudokuModel GetProblemByProblemId(string probelmId)
        {
            var model = Helper.Helper.XMLToList<SudokuModel>(Constants.XMlFilePath).Where(x => x.ProblemId == probelmId).FirstOrDefault();
            model.ProblemInput = model.ProblemInput + (String.IsNullOrEmpty(model.Cell0.ToString()) ? "." : model.Cell0.ToString()) +
                (String.IsNullOrEmpty(model.Cell1.ToString()) ? "." : model.Cell1.ToString()) +
                (String.IsNullOrEmpty(model.Cell2.ToString()) ? "." : model.Cell2.ToString()) +
                (String.IsNullOrEmpty(model.Cell3.ToString()) ? "." : model.Cell3.ToString()) +
                (String.IsNullOrEmpty(model.Cell4.ToString()) ? "." : model.Cell4.ToString()) +
                (String.IsNullOrEmpty(model.Cell5.ToString()) ? "." : model.Cell5.ToString()) +
                (String.IsNullOrEmpty(model.Cell6.ToString()) ? "." : model.Cell6.ToString()) +
                (String.IsNullOrEmpty(model.Cell7.ToString()) ? "." : model.Cell7.ToString()) +
                (String.IsNullOrEmpty(model.Cell8.ToString()) ? "." : model.Cell8.ToString()) +
                (String.IsNullOrEmpty(model.Cell9.ToString()) ? "." : model.Cell9.ToString()) +
                (String.IsNullOrEmpty(model.Cell10.ToString()) ? "." : model.Cell10.ToString()) +
                (String.IsNullOrEmpty(model.Cell11.ToString()) ? "." : model.Cell11.ToString()) +
                (String.IsNullOrEmpty(model.Cell12.ToString()) ? "." : model.Cell12.ToString()) +
                (String.IsNullOrEmpty(model.Cell13.ToString()) ? "." : model.Cell13.ToString()) +
                (String.IsNullOrEmpty(model.Cell14.ToString()) ? "." : model.Cell14.ToString()) +
                (String.IsNullOrEmpty(model.Cell15.ToString()) ? "." : model.Cell15.ToString()) +
                (String.IsNullOrEmpty(model.Cell16.ToString()) ? "." : model.Cell16.ToString()) +
                (String.IsNullOrEmpty(model.Cell17.ToString()) ? "." : model.Cell17.ToString()) +
                (String.IsNullOrEmpty(model.Cell18.ToString()) ? "." : model.Cell18.ToString()) +
                (String.IsNullOrEmpty(model.Cell19.ToString()) ? "." : model.Cell19.ToString()) +
                (String.IsNullOrEmpty(model.Cell20.ToString()) ? "." : model.Cell20.ToString()) +
                (String.IsNullOrEmpty(model.Cell21.ToString()) ? "." : model.Cell21.ToString()) +
                (String.IsNullOrEmpty(model.Cell22.ToString()) ? "." : model.Cell22.ToString()) +
                (String.IsNullOrEmpty(model.Cell23.ToString()) ? "." : model.Cell23.ToString()) +
                (String.IsNullOrEmpty(model.Cell24.ToString()) ? "." : model.Cell24.ToString()) +
                (String.IsNullOrEmpty(model.Cell25.ToString()) ? "." : model.Cell25.ToString()) +
                (String.IsNullOrEmpty(model.Cell26.ToString()) ? "." : model.Cell26.ToString()) +
                (String.IsNullOrEmpty(model.Cell27.ToString()) ? "." : model.Cell27.ToString()) +
                (String.IsNullOrEmpty(model.Cell28.ToString()) ? "." : model.Cell28.ToString()) +
                (String.IsNullOrEmpty(model.Cell29.ToString()) ? "." : model.Cell29.ToString()) +
                (String.IsNullOrEmpty(model.Cell30.ToString()) ? "." : model.Cell30.ToString()) +
                (String.IsNullOrEmpty(model.Cell31.ToString()) ? "." : model.Cell31.ToString()) +
                (String.IsNullOrEmpty(model.Cell32.ToString()) ? "." : model.Cell32.ToString()) +
                (String.IsNullOrEmpty(model.Cell33.ToString()) ? "." : model.Cell33.ToString()) +
                (String.IsNullOrEmpty(model.Cell34.ToString()) ? "." : model.Cell34.ToString()) +
                (String.IsNullOrEmpty(model.Cell35.ToString()) ? "." : model.Cell35.ToString()) +
                (String.IsNullOrEmpty(model.Cell36.ToString()) ? "." : model.Cell36.ToString()) +
                (String.IsNullOrEmpty(model.Cell37.ToString()) ? "." : model.Cell37.ToString()) +
                (String.IsNullOrEmpty(model.Cell38.ToString()) ? "." : model.Cell38.ToString()) +
                (String.IsNullOrEmpty(model.Cell39.ToString()) ? "." : model.Cell39.ToString()) +
                (String.IsNullOrEmpty(model.Cell40.ToString()) ? "." : model.Cell40.ToString()) +
                (String.IsNullOrEmpty(model.Cell41.ToString()) ? "." : model.Cell41.ToString()) +
                (String.IsNullOrEmpty(model.Cell42.ToString()) ? "." : model.Cell42.ToString()) +
                (String.IsNullOrEmpty(model.Cell43.ToString()) ? "." : model.Cell43.ToString()) +
                (String.IsNullOrEmpty(model.Cell44.ToString()) ? "." : model.Cell44.ToString()) +
                (String.IsNullOrEmpty(model.Cell45.ToString()) ? "." : model.Cell45.ToString()) +
                (String.IsNullOrEmpty(model.Cell46.ToString()) ? "." : model.Cell46.ToString()) +
                (String.IsNullOrEmpty(model.Cell47.ToString()) ? "." : model.Cell47.ToString()) +
                (String.IsNullOrEmpty(model.Cell48.ToString()) ? "." : model.Cell48.ToString()) +
                (String.IsNullOrEmpty(model.Cell49.ToString()) ? "." : model.Cell49.ToString()) +
                (String.IsNullOrEmpty(model.Cell50.ToString()) ? "." : model.Cell50.ToString()) +
                (String.IsNullOrEmpty(model.Cell51.ToString()) ? "." : model.Cell51.ToString()) +
                (String.IsNullOrEmpty(model.Cell52.ToString()) ? "." : model.Cell52.ToString()) +
                (String.IsNullOrEmpty(model.Cell53.ToString()) ? "." : model.Cell53.ToString()) +
                (String.IsNullOrEmpty(model.Cell54.ToString()) ? "." : model.Cell54.ToString()) +
                (String.IsNullOrEmpty(model.Cell55.ToString()) ? "." : model.Cell55.ToString()) +
                (String.IsNullOrEmpty(model.Cell56.ToString()) ? "." : model.Cell56.ToString()) +
                (String.IsNullOrEmpty(model.Cell57.ToString()) ? "." : model.Cell57.ToString()) +
                (String.IsNullOrEmpty(model.Cell58.ToString()) ? "." : model.Cell58.ToString()) +
                (String.IsNullOrEmpty(model.Cell59.ToString()) ? "." : model.Cell59.ToString()) +
                (String.IsNullOrEmpty(model.Cell60.ToString()) ? "." : model.Cell60.ToString()) +
                (String.IsNullOrEmpty(model.Cell61.ToString()) ? "." : model.Cell61.ToString()) +
                (String.IsNullOrEmpty(model.Cell62.ToString()) ? "." : model.Cell62.ToString()) +
                (String.IsNullOrEmpty(model.Cell63.ToString()) ? "." : model.Cell63.ToString()) +
                (String.IsNullOrEmpty(model.Cell64.ToString()) ? "." : model.Cell64.ToString()) +
                (String.IsNullOrEmpty(model.Cell65.ToString()) ? "." : model.Cell65.ToString()) +
                (String.IsNullOrEmpty(model.Cell66.ToString()) ? "." : model.Cell66.ToString()) +
                (String.IsNullOrEmpty(model.Cell67.ToString()) ? "." : model.Cell67.ToString()) +
                (String.IsNullOrEmpty(model.Cell68.ToString()) ? "." : model.Cell68.ToString()) +
                (String.IsNullOrEmpty(model.Cell69.ToString()) ? "." : model.Cell69.ToString()) +
                (String.IsNullOrEmpty(model.Cell70.ToString()) ? "." : model.Cell70.ToString()) +
                (String.IsNullOrEmpty(model.Cell71.ToString()) ? "." : model.Cell71.ToString()) +
                (String.IsNullOrEmpty(model.Cell72.ToString()) ? "." : model.Cell72.ToString()) +
                (String.IsNullOrEmpty(model.Cell73.ToString()) ? "." : model.Cell73.ToString()) +
                (String.IsNullOrEmpty(model.Cell74.ToString()) ? "." : model.Cell74.ToString()) +
                (String.IsNullOrEmpty(model.Cell75.ToString()) ? "." : model.Cell75.ToString()) +
                (String.IsNullOrEmpty(model.Cell76.ToString()) ? "." : model.Cell76.ToString()) +
                (String.IsNullOrEmpty(model.Cell77.ToString()) ? "." : model.Cell77.ToString()) +
                (String.IsNullOrEmpty(model.Cell78.ToString()) ? "." : model.Cell78.ToString()) +
                (String.IsNullOrEmpty(model.Cell79.ToString()) ? "." : model.Cell79.ToString()) +
                (String.IsNullOrEmpty(model.Cell80.ToString()) ? "." : model.Cell80.ToString());
            return model;
        }

        public int GetProblemsCount() {
            var list = Helper.Helper.XMLToList<SudokuModel>(Constants.XMlFilePath).ToList();
            if (list != null)
                return list.Count();
            else
                return 0;
        }
    }
}
