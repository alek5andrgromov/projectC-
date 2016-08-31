using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace ORBK
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

         

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

  

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

      

        private void Form2_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet8.M9". При необходимости она может быть перемещена или удалена.
            this.m9TableAdapter.Fill(this.riskDBDataSet8.M9);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet7.M8". При необходимости она может быть перемещена или удалена.
            this.m8TableAdapter.Fill(this.riskDBDataSet7.M8);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet6.M7". При необходимости она может быть перемещена или удалена.
            this.m7TableAdapter.Fill(this.riskDBDataSet6.M7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet6.M7". При необходимости она может быть перемещена или удалена.
            this.m7TableAdapter.Fill(this.riskDBDataSet6.M7);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet5.M6". При необходимости она может быть перемещена или удалена.
            this.m6TableAdapter.Fill(this.riskDBDataSet5.M6);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet4.M5". При необходимости она может быть перемещена или удалена.
            this.m5TableAdapter.Fill(this.riskDBDataSet4.M5);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet3.M4". При необходимости она может быть перемещена или удалена.
            this.m4TableAdapter.Fill(this.riskDBDataSet3.M4);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet2.M3". При необходимости она может быть перемещена или удалена.
            this.m3TableAdapter.Fill(this.riskDBDataSet2.M3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet1.M2". При необходимости она может быть перемещена или удалена.
            this.m2TableAdapter.Fill(this.riskDBDataSet1.M2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet.М1". При необходимости она может быть перемещена или удалена.
            this.м1TableAdapter.Fill(this.riskDBDataSet.М1);

                       
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            результатыОценкиToolStripMenuItem.Enabled = false;
            this.м1DataGridView.Visible = false;
            this.м2DataGridView.Visible = false;
            this.м3DataGridView.Visible = false;
            this.м4DataGridView.Visible = false;
            this.м5DataGridView.Visible = false;
            this.м6DataGridView.Visible = false;
            this.м7DataGridView.Visible = false;
            this.м8DataGridView.Visible = false;
            this.м9DataGridView.Visible = false;

            label3.Visible = false; // общая оценка надпись таблица1
            label4.Visible = false; // общая оценка результат таблица1
            label51.Visible = false; // общая оценка результат таблица1
            button3.Visible = false; //кнопка следующая оценка таблица1
            button4.Visible = false; //кнопка следующая оценка таблица2
            label5.Visible = false; // общая оценка надпись таблица2
            label6.Visible = false; // общая оценка результат таблица2
            button6.Visible = false; //кнопка следующая оценка таблица3
            label10.Visible = false; // общая оценка надпись таблица3
            label11.Visible = false; // общая оценка результат таблица3
            button8.Visible = false; //кнопка следующая оценка таблица4
            label15.Visible = false; // общая оценка надпись таблица4
            label16.Visible = false; // общая оценка результат таблица4
            button20.Visible = false; //кнопка следующая оценка таблица5
            label46.Visible = false; // общая оценка надпись таблица5
            label47.Visible = false; // общая оценка результат таблица5
            button12.Visible = false; //кнопка следующая оценка таблица6
            label25.Visible = false; // общая оценка надпись таблица6
            label26.Visible = false; // общая оценка результат таблица6
            button14.Visible = false; //кнопка следующая оценка таблица7
            label30.Visible = false; // общая оценка надпись таблица7
            label31.Visible = false; // общая оценка результат таблица7
            button16.Visible = false; //кнопка следующая оценка таблица8
            label35.Visible = false; // общая оценка надпись таблица8
            label36.Visible = false; // общая оценка результат таблица8
            button18.Visible = false; //кнопка следующая оценка таблица9
            label40.Visible = false; // общая оценка надпись таблица9
            label41.Visible = false; // общая оценка результат таблица9
            radioButton4.Checked = true;
            radioButton7.Checked = true;
            radioButton11.Checked = true;
            radioButton15.Checked = true;
            radioButton57.Checked = true;
            radioButton23.Checked = true;
            radioButton27.Checked = true;
            radioButton31.Checked = true;
            radioButton35.Checked = true;

            button2.Enabled = true; // кнопка оценить риски
            button5.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
            button21.Enabled = false;
            button13.Enabled = false;
            button15.Enabled = false;
            button17.Enabled = false;
            button19.Enabled = false;
            label52.Visible = false; // результаты
            label53.Visible = false;
            label54.Visible = false;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;
            label70.Visible = false;
            label71.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1 таблица
            int idm = (int)this.м1DataGridView.CurrentRow.Cells[0].Value;
            if (idm == this.м1DataGridView.Rows.Count) // проверка на последнюю строку
            {

                Boolean mb1 = (Boolean)this.м1DataGridView.CurrentRow.Cells[3].Value;
                if (mb1 == true)   // проверка на строку и проверка на обязательность
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton2.Enabled = true;
                    radioButton37.Enabled = true;
                    radioButton38.Enabled = true;
                   
                    if (radioButton1.Checked)   // выбор оценки вероятности критерия
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton37.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton38.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton4.Checked)
                        {
                            if (this.м1DataGridView.CurrentRow != null)
                            {
                                this.м1DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м1DataGridView.CurrentRow.Cells[6].Value = 0; 
                            }

                        }
                    
                    radioButton4.Checked = true; // начальное значение оценки 0
                    this.м1DataGridView.Visible = true;
                    button2.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton2.Enabled = false;
                    radioButton37.Enabled = false;
                    radioButton38.Enabled = false;
                    
                    if (radioButton1.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton4.Checked)
                        {
                            if (this.м1DataGridView.CurrentRow != null)
                            {
                                this.м1DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м1DataGridView.CurrentRow.Cells[6].Value = 0; 
                            }
                            
                        }

                }

                    this.Validate();
                    this.м1BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.riskDBDataSet);
                    this.м1TableAdapter.Fill(this.riskDBDataSet.М1);   // обновление данных
                   

                    this.м1DataGridView.Visible = true;
                    button3.Visible = true;   //кнопка следующая оценка
                    button2.Enabled = false;
                    radioButton4.Checked = true;// начальное значение оценки 0
                    //подсчет общей суммы меняется строки

                    //string a = this.м1DataGridView.CurrentRow.Cells[5].Value.ToString();
                  //  string a1 = this.м1DataGridView.Rows[0].Cells[5].Value.ToString();
                  //  float a2= float.Parse(a1); //преобразование типа

                  //  string a3 = this.м1DataGridView.Rows[1].Cells[5].Value.ToString();
                   // float a4 = float.Parse(a3);
                    //double b1 = Convert.ToDouble(b);
                   // string a5 = this.м1DataGridView.Rows[2].Cells[5].Value.ToString();
                  //  float a6 = float.Parse(a5);
                    //  double c1 = Convert.ToDouble(c);
                  //  string a7 = this.м1DataGridView.Rows[3].Cells[5].Value.ToString();
                   // float a8 = float.Parse(a7);
                    // double d1 = Convert.ToDouble(a);
                  //  string a9 = this.м1DataGridView.Rows[4].Cells[5].Value.ToString();
                   // float a10 = float.Parse(a9);
                   // string a11 = this.м1DataGridView.Rows[5].Cells[5].Value.ToString();
                   // float a12 = float.Parse(a11);
                   // string a11 = this.м1DataGridView.Rows[6].Cells[5].Value.ToString();
                  //  float a12 = float.Parse(a11);
                                   
                    //double r = a1 + b1 + c1 + d1;

                    float s;
                    float sum = 0;
                  
                        for (int i = 0; i < this.м1DataGridView.Rows.Count; i++)
                        {
                            if (this.м1DataGridView.Rows[i].Cells[5].Value != null)
                            {
                            s = Convert.ToSingle(this.м1DataGridView.Rows[i].Cells[5].Value);
                            sum += s;
                            label4.Text = sum.ToString();
                        }
                    }
                    label51.Visible = true;
                    label4.Visible = true; 
                
            }
            else
            {
              //подсчет не последней строки
              // Boolean mb = (Boolean)this.м1DataGridView.CurrentRow.Cells[3].Value;
              //  if (mb == true)
                int mb = (int)this.м1DataGridView.CurrentRow.Cells[0].Value;
              if (mb != 3) 
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton2.Enabled = true;
                    radioButton37.Enabled = true;
                    radioButton38.Enabled = true;
                  
                    if (radioButton1.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton37.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton38.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton4.Checked)
                        {
                            if (this.м1DataGridView.CurrentRow != null)
                            {
                                this.м1DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м1DataGridView.CurrentRow.Cells[6].Value = 0; 
                            }

                        }
                    radioButton4.Checked = true;   // начальное значение оценки 0
                   
                    //переход на следующую строку
                    //Select the next item
                    int index = this.м1DataGridView.CurrentRow.Index + 1;
                    index = index % this.м1DataGridView.Rows.Count;
                    this.м1DataGridView.CurrentCell = this.м1DataGridView.Rows[index].Cells[this.м1DataGridView.CurrentCell.ColumnIndex];
                   
                }
                else
                {
                  // скрытие и вскрытие рекомендуемых оценок
                    radioButton2.Enabled = false;
                    radioButton37.Enabled = false;
                    radioButton38.Enabled = false;

                    if (radioButton1.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton37.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton38.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton3.Checked)
                    {
                        if (this.м1DataGridView.CurrentRow != null)
                        {
                            this.м1DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м1DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton4.Checked)
                        {
                            if (this.м1DataGridView.CurrentRow != null)
                            {
                                this.м1DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м1DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton4.Checked = true;  // начальное значение оценки 0
                    //переход на следующую строку
                    //Select the next item
                    int index = this.м1DataGridView.CurrentRow.Index + 1;
                    index = index % this.м1DataGridView.Rows.Count;
                    this.м1DataGridView.CurrentCell = this.м1DataGridView.Rows[index].Cells[this.м1DataGridView.CurrentCell.ColumnIndex];
                   
                   
                }
             
            }
        }
    

        private void button3_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
            button5.Enabled = true;
        }

     
        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void определениеПотенциальныхБезопасныхЗонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage6"];
        }

        private void анализПолитикиБезопасностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
        }

        private void анализСтруктурыСетиИИхПрименениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void идентификацияТиповСоединенияСетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
        }

        private void анализХарактеристикСетиИCвязанныхСНимиДоверительныхОтношенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }

        private void определениеВидовРисковБезопасностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage5"];
        }

        private void физическаяБезопасностьИБезопасностьОтВоздействийОкружающейСредыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage7"];
        }

        private void документацияИАнализСтруктурБезопасностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage8"];
        }

        private void общиеТребованияПоОбработкеПерсональныхДанныхВОрганизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage9"];
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "helpRisk.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 fa = new AboutBox1();
            fa.ShowDialog();
        }

        private void результатыОценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label52.Visible = true; // результаты
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            label56.Visible = true;
            label57.Visible = true;
            label58.Visible = true;
            label59.Visible = true;
            label66.Visible = true;
            label67.Visible = true;
            label68.Visible = true;
            label69.Visible = true;
            label70.Visible = true;
            label71.Visible = true;  

            string s = " ";
            if (label4.Text != s & label5.Text != s & label10.Text != s & label15.Text != s & label46.Text != s &
                label25.Text != s & label30.Text != s & label35.Text != s & label40.Text != s)
            {
                // вычисление уровней
                label52.Text = label4.Text;          //1
                float c = float.Parse(label52.Text);
                float a1 = float.Parse(label5.Text); //2
                float a2 = float.Parse(label10.Text);
                float a3 = float.Parse(label15.Text);
                float a = (a1 + a2 + a3) / 3;
                label53.Text = a.ToString();
                label54.Text = label46.Text;          //3
                float d = float.Parse(label54.Text);
                float b1 = float.Parse(label25.Text); //4
                float b2 = float.Parse(label30.Text);
                float b = (b1 + b2) / 2;
                label55.Text = b.ToString();
                label56.Text = label35.Text;          //5
                float g = float.Parse(label56.Text);
                label57.Text = label40.Text;          //ПДн
                float h = float.Parse(label57.Text);

                float[] array = new float[6] { a, b, c, d, g, h }; //объявили одномерный массив из 6 интенджеровских чисел. 
                float min; // здесь будет храниться минимальное число массива

                min = array[0];  //минимальное значение в начале равно первому элементу массива. Это логично я думаю и понятно всем.
                for (int i = 1; i != 6; i++)
                {
                    if (array[i] < min)//если текущий элемент меньше минимального, то он становится минимальным.
                    {
                        min = array[i];
                    }
                }
                // итоговая оценка
                label59.Text = min.ToString();
                float a11 = 100 * float.Parse(label59.Text);
                int a111 = (int)a11;
                int b11 = 0;
                int c11 = 25;
                int d11 = 50;
                int f11 = 75;
                int g11 = 100;

                if (a111 >= b11 & a111 <= c11)   // от 0 до 25
                {
                    label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a111 >= c11 & a111 <= d11)   // от 25 до 50
                {
                    label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a111 >= d11 & a111 <= f11)    // от 50 до 75
                {
                    label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a111 >= f11 & a111 <= g11)    // от 75 до 100
                {
                    label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }
                // aotd1
                float a12 = 100 * float.Parse(label52.Text);
                int a112 = (int)a12;
                int b12 = 0;
                int c12 = 25;
                int d12 = 50;
                int f12 = 75;
                int g12 = 100;

                if (a112 >= b12 & a112 <= c12)   // от 0 до 25
                {
                    label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a112 >= c12 & a112 <= d12)   // от 25 до 50
                {
                    label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a112 >= d12 & a112 <= f12)    // от 50 до 75
                {
                    label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a112 >= f12 & a112 <= g12)    // от 75 до 100
                {
                    label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }

                // aotd2
                float a13 = 100 * float.Parse(label53.Text);
                int a113 = (int)a13;
                int b13 = 0;
                int c13 = 25;
                int d13 = 50;
                int f13 = 75;
                int g13 = 100;

                if (a113 >= b13 & a113 <= c13)   // от 0 до 25
                {
                    label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a113 >= c13 & a113 <= d13)   // от 25 до 50
                {
                    label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a113 >= d13 & a113 <= f13)    // от 50 до 75
                {
                    label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a113 >= f13 & a113 <= g13)    // от 75 до 100
                {
                    label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }
                // aotd3
                float a14 = 100 * float.Parse(label54.Text);
                int a114 = (int)a14;
                int b14 = 0;
                int c14 = 25;
                int d14 = 50;
                int f14 = 75;
                int g14 = 100;

                if (a114 >= b14 & a114 <= c14)   // от 0 до 25
                {
                    label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a114 >= c14 & a114 <= d14)   // от 25 до 50
                {
                    label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a114 >= d14 & a114 <= f14)    // от 50 до 75
                {
                    label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a114 >= f14 & a114 <= g14)    // от 75 до 100
                {
                    label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }

                // aotd4
                float a15 = 100 * float.Parse(label55.Text);
                int a115 = (int)a15;
                int b15 = 0;
                int c15 = 25;
                int d15 = 50;
                int f15 = 75;
                int g15 = 100;

                if (a115 >= b15 & a115 <= c15)   // от 0 до 25
                {
                    label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a115 >= c15 & a115 <= d15)   // от 25 до 50
                {
                    label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a115 >= d15 & a115 <= f15)    // от 50 до 75
                {
                    label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a115 >= f15 & a115 <= g15)    // от 75 до 100
                {
                    label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }

                // aotd5
                float a16 = 100 * float.Parse(label56.Text);
                int a116 = (int)a16;
                int b16 = 0;
                int c16 = 25;
                int d16 = 50;
                int f16 = 75;
                int g16 = 100;

                if (a116 >= b16 & a116 <= c16)   // от 0 до 25
                {
                    label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a116 >= c16 & a115 <= d16)   // от 25 до 50
                {
                    label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a116 >= d16 & a116 <= f16)    // от 50 до 75
                {
                    label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a116 >= f16 & a116 <= g16)    // от 75 до 100
                {
                    label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }

                // aotdПДн
                float a17 = 100 * float.Parse(label57.Text);
                int a117 = (int)a17;
                int b17 = 0;
                int c17 = 25;
                int d17 = 50;
                int f17 = 75;
                int g17 = 100;

                if (a117 >= b17 & a117 <= c17)   // от 0 до 25
                {
                    label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                          "не установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a117 >= c17 & a117 <= d17)   // от 25 до 50
                {
                    label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                   "частично установлены во внутренних документах проверяемой организации и не выполняется";
                }
                else if (a117 >= d17 & a117 <= f17)    // от 50 до 75
                {
                    label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                    "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                }
                else if (a117 >= f17 & a117 <= g17)    // от 75 до 100
                {
                    label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                }

                tabControl1.SelectedTab = tabControl1.TabPages["tabPage10"];

            }
            else
            {
                MessageBox.Show("Выполните все оценки");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage3"];
            button7.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
            button9.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage5"];
            button21.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage6"];
            button13.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage7"];
            button15.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage8"];
            button17.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage9"];
            button19.Enabled = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            // 2 таблица
            // проверка на строку и проверка на обязательность
            int idm2 = (int)this.м2DataGridView.CurrentRow.Cells[0].Value;
            if (idm2 == this.м2DataGridView.Rows.Count) // строка надо изменить
            {
                Boolean mb2 = (Boolean)this.м2DataGridView.CurrentRow.Cells[3].Value;
                if (mb2 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton6.Enabled = true;
                    radioButton39.Enabled = true;
                    radioButton5.Enabled = true;

                    if (radioButton40.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton6.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton39.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton5.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton8.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton7.Checked)
                        {
                            if (this.м2DataGridView.CurrentRow != null)
                            {
                                this.м2DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton7.Checked = true;  // начальное значение оценки 0
                    this.м2DataGridView.Visible = true;
                    button5.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton6.Enabled = false;
                    radioButton39.Enabled = false;
                    radioButton5.Enabled = false;

                    if (radioButton40.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton8.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton7.Checked)
                        {
                            if (this.м2DataGridView.CurrentRow != null)
                            {
                                this.м2DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                }

                this.Validate();
                this.m2BindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.riskDBDataSet1);
                this.m2TableAdapter.Fill(this.riskDBDataSet1.M2); // обновление данных
                // this.м1DataGridView.CurrentCell = this.м1DataGridView[this.м1DataGridView.CurrentRow.Index, this.м1DataGridView.ColumnCount-1]; // последняя строка
                //this.м1DataGridView.Rows[0].Cells[15].Selected = true;
                //this.м1DataGridView.CurrentCell = this.м1DataGridView[14, 0];  

                this.м2DataGridView.Visible = true;
                button4.Visible = true;   //кнопка следующая оценка
                radioButton7.Checked = true;// начальное значение оценки 0
                button5.Enabled = false;
                //подсчет общей суммы меняется строки
                    float s;
                float sum = 0;

                for (int i = 0; i < this.м2DataGridView.Rows.Count; i++)
                {
                    if (this.м2DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м2DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label5.Text = sum.ToString();
                    }
                }
                label5.Visible = true;
                label6.Visible = true;

            }
            else
            {
                Boolean mb = (Boolean)this.м2DataGridView.CurrentRow.Cells[3].Value;
                if (mb == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton6.Enabled = true;
                    radioButton39.Enabled = true;
                    radioButton5.Enabled = true;

                    if (radioButton40.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton6.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton39.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton5.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton8.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton7.Checked)
                        {
                            if (this.м2DataGridView.CurrentRow != null)
                            {
                                this.м2DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    
                    radioButton7.Checked = true;  // начальное значение оценки 0
                    
                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м2DataGridView.CurrentRow.Index + 1;
                    index = index % this.м2DataGridView.Rows.Count;
                    this.м2DataGridView.CurrentCell = this.м2DataGridView.Rows[index].Cells[this.м2DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton6.Enabled = false;
                    radioButton39.Enabled = false;
                    radioButton5.Enabled = false;

                    if (radioButton40.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton8.Checked)
                    {
                        if (this.м2DataGridView.CurrentRow != null)
                        {
                            this.м2DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м2DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton7.Checked)
                        {
                            if (this.м2DataGridView.CurrentRow != null)
                            {
                                this.м2DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м2DataGridView.CurrentRow.Cells[6].Value = 0; 
                            }

                        }
                    radioButton7.Checked = true; // начальное значение оценки 0
                    
                    //переход на следующую строку
                    //Select the next item
                    int index = this.м2DataGridView.CurrentRow.Index + 1;
                    index = index % this.м2DataGridView.Rows.Count;
                    this.м2DataGridView.CurrentCell = this.м2DataGridView.Rows[index].Cells[this.м2DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  

                }


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 3 таблица
             // проверка на строку и проверка на обязательность
            int idm3 = (int)this.м3DataGridView.CurrentRow.Cells[0].Value;
            if (idm3 == this.м3DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb3 = (Boolean)this.м3DataGridView.CurrentRow.Cells[3].Value;
                if (mb3 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton10.Enabled = true;
                    radioButton41.Enabled = true;
                    radioButton9.Enabled = true;

                    if (radioButton42.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton10.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton41.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton9.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton12.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton11.Checked)
                        {
                            if (this.м3DataGridView.CurrentRow != null)
                            {
                                this.м3DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton11.Checked = true;  // начальное значение оценки 0
                    this.м3DataGridView.Visible = true;
                    button7.Enabled = false;
                }
                else
                {
                      // скрытие и вскрытие рекомендуемых оценок
                        radioButton10.Enabled = false;
                        radioButton41.Enabled = false;
                        radioButton9.Enabled = false;

                        if (radioButton42.Checked)
                        {
                            if (this.м3DataGridView.CurrentRow != null)
                            {
                                this.м3DataGridView.CurrentRow.Cells[2].Value = "0";
                                this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                            }
                        }
                        else if (radioButton12.Checked)
                        {
                            if (this.м3DataGridView.CurrentRow != null)
                            {
                                this.м3DataGridView.CurrentRow.Cells[2].Value = "1";
                                this.м3DataGridView.CurrentRow.Cells[6].Value = 1;
                            }
                        }
                        else
                            if (radioButton11.Checked)
                            {
                                if (this.м3DataGridView.CurrentRow != null)
                                {
                                    this.м3DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                    this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                                }

                            }

                    }

                    this.Validate();
                    this.m3BindingSource.EndEdit();
                    this.tableAdapterManager2.UpdateAll(this.riskDBDataSet2);
                    this.m3TableAdapter.Fill(this.riskDBDataSet2.M3);   // обновление данных
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[this.м1DataGridView.CurrentRow.Index, this.м1DataGridView.ColumnCount-1]; // последняя строка
                    //this.м1DataGridView.Rows[0].Cells[15].Selected = true;
                    //this.м1DataGridView.CurrentCell = this.м1DataGridView[14, 0];  

                    this.м3DataGridView.Visible = true;
                    button6.Visible = true;   //кнопка следующая оценка
                    radioButton11.Checked = true;// начальное значение оценки 0
                    button7.Enabled = false;
                    //подсчет общей суммы меняется строки
                    float s;
                    float sum = 0;

                    for (int i = 0; i < this.м3DataGridView.Rows.Count; i++)
                    {
                       // if (this.м3DataGridView.Rows[i].Cells[5].Value != null)
                      //  {
                            s = Convert.ToSingle(this.м3DataGridView.Rows[i].Cells[5].Value);
                            sum += s;
                            label10.Text = sum.ToString();
                       // }
                    }
                
                    label10.Visible = true;
                    label11.Visible = true;
                
            }
            else
            {
             //   Boolean mb = (Boolean)this.м3DataGridView.CurrentRow.Cells[3].Value;
              //  if (mb == true)
                int mb3 = (int)this.м3DataGridView.CurrentRow.Cells[0].Value;
          
                if (!((mb3 == 3) ||  (mb3 == 4) || (mb3 == 5)))
                   {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton10.Enabled = true;
                    radioButton41.Enabled = true;
                    radioButton9.Enabled = true;

                    if (radioButton42.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton10.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton41.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton9.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton12.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton11.Checked)
                        {
                            if (this.м3DataGridView.CurrentRow != null)
                            {
                                this.м3DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    
                    radioButton11.Checked = true;  // начальное значение оценки 0
                    
                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м3DataGridView.CurrentRow.Index + 1;
                    index = index % this.м3DataGridView.Rows.Count;
                    this.м3DataGridView.CurrentCell = this.м3DataGridView.Rows[index].Cells[this.м3DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton10.Enabled = false;
                    radioButton41.Enabled = false;
                    radioButton9.Enabled = false;

                    if (radioButton42.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton10.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton41.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton9.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton12.Checked)
                    {
                        if (this.м3DataGridView.CurrentRow != null)
                        {
                            this.м3DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м3DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton11.Checked)
                        {
                            if (this.м3DataGridView.CurrentRow != null)
                            {
                                this.м3DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м3DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton11.Checked = true; // начальное значение оценки 0
                    
                    //переход на следующую строку
                    //Select the next item
                    int index = this.м3DataGridView.CurrentRow.Index + 1;
                    index = index % this.м3DataGridView.Rows.Count;
                    this.м3DataGridView.CurrentCell = this.м3DataGridView.Rows[index].Cells[this.м3DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  

                }            
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           // if (result == DialogResult.No) //Если нажал нет
           // {
            //    MessageBox.Show("vbbook.ru не нравиться");
           // }

            if (result == DialogResult.Yes) //Если нажал Да
            {
                Application.Exit();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // 4 таблица
            // проверка на строку и проверка на обязательность
            int idm4 = (int)this.м4DataGridView.CurrentRow.Cells[0].Value;
            if (idm4 == this.м4DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb4 = (Boolean)this.м4DataGridView.CurrentRow.Cells[3].Value;
                if (mb4 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton14.Enabled = true;
                    radioButton43.Enabled = true;
                    radioButton13.Enabled = true;

                    if (radioButton44.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton14.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton43.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton13.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton16.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton15.Checked)
                        {
                            if (this.м4DataGridView.CurrentRow != null)
                            {
                                this.м4DataGridView.CurrentRow.Cells[2].Value = "H/O";
                               this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton15.Checked = true;  // начальное значение оценки 0
                    this.м4DataGridView.Visible = true;
                    button9.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton14.Enabled = false;
                    radioButton43.Enabled = false;
                    radioButton13.Enabled = false;

                    if (radioButton44.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton14.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton43.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton13.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton16.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton15.Checked)
                        {
                            if (this.м4DataGridView.CurrentRow != null)
                            {
                                this.м4DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                }

                this.Validate();
                this.m4BindingSource.EndEdit();
                this.tableAdapterManager3.UpdateAll(this.riskDBDataSet3);
                this.m4TableAdapter.Fill(this.riskDBDataSet3.M4);   // обновление данных
    

                this.м4DataGridView.Visible = true;
                button8.Visible = true;   //кнопка следующая оценка
                radioButton15.Checked = true;// начальное значение оценки 0
                button9.Enabled = false;
                //подсчет общей суммы меняется строки
                float s;
                float sum = 0;

                for (int i = 0; i < this.м4DataGridView.Rows.Count; i++)
                {
                    if (this.м4DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м4DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label15.Text = sum.ToString();
                    }
                }

                label15.Visible = true;
                label16.Visible = true;

            }
            else
            {
              Boolean mb4 = (Boolean)this.м4DataGridView.CurrentRow.Cells[3].Value;
                if (mb4 == true)
                  {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton14.Enabled = true;
                    radioButton43.Enabled = true;
                    radioButton13.Enabled = true;

                    if (radioButton44.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton14.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton43.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton13.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton16.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton15.Checked)
                        {
                            if (this.м4DataGridView.CurrentRow != null)
                            {
                                this.м4DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                    radioButton15.Checked = true;  // начальное значение оценки 0

                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м4DataGridView.CurrentRow.Index + 1;
                    index = index % this.м4DataGridView.Rows.Count;
                    this.м4DataGridView.CurrentCell = this.м4DataGridView.Rows[index].Cells[this.м4DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton14.Enabled = false;
                    radioButton43.Enabled = false;
                    radioButton13.Enabled = false;

                    if (radioButton44.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton14.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton43.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton13.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton16.Checked)
                    {
                        if (this.м4DataGridView.CurrentRow != null)
                        {
                            this.м4DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м4DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton15.Checked)
                        {
                            if (this.м4DataGridView.CurrentRow != null)
                            {
                                this.м4DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м4DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton15.Checked = true; // начальное значение оценки 0

                    //переход на следующую строку
                    //Select the next item
                    int index = this.м4DataGridView.CurrentRow.Index + 1;
                    index = index % this.м4DataGridView.Rows.Count;
                    this.м4DataGridView.CurrentCell = this.м4DataGridView.Rows[index].Cells[this.м4DataGridView.CurrentCell.ColumnIndex];
               
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // 5 таблица
            // проверка на строку и проверка на обязательность
            int idm5 = (int)this.м5DataGridView.CurrentRow.Cells[0].Value;
            if (idm5 == this.м5DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb5 = (Boolean)this.м5DataGridView.CurrentRow.Cells[3].Value;
                if (mb5 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton56.Enabled = true;
                    radioButton59.Enabled = true;
                    radioButton55.Enabled = true;

                    if (radioButton60.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton56.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton59.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton55.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton58.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton57.Checked)
                        {
                            if (this.м5DataGridView.CurrentRow != null)
                            {
                                this.м5DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton57.Checked = true;  // начальное значение оценки 0
                    this.м5DataGridView.Visible = true;
                    button21.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton56.Enabled = false;
                    radioButton59.Enabled = false;
                    radioButton55.Enabled = false;

                    if (radioButton60.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton56.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton59.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton55.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton58.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton57.Checked)
                        {
                            if (this.м5DataGridView.CurrentRow != null)
                            {
                                this.м5DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                }

                this.Validate();
                this.m5BindingSource.EndEdit();
                this.tableAdapterManager4.UpdateAll(this.riskDBDataSet4);
                this.m5TableAdapter.Fill(this.riskDBDataSet4.M5);   // обновление данных


                this.м5DataGridView.Visible = true;
                button20.Visible = true;   //кнопка следующая оценка
                radioButton57.Checked = true;// начальное значение оценки 0
                button21.Enabled = false;
                //подсчет общей суммы меняется строки
                float s;
                float sum = 0;

                for (int i = 0; i < this.м5DataGridView.Rows.Count; i++)
                {
                    if (this.м5DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м5DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label46.Text = sum.ToString();
                    }
                }

                label46.Visible = true;
                label47.Visible = true;

            }
            else
            {
                   int mb5 = (int)this.м5DataGridView.CurrentRow.Cells[0].Value;

                   if (!((mb5 == 6) || (mb5 == 10) || (mb5 == 12) || (mb5 == 13)))
                   
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton56.Enabled = true;
                    radioButton59.Enabled = true;
                    radioButton55.Enabled = true;

                    if (radioButton60.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton56.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton59.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton55.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton58.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton57.Checked)
                        {
                            if (this.м5DataGridView.CurrentRow != null)
                            {
                                this.м5DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                    radioButton57.Checked = true;  // начальное значение оценки 0

                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м5DataGridView.CurrentRow.Index + 1;
                    index = index % this.м5DataGridView.Rows.Count;
                    this.м5DataGridView.CurrentCell = this.м5DataGridView.Rows[index].Cells[this.м5DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton56.Enabled = false;
                    radioButton59.Enabled = false;
                    radioButton55.Enabled = false;

                    if (radioButton60.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton56.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton59.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton55.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton58.Checked)
                    {
                        if (this.м5DataGridView.CurrentRow != null)
                        {
                            this.м5DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м5DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton57.Checked)
                        {
                            if (this.м5DataGridView.CurrentRow != null)
                            {
                                this.м5DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м5DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton57.Checked = true; // начальное значение оценки 0

                    //переход на следующую строку
                    //Select the next item
                    int index = this.м5DataGridView.CurrentRow.Index + 1;
                    index = index % this.м5DataGridView.Rows.Count;
                    this.м5DataGridView.CurrentCell = this.м5DataGridView.Rows[index].Cells[this.м5DataGridView.CurrentCell.ColumnIndex];

                }
            
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 6 таблица
            // проверка на строку и проверка на обязательность
            int idm6 = (int)this.м6DataGridView.CurrentRow.Cells[0].Value;
            if (idm6 == this.м6DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb6 = (Boolean)this.м6DataGridView.CurrentRow.Cells[3].Value;
                if (mb6 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton22.Enabled = true;
                    radioButton47.Enabled = true;
                    radioButton21.Enabled = true;

                    if (radioButton48.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton22.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton47.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton21.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton24.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton23.Checked)
                        {
                            if (this.м6DataGridView.CurrentRow != null)
                            {
                                this.м6DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton23.Checked = true;  // начальное значение оценки 0
                    this.м6DataGridView.Visible = true;
                    button13.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton22.Enabled = false;
                    radioButton47.Enabled = false;
                    radioButton21.Enabled = false;

                    if (radioButton48.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton22.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton47.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton21.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton24.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton23.Checked)
                        {
                            if (this.м6DataGridView.CurrentRow != null)
                            {
                                this.м6DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                }

                this.Validate();
                this.m6BindingSource.EndEdit();
                this.tableAdapterManager5.UpdateAll(this.riskDBDataSet5);
                this.m6TableAdapter.Fill(this.riskDBDataSet5.M6);   // обновление данных


                this.м6DataGridView.Visible = true;
                button12.Visible = true;   //кнопка следующая оценка
                radioButton23.Checked = true;// начальное значение оценки 0
                button13.Enabled = false;
                //подсчет общей суммы меняется строки
                float s;
                float sum = 0;

                for (int i = 0; i < this.м6DataGridView.Rows.Count; i++)
                {
                    if (this.м6DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м6DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label25.Text = sum.ToString();
                    }
                }

                label25.Visible = true;
                label26.Visible = true;

            }
            else
            {
                // необязательные оценки
                int mb6 = (int)this.м6DataGridView.CurrentRow.Cells[0].Value;

                if (!((mb6 == 3) || (mb6 == 4) || (mb6 == 5) || (mb6 == 6)||(mb6 == 7) || (mb6 == 8) || (mb6 == 9) || (mb6 == 11) ||
                     (mb6 == 12) || (mb6 == 13) || (mb6 == 14) || (mb6 == 15) || (mb6 == 16) || (mb6 == 18) || (mb6 == 19)||
                     (mb6 == 23) || (mb6 == 28)))
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton22.Enabled = true;
                    radioButton47.Enabled = true;
                    radioButton21.Enabled = true;

                    if (radioButton48.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton22.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton47.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton21.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton24.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton23.Checked)
                        {
                            if (this.м6DataGridView.CurrentRow != null)
                            {
                                this.м6DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                    radioButton23.Checked = true;  // начальное значение оценки 0

                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м6DataGridView.CurrentRow.Index + 1;
                    index = index % this.м6DataGridView.Rows.Count;
                    this.м6DataGridView.CurrentCell = this.м6DataGridView.Rows[index].Cells[this.м6DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton22.Enabled = false;
                    radioButton47.Enabled = false;
                    radioButton21.Enabled = false;

                    if (radioButton48.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton22.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton47.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton21.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton24.Checked)
                    {
                        if (this.м6DataGridView.CurrentRow != null)
                        {
                            this.м6DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м6DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton23.Checked)
                        {
                            if (this.м6DataGridView.CurrentRow != null)
                            {
                                this.м6DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м6DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton23.Checked = true; // начальное значение оценки 0

                    //переход на следующую строку
                    //Select the next item
                    int index = this.м6DataGridView.CurrentRow.Index + 1;
                    index = index % this.м6DataGridView.Rows.Count;
                    this.м6DataGridView.CurrentCell = this.м6DataGridView.Rows[index].Cells[this.м6DataGridView.CurrentCell.ColumnIndex];

                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
         // 7 таблица
            // проверка на строку и проверка на обязательность
            int idm7 = (int)this.м7DataGridView.CurrentRow.Cells[0].Value;
            if (idm7 == this.м7DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb7 = (Boolean)this.м7DataGridView.CurrentRow.Cells[3].Value;
                if (mb7 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton26.Enabled = true;
                    radioButton49.Enabled = true;
                    radioButton25.Enabled = true;

                    if (radioButton50.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton26.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton49.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton25.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton28.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton27.Checked)
                        {
                            if (this.м7DataGridView.CurrentRow != null)
                            {
                                this.м7DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton27.Checked = true;  // начальное значение оценки 0
                    this.м7DataGridView.Visible = true;
                    button15.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton26.Enabled = false;
                    radioButton49.Enabled = false;
                    radioButton25.Enabled = false;

                   if (radioButton50.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton26.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton49.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton25.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton28.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton27.Checked)
                        {
                            if (this.м7DataGridView.CurrentRow != null)
                            {
                                this.м7DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                            }
                        }

                }

                this.Validate();
                this.m7BindingSource.EndEdit();
                this.tableAdapterManager6.UpdateAll(this.riskDBDataSet6);
                this.m7TableAdapter.Fill(this.riskDBDataSet6.M7);   // обновление данных


                this.м7DataGridView.Visible = true;
                button14.Visible = true;   //кнопка следующая оценка
                radioButton27.Checked = true;// начальное значение оценки 0
                button15.Enabled = false;
                //подсчет общей суммы меняется строки
                float s;
                float sum = 0;

                for (int i = 0; i < this.м7DataGridView.Rows.Count; i++)
                {
                    if (this.м7DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м7DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label30.Text = sum.ToString();
                    }
                }

                label30.Visible = true;
                label31.Visible = true;

            }
            else
            {
                // необязательные оценки
                int mb7 = (int)this.м7DataGridView.CurrentRow.Cells[0].Value;

                if (!((mb7 == 3) || (mb7 == 4) || (mb7 == 5) || (mb7 == 6)||(mb7 == 7) || (mb7 == 12) || (mb7 == 13) || (mb7 == 14) ||
                      (mb7 == 15) || (mb7 == 16) || (mb7 == 17) || (mb7 == 18) || (mb7 == 19) || (mb7 == 20) || (mb7 == 21)||
                      (mb7 == 28) || (mb7 == 29) || (mb7 == 30) || (mb7 == 31) || (mb7 == 32) || (mb7 == 34) || (mb7 == 35)||
                      (mb7 == 36) || (mb7 == 37) || (mb7 == 38) || (mb7 == 39) || (mb7 == 40) || (mb7 == 43) || (mb7 == 44)||
                      (mb7 == 45) || (mb7 == 51) || (mb7 == 52) || (mb7 == 53) || (mb7 == 54) || (mb7 == 64)))
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton26.Enabled = true;
                    radioButton49.Enabled = true;
                    radioButton25.Enabled = true;

                    if (radioButton50.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton26.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton49.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton25.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton28.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton27.Checked)
                        {
                            if (this.м7DataGridView.CurrentRow != null)
                            {
                                this.м7DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                    radioButton27.Checked = true;  // начальное значение оценки 0

                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м7DataGridView.CurrentRow.Index + 1;
                    index = index % this.м7DataGridView.Rows.Count;
                    this.м7DataGridView.CurrentCell = this.м7DataGridView.Rows[index].Cells[this.м7DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton26.Enabled = false;
                    radioButton49.Enabled = false;
                    radioButton25.Enabled = false;

                    if (radioButton50.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton26.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton49.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton25.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton28.Checked)
                    {
                        if (this.м7DataGridView.CurrentRow != null)
                        {
                            this.м7DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м7DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton27.Checked)
                        {
                            if (this.м7DataGridView.CurrentRow != null)
                            {
                                this.м7DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м7DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton27.Checked = true; // начальное значение оценки 0

                    //переход на следующую строку
                    //Select the next item
                    int index = this.м7DataGridView.CurrentRow.Index + 1;
                    index = index % this.м7DataGridView.Rows.Count;
                    this.м7DataGridView.CurrentCell = this.м7DataGridView.Rows[index].Cells[this.м7DataGridView.CurrentCell.ColumnIndex];

                }

                      

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // 8 таблица
            // проверка на строку и проверка на обязательность
            int idm8 = (int)this.м8DataGridView.CurrentRow.Cells[0].Value;
            if (idm8 == this.м8DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb8 = (Boolean)this.м8DataGridView.CurrentRow.Cells[3].Value;
                if (mb8 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton30.Enabled = true;
                    radioButton51.Enabled = true;
                    radioButton29.Enabled = true;

                    if (radioButton52.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton30.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton51.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton29.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton32.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton31.Checked)
                        {
                            if (this.м8DataGridView.CurrentRow != null)
                            {
                                this.м8DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton31.Checked = true;  // начальное значение оценки 0
                    this.м8DataGridView.Visible = true;
                    button17.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton30.Enabled = false;
                    radioButton51.Enabled = false;
                    radioButton29.Enabled = false;

                    if (radioButton52.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton30.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton51.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton29.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton32.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton31.Checked)
                        {
                            if (this.м8DataGridView.CurrentRow != null)
                            {
                                this.м8DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                }

                this.Validate();
                this.m8BindingSource.EndEdit();
                this.tableAdapterManager7.UpdateAll(this.riskDBDataSet7);
                this.m8TableAdapter.Fill(this.riskDBDataSet7.M8);   // обновление данных
                
                this.м8DataGridView.Visible = true;
                button16.Visible = true;   //кнопка следующая оценка
                radioButton31.Checked = true;// начальное значение оценки 0
                button17.Enabled = false;
                //подсчет общей суммы меняется строки
                float s;
                float sum = 0;

                for (int i = 0; i < this.м8DataGridView.Rows.Count; i++)
                {
                    if (this.м8DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м8DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label35.Text = sum.ToString();
                    }
                }

                label35.Visible = true;
                label36.Visible = true;

            }
            else
            {
                // необязательные оценки
               Boolean mb8 = (Boolean)this.м8DataGridView.CurrentRow.Cells[3].Value;
                if (mb8 == true)
                   {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton30.Enabled = true;
                    radioButton51.Enabled = true;
                    radioButton29.Enabled = true;

                    if (radioButton52.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton30.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton51.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton29.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton32.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton31.Checked)
                        {
                            if (this.м8DataGridView.CurrentRow != null)
                            {
                                this.м8DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                    radioButton31.Checked = true;  // начальное значение оценки 0

                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м8DataGridView.CurrentRow.Index + 1;
                    index = index % this.м8DataGridView.Rows.Count;
                    this.м8DataGridView.CurrentCell = this.м8DataGridView.Rows[index].Cells[this.м8DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton30.Enabled = false;
                    radioButton51.Enabled = false;
                    radioButton29.Enabled = false;

                    if (radioButton52.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton30.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton51.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton29.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton32.Checked)
                    {
                        if (this.м8DataGridView.CurrentRow != null)
                        {
                            this.м8DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м8DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton31.Checked)
                        {
                            if (this.м8DataGridView.CurrentRow != null)
                            {
                                this.м8DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м8DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton31.Checked = true; // начальное значение оценки 0

                    //переход на следующую строку
                    //Select the next item
                    int index = this.м8DataGridView.CurrentRow.Index + 1;
                    index = index % this.м8DataGridView.Rows.Count;
                    this.м8DataGridView.CurrentCell = this.м8DataGridView.Rows[index].Cells[this.м8DataGridView.CurrentCell.ColumnIndex];

                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // 9 таблица
            // проверка на строку и проверка на обязательность
            int idm9 = (int)this.м9DataGridView.CurrentRow.Cells[0].Value;
            if (idm9 == this.м9DataGridView.Rows.Count) // строка  надо изменить
            {
                Boolean mb9 = (Boolean)this.м9DataGridView.CurrentRow.Cells[3].Value;
                if (mb9 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton34.Enabled = true;
                    radioButton53.Enabled = true;
                    radioButton33.Enabled = true;

                    if (radioButton54.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton34.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton53.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton33.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton36.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton35.Checked)
                        {
                            if (this.м9DataGridView.CurrentRow != null)
                            {
                                this.м9DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton35.Checked = true;  // начальное значение оценки 0
                    this.м9DataGridView.Visible = true;
                    button19.Enabled = false;
                }
                else
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton34.Enabled = false;
                    radioButton53.Enabled = false;
                    radioButton33.Enabled = false;

                    if (radioButton54.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton34.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton53.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton33.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton36.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton35.Checked)
                        {
                            if (this.м9DataGridView.CurrentRow != null)
                            {
                                this.м9DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }

                }

                this.Validate();
                this.m9BindingSource.EndEdit();
                this.tableAdapterManager8.UpdateAll(this.riskDBDataSet8);
                this.m9TableAdapter.Fill(this.riskDBDataSet8.M9);   // обновление данных

                this.м9DataGridView.Visible = true;
                button18.Visible = true;   //кнопка следующая оценка
                radioButton35.Checked = true;// начальное значение оценки 0
                button19.Enabled = false;
                //подсчет общей суммы меняется строки
                float s;
                float sum = 0;

                for (int i = 0; i < this.м9DataGridView.Rows.Count; i++)
                {
                    if (this.м9DataGridView.Rows[i].Cells[5].Value != null)
                    {
                        s = Convert.ToSingle(this.м9DataGridView.Rows[i].Cells[5].Value);
                        sum += s;
                        label40.Text = sum.ToString();
                    }
                }
                результатыОценкиToolStripMenuItem.Enabled = true;
                label40.Visible = true;
                label41.Visible = true;

            }
            else
            {
                // необязательные оценки
                Boolean mb9 = (Boolean)this.м9DataGridView.CurrentRow.Cells[3].Value;
                if (mb9 == true)
                {
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton34.Enabled = true;
                    radioButton53.Enabled = true;
                    radioButton33.Enabled = true;
                    
                    if (radioButton54.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton34.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton53.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton33.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton36.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton35.Checked)
                        {
                            if (this.м9DataGridView.CurrentRow != null)
                            {
                                this.м9DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton35.Checked = true;  // начальное значение оценки 0
                    //переход на следующую строку n поменять
                    //Select the next item
                    int index = this.м9DataGridView.CurrentRow.Index + 1;
                    index = index % this.м9DataGridView.Rows.Count;
                    this.м9DataGridView.CurrentCell = this.м9DataGridView.Rows[index].Cells[this.м9DataGridView.CurrentCell.ColumnIndex];
                    // this.м1DataGridView.CurrentCell = this.м1DataGridView[i, 3];  
                }
                else
                {
                    
                    // скрытие и вскрытие рекомендуемых оценок
                    radioButton34.Enabled = false;
                    radioButton53.Enabled = false;
                    radioButton33.Enabled = false;

                    if (radioButton54.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                        }
                    }
                    else if (radioButton34.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.25";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.25;
                        }
                    }
                    else if (radioButton53.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.5";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.5;
                        }
                    }
                    else if (radioButton33.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "0.75";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 0.75;
                        }
                    }
                    else if (radioButton36.Checked)
                    {
                        if (this.м9DataGridView.CurrentRow != null)
                        {
                            this.м9DataGridView.CurrentRow.Cells[2].Value = "1";
                            this.м9DataGridView.CurrentRow.Cells[6].Value = 1;
                        }
                    }
                    else
                        if (radioButton35.Checked)
                        {
                            if (this.м9DataGridView.CurrentRow != null)
                            {
                                this.м9DataGridView.CurrentRow.Cells[2].Value = "H/O";
                                this.м9DataGridView.CurrentRow.Cells[6].Value = 0;
                            }

                        }
                    radioButton35.Checked = true; // начальное значение оценки 0

                    //переход на следующую строку
                    //Select the next item
                    int index = this.м9DataGridView.CurrentRow.Index + 1;
                    index = index % this.м9DataGridView.Rows.Count;
                    this.м9DataGridView.CurrentCell = this.м9DataGridView.Rows[index].Cells[this.м9DataGridView.CurrentCell.ColumnIndex];

                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label52.Visible = true; // результаты
            label53.Visible = true;
            label54.Visible = true;
            label55.Visible = true;
            label56.Visible = true;
            label57.Visible = true;
            label58.Visible = true;
            label59.Visible = true;
            label66.Visible = true;
            label67.Visible = true;
            label68.Visible = true;
            label69.Visible = true;
            label70.Visible = true;
            label71.Visible = true;        
                string s = " ";
                if (label4.Text != s & label5.Text != s & label10.Text != s & label15.Text != s & label46.Text != s &
                    label25.Text != s & label30.Text != s & label35.Text != s & label40.Text != s)
                {
                    // вычисление уровней
                    label52.Text = label4.Text;          //1
                    float c = float.Parse(label52.Text);
                    float a1 = float.Parse(label5.Text); //2
                    float a2 = float.Parse(label10.Text);
                    float a3 = float.Parse(label15.Text);
                    float a = (a1 + a2 + a3) / 3;
                    label53.Text = a.ToString();
                    label54.Text = label46.Text;          //3
                    float d = float.Parse(label54.Text);
                    float b1 = float.Parse(label25.Text); //4
                    float b2 = float.Parse(label30.Text);
                    float b = (b1 + b2) / 2;
                    label55.Text = b.ToString();
                    label56.Text = label35.Text;          //5
                    float g = float.Parse(label56.Text);
                    label57.Text = label40.Text;          //ПДн
                    float h = float.Parse(label57.Text);

                    float[] array = new float[6] { a, b, c, d, g, h }; //объявили одномерный массив из 6 интенджеровских чисел. 
                    float min; // здесь будет храниться минимальное число массива

                    min = array[0];  //минимальное значение в начале равно первому элементу массива. Это логично я думаю и понятно всем.
                    for (int i = 1; i != 6; i++)
                    {
                        if (array[i] < min)//если текущий элемент меньше минимального, то он становится минимальным.
                        {
                            min = array[i];
                        }
                    }
                    // итоговая оценка
                    label59.Text = min.ToString();
                    float a11 = 100 * float.Parse(label59.Text);
                    int a111 = (int)a11;
                    int b11 = 0;
                    int c11 = 25;
                    int d11 = 50;
                    int f11 = 75;
                    int g11 = 100;

                    if (a111 >= b11 & a111 <= c11)   // от 0 до 25
                    {
                        label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a111 >= c11 & a111 <= d11)   // от 25 до 50
                    {
                        label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a111 >= d11 & a111 <= f11)    // от 50 до 75
                    {
                        label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a111 >= f11 & a111 <= g11)    // от 75 до 100
                    {
                        label58.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }
                    // aotd1
                    float a12 = 100 * float.Parse(label52.Text);
                    int a112 = (int)a12;
                    int b12 = 0;
                    int c12 = 25;
                    int d12 = 50;
                    int f12 = 75;
                    int g12 = 100;

                    if (a112 >= b12 & a112 <= c12)   // от 0 до 25
                    {
                        label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a112 >= c12 & a112 <= d12)   // от 25 до 50
                    {
                        label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a112 >= d12 & a112 <= f12)    // от 50 до 75
                    {
                        label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a112 >= f12 & a112 <= g12)    // от 75 до 100
                    {
                        label66.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }

                    // aotd2
                    float a13 = 100 * float.Parse(label53.Text);
                    int a113 = (int)a13;
                    int b13 = 0;
                    int c13 = 25;
                    int d13 = 50;
                    int f13 = 75;
                    int g13 = 100;

                    if (a113 >= b13 & a113 <= c13)   // от 0 до 25
                    {
                        label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a113 >= c13 & a113 <= d13)   // от 25 до 50
                    {
                        label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a113 >= d13 & a113 <= f13)    // от 50 до 75
                    {
                        label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a113 >= f13 & a113 <= g13)    // от 75 до 100
                    {
                        label68.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }
                    // aotd3
                    float a14 = 100 * float.Parse(label54.Text);
                    int a114 = (int)a14;
                    int b14 = 0;
                    int c14 = 25;
                    int d14 = 50;
                    int f14 = 75;
                    int g14 = 100;

                    if (a114 >= b14 & a114 <= c14)   // от 0 до 25
                    {
                        label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a114 >= c14 & a114 <= d14)   // от 25 до 50
                    {
                        label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a114 >= d14 & a114 <= f14)    // от 50 до 75
                    {
                        label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a114 >= f14 & a114 <= g14)    // от 75 до 100
                    {
                        label70.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }

                    // aotd4
                    float a15 = 100 * float.Parse(label55.Text);
                    int a115 = (int)a15;
                    int b15 = 0;
                    int c15 = 25;
                    int d15 = 50;
                    int f15 = 75;
                    int g15 = 100;

                    if (a115 >= b15 & a115 <= c15)   // от 0 до 25
                    {
                        label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a115 >= c15 & a115 <= d15)   // от 25 до 50
                    {
                        label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a115 >= d15 & a115 <= f15)    // от 50 до 75
                    {
                        label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a115 >= f15 & a115 <= g15)    // от 75 до 100
                    {
                        label67.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }

                    // aotd5
                    float a16 = 100 * float.Parse(label56.Text);
                    int a116 = (int)a16;
                    int b16 = 0;
                    int c16 = 25;
                    int d16 = 50;
                    int f16 = 75;
                    int g16 = 100;

                    if (a116 >= b16 & a116 <= c16)   // от 0 до 25
                    {
                        label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a116 >= c16 & a115 <= d16)   // от 25 до 50
                    {
                        label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a116 >= d16 & a116 <= f16)    // от 50 до 75
                    {
                        label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a116 >= f16 & a116 <= g16)    // от 75 до 100
                    {
                        label69.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }

                    // aotdПДн
                    float a17 = 100 * float.Parse(label57.Text);
                    int a117 = (int)a17;
                    int b17 = 0;
                    int c17 = 25;
                    int d17 = 50;
                    int f17 = 75;
                    int g17 = 100;

                    if (a117 >= b17 & a117 <= c17)   // от 0 до 25
                    {
                        label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                              "не установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a117 >= c17 & a117 <= d17)   // от 25 до 50
                    {
                        label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                       "частично установлены во внутренних документах проверяемой организации и не выполняется";
                    }
                    else if (a117 >= d17 & a117 <= f17)    // от 50 до 75
                    {
                        label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю, " +
                                        "установлены во внутренних документах проверяемой организации и  выполняются в неполном объеме";
                    }
                    else if (a117 >= f17 & a117 <= g17)    // от 75 до 100
                    {
                        label71.Text = "Требования  вопросов нормативных источников, соответствующих оцениваемому показателю," +
                                    "полностью установлены во внутренних документах проверяемой организации и выполняются в полном объеме";
                    }

                    tabControl1.SelectedTab = tabControl1.TabPages["tabPage10"];

                }
                else
                {
                    MessageBox.Show("Выполните все оценки");
                }
       
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void новаяОценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите начать новую оценку?", "Новая оценка нарушения ИБ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if (result == DialogResult.No) //Если нажал нет
            // {
            //    MessageBox.Show("vbbook.ru не нравиться");
            // }

            if (result == DialogResult.Yes) //Если нажал Да
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet8.M9". При необходимости она может быть перемещена или удалена.
                this.m9TableAdapter.Fill(this.riskDBDataSet8.M9);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet7.M8". При необходимости она может быть перемещена или удалена.
                this.m8TableAdapter.Fill(this.riskDBDataSet7.M8);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet6.M7". При необходимости она может быть перемещена или удалена.
                this.m7TableAdapter.Fill(this.riskDBDataSet6.M7);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet6.M7". При необходимости она может быть перемещена или удалена.
                this.m7TableAdapter.Fill(this.riskDBDataSet6.M7);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet5.M6". При необходимости она может быть перемещена или удалена.
                this.m6TableAdapter.Fill(this.riskDBDataSet5.M6);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet4.M5". При необходимости она может быть перемещена или удалена.
                this.m5TableAdapter.Fill(this.riskDBDataSet4.M5);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet3.M4". При необходимости она может быть перемещена или удалена.
                this.m4TableAdapter.Fill(this.riskDBDataSet3.M4);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet2.M3". При необходимости она может быть перемещена или удалена.
                this.m3TableAdapter.Fill(this.riskDBDataSet2.M3);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet1.M2". При необходимости она может быть перемещена или удалена.
                this.m2TableAdapter.Fill(this.riskDBDataSet1.M2);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "riskDBDataSet.М1". При необходимости она может быть перемещена или удалена.
                this.м1TableAdapter.Fill(this.riskDBDataSet.М1);

                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                результатыОценкиToolStripMenuItem.Enabled = false;
                this.м1DataGridView.Visible = false;
                this.м2DataGridView.Visible = false;
                this.м3DataGridView.Visible = false;
                this.м4DataGridView.Visible = false;
                this.м5DataGridView.Visible = false;
                this.м6DataGridView.Visible = false;
                this.м7DataGridView.Visible = false;
                this.м8DataGridView.Visible = false;
                this.м9DataGridView.Visible = false;

                label3.Visible = false; // общая оценка надпись таблица1
                label4.Visible = false; // общая оценка результат таблица1
                label51.Visible = false; // общая оценка результат таблица1
                button3.Visible = false; //кнопка следующая оценка таблица1
                button4.Visible = false; //кнопка следующая оценка таблица2
                label5.Visible = false; // общая оценка надпись таблица2
                label6.Visible = false; // общая оценка результат таблица2
                button6.Visible = false; //кнопка следующая оценка таблица3
                label10.Visible = false; // общая оценка надпись таблица3
                label11.Visible = false; // общая оценка результат таблица3
                button8.Visible = false; //кнопка следующая оценка таблица4
                label15.Visible = false; // общая оценка надпись таблица4
                label16.Visible = false; // общая оценка результат таблица4
                button20.Visible = false; //кнопка следующая оценка таблица5
                label46.Visible = false; // общая оценка надпись таблица5
                label47.Visible = false; // общая оценка результат таблица5
                button12.Visible = false; //кнопка следующая оценка таблица6
                label25.Visible = false; // общая оценка надпись таблица6
                label26.Visible = false; // общая оценка результат таблица6
                button14.Visible = false; //кнопка следующая оценка таблица7
                label30.Visible = false; // общая оценка надпись таблица7
                label31.Visible = false; // общая оценка результат таблица7
                button16.Visible = false; //кнопка следующая оценка таблица8
                label35.Visible = false; // общая оценка надпись таблица8
                label36.Visible = false; // общая оценка результат таблица8
                button18.Visible = false; //кнопка следующая оценка таблица9
                label40.Visible = false; // общая оценка надпись таблица9
                label41.Visible = false; // общая оценка результат таблица9
                radioButton4.Checked = true;
                radioButton7.Checked = true;
                radioButton11.Checked = true;
                radioButton15.Checked = true;
                radioButton57.Checked = true;
                radioButton23.Checked = true;
                radioButton27.Checked = true;
                radioButton31.Checked = true;
                radioButton35.Checked = true;
                button2.Enabled = true;
                button5.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button21.Enabled = false;
                button13.Enabled = false;
                button15.Enabled = false;
                button17.Enabled = false;
                button19.Enabled = false;
                label52.Visible = false;
                label53.Visible = false;
                label54.Visible = false;
                label55.Visible = false;
                label56.Visible = false;
                label57.Visible = false;
                label58.Visible = false;
                label59.Visible = false;
                label66.Visible = false;
                label67.Visible = false;
                label68.Visible = false;
                label69.Visible = false;
                label70.Visible = false;
                label71.Visible = false;
            }
        }
       

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //сохранение
            /*  SaveFileDialog sDialog = new SaveFileDialog();
              sDialog.Filter = "Книга Excel xls (*.xls)|*.xls |Книга Excel xls (*.xlsx)|*.xlsx|All files (*.*)|*.*";
              sDialog.FilterIndex = 1;
              sDialog.FileName = "Книга_" + DateTime.Now.ToString("_ddMMyyyy_HH:mm:ss");
              sDialog.OverwritePrompt = true;       

              if (sDialog.ShowDialog() == DialogResult.OK)
              {
                  StreamWriter sw = new StreamWriter(sDialog.FileName);
                   sw.Write(label52.Text);
                   sw.Close();
                  /*
                   * 
                   * 
                   * */
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];


            //Значения [y - строка,x - столбец]
            //Шапка
            ObjWorkSheet.Cells[1, 1] = groupBox1.Text;
            ObjWorkSheet.Cells[2, 1] = groupBox2.Text;
            ObjWorkSheet.Cells[3, 1] = groupBox3.Text;
            ObjWorkSheet.Cells[4, 1] = groupBox4.Text;
            ObjWorkSheet.Cells[5, 1] = groupBox5.Text;
            ObjWorkSheet.Cells[6, 1] = groupBox6.Text;
            ObjWorkSheet.Cells[7, 1] = groupBox7.Text;
            ObjWorkSheet.Cells[8, 1] = groupBox15.Text;
            //Значения

            ObjWorkSheet.Cells[2, 7] = label52.Text;
            ObjWorkSheet.Cells[3, 7] = label53.Text;
            ObjWorkSheet.Cells[4, 7] = label54.Text;
            ObjWorkSheet.Cells[5, 7] = label55.Text;
            ObjWorkSheet.Cells[6, 7] = label56.Text;
            ObjWorkSheet.Cells[7, 7] = label57.Text;
            ObjWorkSheet.Cells[8, 7] = label59.Text;
            //Критерии выставления оценки
            ObjWorkSheet.Cells[1, 9] = groupBox8.Text;
            ObjWorkSheet.Cells[2, 9] = label66.Text;
            ObjWorkSheet.Cells[3, 9] = label68.Text;
            ObjWorkSheet.Cells[4, 9] = label70.Text;
            ObjWorkSheet.Cells[5, 9] = label67.Text;
            ObjWorkSheet.Cells[6, 9] = label69.Text;
            ObjWorkSheet.Cells[7, 9] = label71.Text;
            ObjWorkSheet.Cells[8, 9] = label58.Text;
            /*
                // Первый критерий
            ObjWorkSheet.Cells[10, 1] = tabPage1.Text;
            ObjWorkSheet.Cells[11, 1] = "№ Вопроса";
            ObjWorkSheet.Cells[12, 1] = Convert.ToSingle(this.м1DataGridView.Rows[0].Cells[0].Value);
            ObjWorkSheet.Cells[13, 1] = Convert.ToSingle(this.м1DataGridView.Rows[1].Cells[0].Value);
            ObjWorkSheet.Cells[14, 1] = Convert.ToSingle(this.м1DataGridView.Rows[2].Cells[0].Value);
            ObjWorkSheet.Cells[15, 1] = Convert.ToSingle(this.м1DataGridView.Rows[3].Cells[0].Value);
            ObjWorkSheet.Cells[16, 1] = Convert.ToSingle(this.м1DataGridView.Rows[4].Cells[0].Value);
            ObjWorkSheet.Cells[17, 1] = Convert.ToSingle(this.м1DataGridView.Rows[5].Cells[0].Value);
            ObjWorkSheet.Cells[18, 1] = Convert.ToSingle(this.м1DataGridView.Rows[6].Cells[0].Value);
            ObjWorkSheet.Cells[19, 1] = Convert.ToSingle(this.м1DataGridView.Rows[7].Cells[0].Value);
            ObjWorkSheet.Cells[20, 1] = Convert.ToSingle(this.м1DataGridView.Rows[8].Cells[0].Value);
            ObjWorkSheet.Cells[21, 1] = Convert.ToSingle(this.м1DataGridView.Rows[9].Cells[0].Value);
            ObjWorkSheet.Cells[22, 1] = Convert.ToSingle(this.м1DataGridView.Rows[10].Cells[0].Value);
            ObjWorkSheet.Cells[23, 1] = Convert.ToSingle(this.м1DataGridView.Rows[11].Cells[0].Value);
            ObjWorkSheet.Cells[24, 1] = Convert.ToSingle(this.м1DataGridView.Rows[12].Cells[0].Value);
            ObjWorkSheet.Cells[25, 1] = Convert.ToSingle(this.м1DataGridView.Rows[13].Cells[0].Value);
            ObjWorkSheet.Cells[26, 1] = Convert.ToSingle(this.м1DataGridView.Rows[14].Cells[0].Value);
            */
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }
    }
}
