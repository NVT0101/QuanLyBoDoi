using Spire.Doc;
using Spire.Xls;
using Convert = System.Convert;
using FileFormat = Spire.Doc.FileFormat;

namespace QuanLyBoDoi
{
    public class WordProcess
    {
        public void Mau1(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau1.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].GetMember(QUANHE.ME).Name).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau1.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau1", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau2(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau2.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].LydoLyHon).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau2.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau2", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau3(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau3.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    /*newRow.Cells[3].AddParagraph().AppendText($"{lp[i].GetMember("cha")}, {lp[i].GetMember()}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].PrintAllGDNNName(3)).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText(lp[i].PrintAllGDNNQuanHe(3)).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[6].AddParagraph().AppendText(lp[i].PrintAllGDNNQuocGia(3)).CharacterFormat.FontName = "Times New Roman";
                    string[] timeTxt = lp[i].PrintAllGDNNThoiGian(3);
                    newRow.Cells[7].AddParagraph().AppendText(timeTxt[0]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[8].AddParagraph().AppendText(timeTxt[1]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[9].AddParagraph().AppendText(timeTxt[2]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[10].AddParagraph().AppendText(timeTxt[3]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[11].AddParagraph().AppendText(lp[i].PrintAllGDNNGhiChu(3)).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau3.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau3", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau4(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau4.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].PrintVoCon()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].GetConTrai()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[6].AddParagraph().AppendText($"{lp[i].GetCongai()}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau4.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau4", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau5a6(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau5.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                /*//Add a row at the end of the table
            for (int i = 0; i < lp.Count(); i++)
            {
                TableRow newRow = table.AddRow(true, true);
                newRow.Cells[0].AddParagraph().AppendText($"{i + 1}")
                    .CharacterFormat.FontName = "Times New Roman";
                newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}")
                    .CharacterFormat.FontName = "Times New Roman";
                newRow.Cells[2].AddParagraph().AppendText(lp[i].ChoO.Replace('@', ','))
                    .CharacterFormat.FontName = "Times New Roman";
                newRow.Cells[3].AddParagraph().AppendText(lp[i].PrintVoCon())
                    .CharacterFormat.FontName = "Times New Roman";
                */
                /* newRow.Cells[4].AddParagraph().AppendText(lp.ElementAt(i).PrintAllGDNNName())
                     .CharacterFormat.FontName = "Times New Roman";*/
                /*
                newRow.Cells[5].AddParagraph().AppendText($"{lp[i].GetConTrai()}")
                    .CharacterFormat.FontName = "Times New Roman";
                newRow.Cells[6].AddParagraph().AppendText($"{lp[i].GetCongai()}")
                    .CharacterFormat.FontName = "Times New Roman";
            }*/
                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau5.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau5a6", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau7(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau7.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].PrintParent()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].PrintAllVPPLThoiGian(8)).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintAllVPPLNoiDung(8)}").CharacterFormat.FontName = "Times New Roman";
                    string[] mucdoVP = lp[i].PrintAllVPPLMucDo(8);
                    newRow.Cells[6].AddParagraph().AppendText(mucdoVP[0]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[7].AddParagraph().AppendText(mucdoVP[1]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[8].AddParagraph().AppendText(mucdoVP[2]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[9].AddParagraph().AppendText(mucdoVP[3]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[10].AddParagraph().AppendText(lp[i].PrintAllVPPLGhiChu(8)).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau7.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau7", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau8(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau8.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].PrintParent()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].PrintAllVPPLThoiGian(8)).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintAllVPPLLyDo(8)}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[6].AddParagraph().AppendText($"{lp[i].PrintAllVPPLHauQua(8)}").CharacterFormat.FontName = "Times New Roman";
                    string[] mucdoVP = lp[i].PrintAllVPPLMucDo(8);
                    newRow.Cells[7].AddParagraph().AppendText(mucdoVP[0]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[8].AddParagraph().AppendText(mucdoVP[1]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[9].AddParagraph().AppendText(mucdoVP[2]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[10].AddParagraph().AppendText(mucdoVP[3]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[11].AddParagraph().AppendText(lp[i].PrintAllVPPLGhiChu(8)).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau8.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau8", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau9(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau9.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Dantoc)}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].TrinhDo)}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau9.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau9", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau10(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau10.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].MoTaHoanCanh}").CharacterFormat.FontName = "Times New Roman";
                /*newRow.Cells[5].AddParagraph().AppendText($"{lp[i].TrinhDo}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau10.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau10", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau11(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau11.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    /*newRow.Cells[3].AddParagraph().AppendText($"{lp[i].GetMember("cha")}, {lp[i].GetMember()}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                    /*newRow.Cells[4].AddParagraph().AppendText(lp[i].PrintAllGDNNName(11))
                    .CharacterFormat.FontName = "Times New Roman";*/
                    newRow.Cells[5].AddParagraph().AppendText(lp[i].PrintAllGDNNQuocGia(11)).CharacterFormat.FontName = "Times New Roman";
                    string[] timeTxt = lp[i].PrintAllGDNNThoiGian(11);
                    newRow.Cells[6].AddParagraph().AppendText(timeTxt[0]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[7].AddParagraph().AppendText(timeTxt[1]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[8].AddParagraph().AppendText(timeTxt[2]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[9].AddParagraph().AppendText(timeTxt[3]).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[10].AddParagraph().AppendText(lp[i].PrintAllGDNNGhiChu(11)).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau11.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau11", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau12(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau12.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].PrintParent()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].PrintLydoBomeMat()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].GD.Find(g => g.NguoiNuoiDuong).Name}").CharacterFormat.FontName = "Times New Roman";
                /*newRow.Cells[10].AddParagraph().AppendText(lp[i].PrintAllVPPLGhiChu(8))
                    .CharacterFormat.FontName = "Times New Roman";*/
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau12.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau12", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau14(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau14.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].PrintParent()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintAllNDXam()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[6].AddParagraph().AppendText($"{lp[i].PrintAllViTriDienTichXam()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[7].AddParagraph().AppendText($"{lp[i].PrintAllYNghiaXam()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[8].AddParagraph().AppendText($"{lp[i].PrintAllLydothoigianXam()}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau14.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau14", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau15(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau15.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Job)}\n{lp[i].txtNoiLamViec()}\n{lp[i].ThuNhapCaNhan}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau15.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau15", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau16(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau16.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Dantoc)}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau16.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau16", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau17(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau17.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Tongiao)}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau17.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau17", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau18(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau18.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTTinhNguyen}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau18.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau18", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau19(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau19.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                /*newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTTinhNguyen}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau19.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau19", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau20(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau20.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                /*newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTTinhNguyen}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau20.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau20", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau21(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau21.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTThuongBB}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau21.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau21", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau22(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau22.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTCTTrongQD}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau22.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau22", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau23(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau23.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTLietsi}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau23.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau23", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau24(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau24.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].TTMeVNAH}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau24.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau24", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau25(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau25.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].NghienThuoc ? lp[i].MucDoNT : lp[i].MucDoNR).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau25.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau25", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau26(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau26.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].TTMXH).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText(lp[i].GhiChuMXH).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau26.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau26", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau27(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau27.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].TTNhuomToc).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText(lp[i].LydoNhuomToc).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau27.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau27", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau28(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau28.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].TruongHoc).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText(lp[i].ChuyenNganh).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau28.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau28", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau29(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau29.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText(lp[i].txtDonVi()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText(lp[i].txtChoO()).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText(lp[i].HotenCBDV).CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText(lp[i].QuanheCBDV).CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau29.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau29", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau30(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau30.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}\n{lp[i].NgayDang}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText($"{lp[i].PrintParent()}\n{lp[i].txtChoO()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Dantoc)}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Tongiao)}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Vanhoa)}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau30.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau30", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau31(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau31.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText($"{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].txtChoO()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].HotenNY}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].TuoiNY}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].SDTNY}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau31.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau31", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau32(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau32.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText($"{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].txtChoO()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].GetMember(QUANHE.VO).Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].GetMember(QUANHE.VO).NgheNghiep}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintCon()}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau32.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau32", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau33(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau33.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText($"{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].txtChoO()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].GetMember(QUANHE.VO).Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].GetMember(QUANHE.VO).NgheNghiep}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintCon()}").CharacterFormat.FontName = "Times New Roman";
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau33.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau33", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau34(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau34.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}\n{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText($"{Common.GetEnumDescription(lp[i].Dantoc)}\n{Common.GetEnumDescription(lp[i].Tongiao)}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].QueQuan}\n{lp[i].txtChoO()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].PrintParent()}").CharacterFormat.FontName = "Times New Roman";
                    string txtDang = lp[i].Dang ? "Đảng" : "Đoàn";
                    newRow.Cells[5].AddParagraph().AppendText($"{txtDang}\n{lp[i].Vanhoa}").CharacterFormat.FontName = "Times New Roman";
                /*newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintCon()}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                }

                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau34.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau34", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau35(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau35.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<count>>", $"{lp.Count()}", false, true);
                //Get the first table in the section
                Table table = section.Tables[0] as Table;
                //Add a row at the end of the table
                for (int i = 0; i < lp.Count(); i++)
                {
                    TableRow newRow = table.AddRow(true, true);
                    newRow.Cells[0].AddParagraph().AppendText($"{i + 1}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[1].AddParagraph().AppendText($"{lp[i].Name}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[2].AddParagraph().AppendText($"{lp[i].txtDonVi()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[3].AddParagraph().AppendText($"{lp[i].txtChoO()}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[4].AddParagraph().AppendText($"{lp[i].MotaBenhNguoiThan}").CharacterFormat.FontName = "Times New Roman";
                    newRow.Cells[5].AddParagraph().AppendText($"{lp[i].ThoiGianBenhNguoiThan}").CharacterFormat.FontName = "Times New Roman";
                /*newRow.Cells[5].AddParagraph().AppendText($"{lp[i].PrintCon()}")
                    .CharacterFormat.FontName = "Times New Roman";*/
                }

                table.Format.HorizontalAlignment = Spire.Doc.Documents.RowAlignment.Center;
                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau35.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau35", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau36(List<People> lp)
        {
            try
            {
                //Create a Document object
                Document doc = new Document();
                //Load a Word document
                doc.LoadFromFile(".\\Template\\Mau36.doc");
                //Get the first section
                Section section = doc.Sections[0];
                doc.Replace("<<year>>", $"{DateTime.Now.Year}", true, true);
                doc.Replace("<<TQS>>", $"{lp.Count}", true, true);
                //danh sachs theo tinhr
                //tuổi nghĩa vụ 
                doc.Replace("<<Tuoi>>", $"{lp.Count(p => DateTime.Now.Year - Convert.ToInt32(p.Birth.Split("//").Last()) < 25)}", true, true);
                //dân tộc
                doc.Replace("<<Kinh>>", $"{lp.Count(p => p.Dantoc == DANTOC.KINH)}", true, true);
                doc.Replace("<<Thieuso>>", $"{lp.Count(p => p.Dantoc != DANTOC.KINH)}", true, true);
                //danh sách theo dân tộc
                //Tôn giáo
                doc.Replace("<<Kinh>>", $"{lp.Count(p => p.Tongiao != TONGIAO.KHONG)}", true, true);
                //danh sách tôn giáo
                //Gia đình
                //công chức
                doc.Replace("<<CC>>", $"{lp.Count(p => p.CBDV)}", true, true);
                //cán bộ QĐ
                doc.Replace("<<CBQĐ>>", $"{lp.Count(p => p.CTTrongQD)}", true, true);
                //Thuong binh
                doc.Replace("<<TBB>>", $"{lp.Count(p => p.ThuongBenhBinh)}", true, true);
                //Liệt sĩ
                doc.Replace("<<LS>>", $"{lp.Count(p => p.LietSi)}", true, true);
                //Mẹ VNAH
                doc.Replace("<<VNAH>>", $"{lp.Count(p => p.MeVNAH)}", true, true);
                //NQNQ
                doc.Replace("<<NQNQ>>", $"{lp.Count(p => p.ConNQNQ)}", true, true);
                //gia đình có người đi tù
                doc.Replace("<<GDTu>>", $"{lp.Count(p => p.vppl.Count(v => v.NguoiViPham != QUANHE.TOI && v.HinhThuc == HINHTHUCXULY.TU) > 0)}", true, true);
                //gia đình di nước ngoài
                doc.Replace("<<GDNN>>", $"{lp.Count(p => p.GDNN.Count(g => g.QuanHe != QUANHE.TOI) > 0)}", true, true);
                //có vợ đkkh
                //có vợ chưa dkkh
                //có ny
                doc.Replace("<<NY>>", $"{lp.Count(p => p.CoNY)}", true, true);
                //bị xử lý hành chính
                doc.Replace("<<XLHC>>", $"{lp.Count(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.VPHC) > 0)}", true, true);
                //TNGT
                doc.Replace("<<TNGT>>", $"{lp.Count(p => p.vppl.Count(v => v.NguoiViPham == QUANHE.TOI && v.LoaiViPham == LOAIVPPL.TNGT) > 0)}", true, true);
                //đảng viên
                doc.Replace("<<Đảng>>", $"{lp.Count(p => p.Dang)}", true, true);
                //đảng viên
                doc.Replace("<<Đoàn>>", $"{lp.Count(p => p.Doan)}", true, true);
                //mù chữ
                doc.Replace("<<MuChu>>", $"{lp.Count(p => p.TrinhDo == TRINHDO.KBV || p.TrinhDo == TRINHDO.KBD || p.TrinhDo == TRINHDO.DVC)}", true, true);
                //cao đẳng đại học
                doc.Replace("<<CDDH>>", $"{lp.Count(p => p.TrinhDo == TRINHDO.CD || p.TrinhDo == TRINHDO.DH || p.TrinhDo == TRINHDO.TC)}", true, true);
                //cấp 1
                doc.Replace("<<C1>>", $"{lp.Count(p => p.TrinhDo >= TRINHDO.L1 && p.TrinhDo <= TRINHDO.L5)}", true, true);
                //cấp 2
                doc.Replace("<<C2>>", $"{lp.Count(p => p.TrinhDo >= TRINHDO.L6 && p.TrinhDo <= TRINHDO.L9)}", true, true);
                //cấp 3
                doc.Replace("<<C3>>", $"{lp.Count(p => p.TrinhDo >= TRINHDO.L10 && p.TrinhDo <= TRINHDO.L12)}", true, true);
                //sức khỏe
                doc.Replace("<<L1>>", $"{lp.Count(p => p.XC.Count > 0)}", true, true);
                doc.Replace("<<TLL1>>", $"{lp.Count(p => p.XC.Count > 0) / lp.Count}", true, true);
                doc.Replace("<<L2>>", $"{lp.Count(p => p.XC.Count > 0)}", true, true);
                doc.Replace("<<TLL2>>", $"{lp.Count(p => p.XC.Count > 0) / lp.Count}", true, true);
                doc.Replace("<<L3>>", $"{lp.Count(p => p.XC.Count > 0)}", true, true);
                doc.Replace("<<TLL3>>", $"{lp.Count(p => p.XC.Count > 0) / lp.Count}", true, true);
                //xăm
                doc.Replace("<<Xăm>>", $"{lp.Count(p => p.XC.Count > 0)}", true, true);
                //nhuộm tóc
                doc.Replace("<<Nhuộm>>", $"{lp.Count(p => p.NhuomToc)}", true, true);
                //mạng xã hội
                doc.Replace("<<MXH>>", $"{lp.Count(p => p.MXH)}", true, true);
                //nghiện rượu, thuốc
                doc.Replace("<<RuouThuoc>>", $"{lp.Count(p => p.NghienRuou || p.NghienThuoc)}", true, true);
                //7.
                doc.Replace("<<PVLD>>", $"{lp.Count(p => p.TinhNguyen)}", true, true);
                //8.
                doc.Replace("<<LamAnXa>>", $"{lp.Count(p => p.LamAnXa)}", true, true);
                doc.Replace("<<Bien>>", $"{lp.Count(p => p.Job == JOB.BIEN)}", true, true);
                doc.Replace("<<ThuNhap>>", $"{lp.Count(p => Convert.ToInt32(p.ThuNhapCaNhan) > 2000000)}", true, true);
                doc.Replace("<<NK>>", $"{lp.Count(p => p.NangKhieu != "")}", true, true);
                doc.Replace("<<DiNN>>", $"{lp.Count(p => p.GDNN.Exists(g => g.QuanHe == QUANHE.TOI))}", true, true);
                //9.
                doc.Replace("<<NgoaiHon>>", $"{lp.Count(p => p.ConNgoaiHon)}", true, true);
                doc.Replace("<<LyHon>>", $"{lp.Count(p => p.BomeLyHon)}", true, true);
                doc.Replace("<<ConTrai1>>", $"{lp.Count(p => p.GD.Count(g => g.QuanHe == QUANHE.ANH || g.QuanHe == QUANHE.EMT) == 0)}", true, true);
                doc.Replace("<<Con1>>", $"{lp.Count(p => p.GD.Count(g => g.QuanHe == QUANHE.ANH || g.QuanHe == QUANHE.CHI || g.QuanHe == QUANHE.EMT || g.QuanHe == QUANHE.EMG) == 0)}", true, true);
                doc.Replace("<<DBKK>>", $"{lp.Count(p => p.HoanCanh == HOANCANH.DBKK)}", true, true);
                doc.Replace("<<GDBenh>>", $"{lp.Count(p => p.GDBenhHiemNgheo)}", true, true);
                doc.Replace("<<ChameChet>>", $"{lp.Count(p => p.GD.Exists(g => (g.QuanHe == QUANHE.ME && g.Mat) || (g.QuanHe == QUANHE.BO && g.Mat)))}", true, true);
                //Save the result document
                doc.SaveToFile(Path.Combine(Common.outPath, "Mau36.docx"), FileFormat.Docx2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau36", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void Mau37(List<People> lp)
        {
            try
            {
                // Create a Workbook object
                Workbook wb = new Workbook();
                //Load an existing Excel file
                wb.LoadFromFile(".\\Template\\Mau37.xlsx");
                //Get the first worksheet
                Worksheet sheet = wb.Worksheets[0];
                int total = lp.Count;
                sheet.Replace("<<năm>>", $"{DateTime.Now.Year}");
                //Change the value of a specific cell
                sheet.Range["B13"].Value = $"{total}";
                sheet.Range["C13"].Value = $"{lp.Count(p => p.Dang)}";
                sheet.Range["D13"].Value = $"{lp.Count(p => p.Doan)}";
                sheet.Range["F13"].Value = $"{lp.Count(p => p.Dantoc == DANTOC.KINH)}";
                sheet.Range["G13"].Value = $"{lp.Count(p => p.Dantoc != DANTOC.KINH)}";
                sheet.Range["H13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.THIENCHUA)}";
                sheet.Range["I13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.TINLANH)}";
                sheet.Range["J13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.CAODAI)}";
                sheet.Range["K13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.CONG)}";
                sheet.Range["L13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.PHAT)}";
                sheet.Range["M13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.BANI)}";
                sheet.Range["N13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.BALAMON)}";
                sheet.Range["O13"].Value = $"{lp.Count(p => p.Tongiao != TONGIAO.CODOC)}";
                sheet.Range["Q13"].Value = $"{lp.Count(p => p.TrinhDo < TRINHDO.L6)}";
                sheet.Range["R13"].Value = $"{lp.Count(p => p.TrinhDo >= TRINHDO.L6 && p.TrinhDo < TRINHDO.L10)}";
                sheet.Range["S13"].Value = $"{lp.Count(p => p.TrinhDo >= TRINHDO.L10 && p.TrinhDo <= TRINHDO.L12)}";
                sheet.Range["S13"].Value = $"{lp.Count(p => p.TrinhDo == TRINHDO.TC || p.TrinhDo == TRINHDO.CD || p.TrinhDo == TRINHDO.DH)}";
                sheet.Range["W13"].Value = $"{lp.Count(p => p.LietSi || p.ThuongBenhBinh)}";
                sheet.Range["X13"].Value = $"{lp.Count(p => p.CBDV)}";
                sheet.Range["Y13"].Value = $"{lp.Count(p => p.ConNQNQ)}";
                //Save to file
                wb.SaveToFile("Mau37.xlsx", ExcelVersion.Version2016);
            }
            catch (Exception ex)
            {
                Log.LogError(ex);
                System.Windows.Forms.MessageBox.Show("Error in method: " + "Mau37", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}