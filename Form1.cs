using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator3000 : Form
    {
        private const int cGrip = 16;
        private const int cCaption = 32;
        private MakeMovable _move;

        double calcvalue = 0;
        string calc = "";
        bool iscalc = false;

        bool menuExpand = false;
        bool HistoryExpand = false;

        public Calculator3000()
        {
            InitializeComponent();

            _move = new MakeMovable(this);
            _move.SetMovable(TopPanel, programname);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);

        }

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public void b_Click(object sender, EventArgs e)
        {
            
            if (Result.Text == "0" || (iscalc))           
                Result.Clear();
            if (PrevCalc.Text.Contains("="))
                PrevCalc.Text = "";    
            
            

            iscalc = false;

            Button bcalc = (Button)sender; 

            if (bcalc.Text == ",")
            {
                if (!Result.Text.Contains(","))
                    Result.Text += bcalc.Text;
            }
            else
                Result.Text += bcalc.Text;

            ChS.BackColor = Color.Lavender;
            ChS.Enabled = true;
            Dec.BackColor = Color.Lavender;
            Dec.Enabled = true;
            Mult.BackColor = Color.Lavender;
            Mult.Enabled = true;
            Min.BackColor = Color.Lavender;
            Min.Enabled = true;
            Plus.BackColor = Color.Lavender;
            Plus.Enabled = true;
            Div.BackColor = Color.Lavender;
            Div.Enabled = true;


        }
       
        private void ChS_Click(object sender, EventArgs e)
        {
            Result.Text = (double.Parse(Result.Text) * (-1)).ToString();
        }

        private void operation(object sender, EventArgs e)
        {
            Button boper = (Button)sender;
            calcvalue = double.Parse(Result.Text);
            calc = boper.Text;
            PrevCalc.Text = Result.Text + " " + calc;
            iscalc = true;
        }

        private void ClearS_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            PrevCalc.Text = "";
        }

        private void Del_Click(object sender, EventArgs e)
        {
            string s = Result.Text;
            if (Result.TextLength > 1)
                Result.Text = s.Remove(Result.TextLength - 1);
            else
                Result.Text = "0";           
        }

        private void CalcFinish_Click(object sender, EventArgs e)
        {
            string SecNum = Result.Text;
            PrevCalc.Text = $"{PrevCalc.Text} {Result.Text} =";
            if(Result.Text != string.Empty)
            {
                if (Result.Text == "0")
                    PrevCalc.Text = string.Empty;
                switch(calc)
                {
                    case "+":
                        Result.Text = (calcvalue + double.Parse(Result.Text)).ToString();
                        HistoryList.AppendText($"{calcvalue} + {SecNum} = {Result.Text}\n");
                        iscalc = true;
                        break;
                    case "-":
                        Result.Text = (calcvalue - double.Parse(Result.Text)).ToString();
                        HistoryList.AppendText($"{calcvalue} - {SecNum} = {Result.Text}\n");
                        iscalc = true;
                        break;
                    case "×":
                        Result.Text = (calcvalue * double.Parse(Result.Text)).ToString();
                        HistoryList.AppendText($"{calcvalue} * {SecNum} = {Result.Text}\n");
                        iscalc = true;
                        break;
                    case "/":
                        {
                            if (double.Parse(Result.Text) == 0)
                            {
                                Result.Text = "Деление на 0 невозможно";
                                Result.Font = new Font("Lucida Sans", 20);
                                ChS.BackColor = Color.Gray;
                                ChS.Enabled = false;
                                Dec.BackColor = Color.Gray;
                                Dec.Enabled = false;
                                Mult.BackColor = Color.Gray;
                                Mult.Enabled = false;
                                Min.BackColor = Color.Gray;
                                Min.Enabled = false;
                                Plus.BackColor = Color.Gray;
                                Plus.Enabled = false;
                                Div.BackColor = Color.Gray;
                                Div.Enabled = false;
                            }
                            else
                            {
                                HistoryList.AppendText($"{calcvalue} / {SecNum} = {Result.Text}\n");
                                Result.Text = (calcvalue / double.Parse(Result.Text)).ToString();
                                iscalc = true;
                            }
                            break;
                        }
                    default:
                        PrevCalc.Text = $"{Result.Text} = ";
                        iscalc = true;
                        break;
                }
            }
           

        }
 
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                SidePanel.Width += 10;
                if (SidePanel.Width >= 165)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                SidePanel.Width -= 10;
                if (SidePanel.Width == 0)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Overlay_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void Setting_Click(object sender, EventArgs e)
        {              
            
        }

        private void Closeb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Calculator3000_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            int temp;

            if (e.KeyCode.Equals(Keys.Enter))
                CalcFinish_Click(CalcFinish, null);
            if (e.KeyCode.Equals(Keys.Back))
                Del.PerformClick();
            if (e.KeyCode.Equals(Keys.Oemplus) || e.KeyCode.Equals(Keys.Add))
                Plus.PerformClick();
            if (e.KeyCode.Equals(Keys.OemMinus) || e.KeyCode.Equals(Keys.Subtract))
                Min.PerformClick();
            if (e.KeyCode.Equals(Keys.OemQuestion) || e.KeyCode.Equals(Keys.Divide))
                Div.PerformClick();
            if (e.KeyCode.Equals(Keys.Oemcomma) || e.KeyCode.Equals(Keys.Decimal))
                Dec.PerformClick();
            if ((e.Shift && e.KeyCode.Equals(Keys.D8)) || e.KeyCode.Equals(Keys.Multiply))
            {
                Mult.PerformClick();
                key = " ";
            }

            if (key.Contains("D") && key.Length == 2)
            {
                int.TryParse(key.Remove(0, 1), out temp);
                foreach (Button b in new List<Button> { b0, b1, b2, b3, b4, b5, b6, b7, b8, b9 })
                {
                    if (Convert.ToString(temp) == b.Text)
                    {
                        b.PerformClick();
                        break;
                    }
                }
            }

            if (key.Contains("NumPad"))
            {
                int.TryParse(key.Remove(0, 6), out temp);
                foreach (Button b in new List<Button> { b0, b1, b2, b3, b4, b5, b6, b7, b8, b9 })
                {
                    if (Convert.ToString(temp) == b.Text)
                    {
                        b.PerformClick();
                        break;
                    }
                }
            }
        }   
           
        private void HistoryTransition_Tick(object sender, EventArgs e)
        {
            if (HistoryExpand == false)
            {
                HistoryPanel.Width += 10;
                if (HistoryPanel.Width >= 205)
                {
                    HistoryTransition.Stop();
                    HistoryExpand = true;
                }
            }
            else
            {
                HistoryPanel.Width -= 10;
                if (HistoryPanel.Width == 0)
                {
                    HistoryTransition.Stop();
                    HistoryExpand = false;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HistoryTransition.Start();
        }

        private void History_Click(object sender, EventArgs e)
        {
            HistoryTransition.Start();
            menuTransition.Start();
        }

        private void ClearH_Click(object sender, EventArgs e)
        {
            HistoryList.Clear();
        }

        private void HideWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(HistoryList.Text, new Font("Verdana", 14), Brushes.Black, 0, 0);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.FileName = "Result";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(HistoryList.Text);
                streamWriter.Close();
            }
        }

        private void Calculator3000_Load(object sender, EventArgs e)
        {

        }
    }
}