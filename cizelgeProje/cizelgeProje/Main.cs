using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;



namespace cizelgeProje
{
    public partial class Main : Form
    {
        public SqlConnection baglanti;
        public int PersonelID;  
        
        public Main()
        {
            InitializeComponent();
        }
        #region Degiskenler
        public string sicil { get; set; }
        DateTime haftaBas = DateTime.Now;
        DateTime haftaBit = DateTime.Now;

        string[] values = new string[2];
        string[] values2 = new string[2];

        public DateTime bas;
        public DateTime bit;
        public TimeSpan ts2;
        public TimeSpan ts;
        #endregion

        #region TimeSplit_
        protected void TimeSplit_()
        {
            values = comboBoxBaslangic.Text.Split(':');
            values2 = comboBoxBitis.Text.Split(':');

            ts = new TimeSpan(Convert.ToInt16(values[0]), Convert.ToInt16(values[1]), 0);
            ts2 = new TimeSpan(Convert.ToInt16(values2[0]), Convert.ToInt16(values2[1]), 0);

            bas = Convert.ToDateTime(dateTimeTarih.Text).Add(ts);
            bit = Convert.ToDateTime(dateTimeTarih.Text).Add(ts2);
        }
        #endregion

        #region Kaydet_
        protected void Kaydet_()
        {
            try
            {
                if ((dateTimeTarih.Value != null) && (textBoxYapilan.Text !="") && (comboBoxBaslangic.SelectedItem != null) && (comboBoxBitis.SelectedItem != null))
                {
                    TimeSplit_();

                    if ((Convert.ToInt16(values[0])) <= (Convert.ToInt16(values2[0])))
                    {
                        if ((Convert.ToInt16(values[1])) < (Convert.ToInt16(values2[1])))
                        {
                            string sorgu = "set language turkish INSERT INTO ArizaTakip.dbo.CZ_IS (TARIH,YAPILAN_IS,BASLANGIC_SAAT,BITIS_SAAT,KAYIT_TARIHI,PERSONEL_ID) VALUES (convert(DATETIME,'" + dateTimeTarih.Value + "',104) , '" + textBoxYapilan.Text + "' , CONVERT(DATETIME,'" + bas.ToString() + "',104) , CONVERT(DATETIME,'" + bit.ToString() + "',104), '" + DateTime.Now + "', '" + comboPersonel.SelectedValue + "')";
                            SqlCommand komut = new SqlCommand(sorgu, baglanti);
                            baglanti.Open();

                            int result = komut.ExecuteNonQuery();
                            if (result == 1)
                            {
                                MessageBox.Show("Eklendi.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Kayıt Eklenemedi.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }
                            baglanti.Close();
                            setTarihGetir();
                            setKisiGetir();
                        }
                        else
                        {
                            MessageBox.Show("Başlangıç Saati , Bitiş Saatinden Küçük veya Eşit Olamaz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Başlangıç Saati , Bitiş Saatinden Küçük veya Eşit Olamaz");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız!!!");
                }

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Update_
        protected void Update_()
        {
            try
            {
                
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Kayıt Güncellenecektir, Devam Etmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {

                        TimeSplit_();
                        SqlCommand komut = new SqlCommand("set language turkish UPDATE ArizaTakip.dbo.CZ_IS SET TARIH=@tarih,YAPILAN_IS=@yapilan_is,BASLANGIC_SAAT=@bas_saat,BITIS_SAAT=@bit_saat,KAYIT_TARIHI=@kayitTarihi WHERE ID=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", dataGridCizelge.CurrentRow.Cells[0].Value);
                        komut.Parameters.AddWithValue("@tarih", DateTime.Parse(dateTimeTarih.Text).ToString());
                        komut.Parameters.AddWithValue("@yapilan_is", textBoxYapilan.Text);
                        komut.Parameters.AddWithValue("@bas_saat", Convert.ToDateTime(dateTimeTarih.Text).Add(ts));
                        komut.Parameters.AddWithValue("@bit_saat", Convert.ToDateTime(dateTimeTarih.Text).Add(ts2));
                        komut.Parameters.AddWithValue("@kayitTarihi", DateTime.Now);

                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        int result = komut.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("Güncellendi.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Güncellenemedi.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        baglanti.Close();
                        setKisiGetir();
                    }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region Delete_
        protected void Delete_()
        {
            try
            {
                if (dataGridCizelge.RowCount != 0)
                {
                    DialogResult d = new DialogResult();
                    d = MessageBox.Show("Kayıt Silinecektir Devam Etmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);

                    if (d == DialogResult.Yes)
                    {
                        SqlCommand komut = new SqlCommand("DELETE FROM ArizaTakip.dbo.CZ_IS WHERE ID=@id", baglanti);
                        komut.Parameters.AddWithValue("@id", dataGridCizelge.CurrentRow.Cells[0].Value);

                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        int result = komut.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("Silindi.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Kayıt Silinemedi.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                        baglanti.Close();
                        setKisiGetir();
                    }
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İçin Lütfen Veri Seçiniz!!!");
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion
        private void Main_Load(object sender, EventArgs e)
        {

            this.Text = "Makine Ernerji Birimi Çizelge";
            dateTimeTarih.Value = DateTime.Now;
            baglanti = new SqlConnection(@"Data Source=10.0.0.13;Initial Catalog=ArizaTakip;User Id = sa;Password = q1w2e3R+:;");
            setPersonelGetir();

            setTarihGetir();
        }

        private void excelAktar()
        {
            
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Aktarıldı.";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = -1; i < dataGridCizelge.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridCizelge.Columns.Count; j++)
                    {
                        
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridCizelge.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridCizelge.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Excel'e Aktarıldı");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        } 
        private void setTarihGetir()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dateTimeTarih.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            lblHafta.Text = weekNum.ToString();

            haftaBas = WeekToDate(2018, weekNum);
            haftaBit = haftaBas.AddDays(6);
            
        }

        public static DateTime WeekToDate(int year, int weekOfYear)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(daysOffset);
            Calendar cal = dfi.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }
            var result = firstThursday.AddDays(weekNum * 7);
            return result.AddDays(-3);
            
        }
       

        private void setPersonelGetir()
        {
            try
            {
                string Sql = "select Id, Adi from ArizaTakip.dbo.ATTanimIcerik where TanimId=2 and Fabrika in (7)";


                SqlDataAdapter adp = new SqlDataAdapter(Sql, baglanti);
                DataTable dTable = new DataTable();
                adp.Fill(dTable);

                comboPersonel.DataSource = dTable;
                comboPersonel.ValueMember = "Id";
                comboPersonel.DisplayMember = "Adi";
                comboPersonel.Text = "";

            }
            catch (Exception)
            {           
                
            }
            
            
            
        }
        
        private void setKisiGetir()
        {
                try
                {
                    string komut = "select ISN.ID AS [Cizelge Numarasi],ISN.TARIH AS [Tarih],ISN.YAPILAN_IS AS [Yapilan Is],CONVERT(CHAR(5),ISN.BASLANGIC_SAAT,108) AS [Baslangic Saati],CONVERT(CHAR(5),ISN.BITIS_SAAT,108)AS [Bitis Saati],ISN.KAYIT_TARIHI AS [Kayit Tarihi] from ArizaTakip..CZ_IS ISN Left Outer join ArizaTakip.dbo.ATTanimIcerik p on ISN.PERSONEL_ID=p.ID where  p.TanimId=2 and p.Fabrika=7 and (ISN.TARIH between convert(datetime,'" + haftaBas + "',104) and convert(datetime,'" + haftaBit + "',104)) and p.ID ='" + comboPersonel.SelectedValue + "'";
                    
                    SqlDataAdapter adp = new SqlDataAdapter(komut, baglanti);
                    DataTable dTable = new DataTable();
                    adp.Fill(dTable);
                    dataGridCizelge.DataSource = dTable;
                    baglanti.Close();
                    toolStripStatusKayit.Text = "Kayıt Sayısı :" + dTable.Rows.Count.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }   
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Kaydet_();
        }



        private void buttonSil_Click(object sender, EventArgs e)
        {
            Delete_();

        }

  
        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Update_();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                dateTimeTarih.Value = Convert.ToDateTime(dataGridCizelge.CurrentRow.Cells[1].Value);
                textBoxYapilan.Text = dataGridCizelge.CurrentRow.Cells[2].Value.ToString();
                comboBoxBaslangic.Text = dataGridCizelge.CurrentRow.Cells[3].Value.ToString();
                comboBoxBitis.Text = dataGridCizelge.CurrentRow.Cells[4].Value.ToString();

                buttonGuncelle.Visible = true;
                buttonSil.Visible = true;
            }
            catch (Exception)
            { }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void comboPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboPersonel_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonGetir_Click(object sender, EventArgs e)
        {
            setKisiGetir();

            if (dataGridCizelge.RowCount != 0)
            {
                buttonExcel.Visible = true;
            }
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            sayac = Convert.ToInt16(lblHafta.Text);
            sayac--;
            lblHafta.Text = sayac.ToString();

            haftaBas = WeekToDate(2018, sayac);
            haftaBit = haftaBas.AddDays(6);
            
            setKisiGetir();

            if (dataGridCizelge.RowCount != 0)
            {
                buttonExcel.Visible = true;
            }

            else
            {
                buttonExcel.Visible = false;
            }
        }

        private void dateTimeTarih_ValueChanged(object sender, EventArgs e)
        {
            setTarihGetir();
        }

        private void buttonIleri_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            sayac = Convert.ToInt16(lblHafta.Text);
            sayac++;
            lblHafta.Text = sayac.ToString();

            haftaBas = WeekToDate(2018, sayac);
            haftaBit = haftaBas.AddDays(6);
            
            setKisiGetir();

            if (dataGridCizelge.RowCount != 0)
            {
                buttonExcel.Visible = true;
            }

            else
            {
                buttonExcel.Visible = false;
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            if (dataGridCizelge.Rows.Count > 0)
            {
                excelAktar();
            }
            else
                MessageBox.Show("Boş Olduğu için Aktarılamadı");
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kaydıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_();
        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_();
        }

        private void exceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridCizelge.Rows.Count > 0)
            {
                excelAktar();
            }
            else
                MessageBox.Show("Boş Olduğu için Aktarılamadı");
        }
    }
}
