namespace WindowsFormsApp1
{
    partial class Calculator3000
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator3000));
            this.Result = new System.Windows.Forms.TextBox();
            this.PrevCalc = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.HideWindow = new System.Windows.Forms.Button();
            this.Closeb = new System.Windows.Forms.Button();
            this.ReWindow = new System.Windows.Forms.Button();
            this.programname = new System.Windows.Forms.Label();
            this.Overlay = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.ClearS = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.CalcFinish = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.ChS = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.Dec = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Setting = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.HistoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Back = new System.Windows.Forms.Button();
            this.HistoryList = new System.Windows.Forms.RichTextBox();
            this.ClearH = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.HistoryTransition = new System.Windows.Forms.Timer(this.components);
            this.Del = new System.Windows.Forms.Button();
            this.Holder = new System.Windows.Forms.TableLayoutPanel();
            this.TopPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.HistoryPanel.SuspendLayout();
            this.Holder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.BackColor = System.Drawing.Color.AliceBlue;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Cursor = System.Windows.Forms.Cursors.Default;
            this.Result.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(18, 63);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(395, 47);
            this.Result.TabIndex = 16;
            this.Result.TabStop = false;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PrevCalc
            // 
            this.PrevCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevCalc.Location = new System.Drawing.Point(77, 37);
            this.PrevCalc.MinimumSize = new System.Drawing.Size(326, 23);
            this.PrevCalc.Name = "PrevCalc";
            this.PrevCalc.Size = new System.Drawing.Size(326, 23);
            this.PrevCalc.TabIndex = 21;
            this.PrevCalc.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopPanel.Controls.Add(this.HideWindow);
            this.TopPanel.Controls.Add(this.Closeb);
            this.TopPanel.Controls.Add(this.ReWindow);
            this.TopPanel.Controls.Add(this.programname);
            this.TopPanel.Controls.Add(this.Overlay);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(431, 34);
            this.TopPanel.TabIndex = 23;
            // 
            // HideWindow
            // 
            this.HideWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HideWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideWindow.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_minimize_sign_6057365;
            this.HideWindow.Location = new System.Drawing.Point(326, 2);
            this.HideWindow.Name = "HideWindow";
            this.HideWindow.Size = new System.Drawing.Size(30, 30);
            this.HideWindow.TabIndex = 27;
            this.HideWindow.UseVisualStyleBackColor = true;
            this.HideWindow.Click += new System.EventHandler(this.HideWindow_Click);
            // 
            // Closeb
            // 
            this.Closeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Closeb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Closeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closeb.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_close_2919543;
            this.Closeb.Location = new System.Drawing.Point(398, 2);
            this.Closeb.Name = "Closeb";
            this.Closeb.Size = new System.Drawing.Size(30, 30);
            this.Closeb.TabIndex = 26;
            this.Closeb.UseVisualStyleBackColor = true;
            this.Closeb.Click += new System.EventHandler(this.Closeb_Click);
            // 
            // ReWindow
            // 
            this.ReWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReWindow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ReWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReWindow.Image = global::WindowsFormsApp1.Properties.Resources.icons8_свернуть_окно_16;
            this.ReWindow.Location = new System.Drawing.Point(362, 2);
            this.ReWindow.Name = "ReWindow";
            this.ReWindow.Size = new System.Drawing.Size(30, 30);
            this.ReWindow.TabIndex = 25;
            this.ReWindow.UseVisualStyleBackColor = true;
            this.ReWindow.Click += new System.EventHandler(this.ReWindow_Click);
            // 
            // programname
            // 
            this.programname.AutoSize = true;
            this.programname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programname.Location = new System.Drawing.Point(48, 5);
            this.programname.Name = "programname";
            this.programname.Size = new System.Drawing.Size(165, 25);
            this.programname.TabIndex = 24;
            this.programname.Text = "CALCULATOR";
            // 
            // Overlay
            // 
            this.Overlay.BackColor = System.Drawing.Color.AliceBlue;
            this.Overlay.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.Overlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Overlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Overlay.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_menu_2976215__1_;
            this.Overlay.Location = new System.Drawing.Point(3, 3);
            this.Overlay.Name = "Overlay";
            this.Overlay.Size = new System.Drawing.Size(41, 29);
            this.Overlay.TabIndex = 22;
            this.Overlay.TabStop = false;
            this.Overlay.UseVisualStyleBackColor = false;
            this.Overlay.Click += new System.EventHandler(this.Overlay_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // ClearS
            // 
            this.ClearS.BackColor = System.Drawing.Color.Lavender;
            this.ClearS.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearS.Location = new System.Drawing.Point(343, 57);
            this.ClearS.Name = "ClearS";
            this.ClearS.Size = new System.Drawing.Size(79, 48);
            this.ClearS.TabIndex = 19;
            this.ClearS.TabStop = false;
            this.ClearS.Text = "CE";
            this.ClearS.UseVisualStyleBackColor = false;
            this.ClearS.Click += new System.EventHandler(this.ClearS_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.Lavender;
            this.b4.Cursor = System.Windows.Forms.Cursors.Default;
            this.b4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b4.Location = new System.Drawing.Point(9, 57);
            this.b4.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(73, 42);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Lavender;
            this.b5.Cursor = System.Windows.Forms.Cursors.Default;
            this.b5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b5.Location = new System.Drawing.Point(94, 57);
            this.b5.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(73, 42);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Lavender;
            this.ClearAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearAll.Location = new System.Drawing.Point(343, 111);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(79, 48);
            this.ClearAll.TabIndex = 20;
            this.ClearAll.TabStop = false;
            this.ClearAll.Text = "C";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.Lavender;
            this.b3.Cursor = System.Windows.Forms.Cursors.Default;
            this.b3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b3.Location = new System.Drawing.Point(179, 111);
            this.b3.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(73, 42);
            this.b3.TabIndex = 7;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.Lavender;
            this.b6.Cursor = System.Windows.Forms.Cursors.Default;
            this.b6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b6.Location = new System.Drawing.Point(179, 57);
            this.b6.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(73, 42);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b_Click);
            // 
            // CalcFinish
            // 
            this.CalcFinish.BackColor = System.Drawing.Color.Lavender;
            this.CalcFinish.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalcFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalcFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcFinish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalcFinish.Location = new System.Drawing.Point(343, 165);
            this.CalcFinish.Name = "CalcFinish";
            this.CalcFinish.Size = new System.Drawing.Size(79, 50);
            this.CalcFinish.TabIndex = 17;
            this.CalcFinish.TabStop = false;
            this.CalcFinish.Text = "=";
            this.CalcFinish.UseVisualStyleBackColor = false;
            this.CalcFinish.Click += new System.EventHandler(this.CalcFinish_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.Lavender;
            this.b2.Cursor = System.Windows.Forms.Cursors.Default;
            this.b2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b2.Location = new System.Drawing.Point(94, 111);
            this.b2.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(73, 42);
            this.b2.TabIndex = 9;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.Lavender;
            this.Min.Cursor = System.Windows.Forms.Cursors.Default;
            this.Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Min.Location = new System.Drawing.Point(258, 57);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(79, 48);
            this.Min.TabIndex = 14;
            this.Min.TabStop = false;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = false;
            this.Min.Click += new System.EventHandler(this.operation);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.Lavender;
            this.Mult.Cursor = System.Windows.Forms.Cursors.Default;
            this.Mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Mult.Location = new System.Drawing.Point(258, 3);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(79, 48);
            this.Mult.TabIndex = 13;
            this.Mult.TabStop = false;
            this.Mult.Text = "×";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.operation);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.Lavender;
            this.b1.Cursor = System.Windows.Forms.Cursors.Default;
            this.b1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b1.Location = new System.Drawing.Point(9, 111);
            this.b1.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(73, 42);
            this.b1.TabIndex = 8;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.Lavender;
            this.Div.Cursor = System.Windows.Forms.Cursors.Default;
            this.Div.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Div.Location = new System.Drawing.Point(258, 165);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(79, 50);
            this.Div.TabIndex = 12;
            this.Div.TabStop = false;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.operation);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.Lavender;
            this.b0.Cursor = System.Windows.Forms.Cursors.Default;
            this.b0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b0.Location = new System.Drawing.Point(94, 165);
            this.b0.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(73, 44);
            this.b0.TabIndex = 11;
            this.b0.TabStop = false;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.Lavender;
            this.b7.Cursor = System.Windows.Forms.Cursors.Default;
            this.b7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b7.Location = new System.Drawing.Point(94, 3);
            this.b7.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(73, 42);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b_Click);
            // 
            // ChS
            // 
            this.ChS.BackColor = System.Drawing.Color.Lavender;
            this.ChS.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChS.Location = new System.Drawing.Point(9, 165);
            this.ChS.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.ChS.Name = "ChS";
            this.ChS.Size = new System.Drawing.Size(73, 44);
            this.ChS.TabIndex = 10;
            this.ChS.TabStop = false;
            this.ChS.Text = "+/-";
            this.ChS.UseVisualStyleBackColor = false;
            this.ChS.Click += new System.EventHandler(this.ChS_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.Lavender;
            this.b9.Cursor = System.Windows.Forms.Cursors.Default;
            this.b9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b9.Location = new System.Drawing.Point(179, 3);
            this.b9.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(73, 42);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b_Click);
            // 
            // Dec
            // 
            this.Dec.BackColor = System.Drawing.Color.Lavender;
            this.Dec.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dec.Location = new System.Drawing.Point(179, 165);
            this.Dec.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(73, 44);
            this.Dec.TabIndex = 0;
            this.Dec.TabStop = false;
            this.Dec.Text = ",";
            this.Dec.UseVisualStyleBackColor = false;
            this.Dec.Click += new System.EventHandler(this.b_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.Lavender;
            this.b8.Cursor = System.Windows.Forms.Cursors.Default;
            this.b8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b8.Location = new System.Drawing.Point(9, 3);
            this.b8.Margin = new System.Windows.Forms.Padding(9, 3, 3, 9);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(73, 42);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.Lavender;
            this.Plus.Cursor = System.Windows.Forms.Cursors.Default;
            this.Plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Plus.Location = new System.Drawing.Point(258, 111);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(79, 48);
            this.Plus.TabIndex = 15;
            this.Plus.TabStop = false;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.operation);
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SidePanel.BackColor = System.Drawing.Color.Azure;
            this.SidePanel.Controls.Add(this.Setting);
            this.SidePanel.Controls.Add(this.History);
            this.SidePanel.Location = new System.Drawing.Point(0, 34);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(0, 314);
            this.SidePanel.TabIndex = 25;
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.Color.Azure;
            this.Setting.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Setting.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_settings_cogwheel_button_61094__1_;
            this.Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting.Location = new System.Drawing.Point(3, 3);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(162, 44);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "    Настройки";
            this.Setting.UseVisualStyleBackColor = false;
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.Azure;
            this.History.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_book_4347419;
            this.History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.Location = new System.Drawing.Point(3, 53);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(162, 44);
            this.History.TabIndex = 1;
            this.History.Text = "История";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // HistoryPanel
            // 
            this.HistoryPanel.Controls.Add(this.Back);
            this.HistoryPanel.Controls.Add(this.HistoryList);
            this.HistoryPanel.Controls.Add(this.ClearH);
            this.HistoryPanel.Controls.Add(this.Print);
            this.HistoryPanel.Controls.Add(this.Save);
            this.HistoryPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HistoryPanel.Location = new System.Drawing.Point(0, 0);
            this.HistoryPanel.Name = "HistoryPanel";
            this.HistoryPanel.Size = new System.Drawing.Size(0, 348);
            this.HistoryPanel.TabIndex = 26;
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_left_arrow_271218;
            this.Back.Location = new System.Drawing.Point(3, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(197, 30);
            this.Back.TabIndex = 27;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // HistoryList
            // 
            this.HistoryList.BackColor = System.Drawing.Color.AliceBlue;
            this.HistoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HistoryList.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HistoryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryList.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryList.Location = new System.Drawing.Point(3, 39);
            this.HistoryList.Name = "HistoryList";
            this.HistoryList.ReadOnly = true;
            this.HistoryList.Size = new System.Drawing.Size(197, 267);
            this.HistoryList.TabIndex = 28;
            this.HistoryList.Text = "";
            // 
            // ClearH
            // 
            this.ClearH.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClearH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearH.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_data_cleaning_2088794;
            this.ClearH.Location = new System.Drawing.Point(3, 312);
            this.ClearH.Name = "ClearH";
            this.ClearH.Size = new System.Drawing.Size(30, 29);
            this.ClearH.TabIndex = 29;
            this.ClearH.UseVisualStyleBackColor = true;
            this.ClearH.Click += new System.EventHandler(this.ClearH_Click);
            // 
            // Print
            // 
            this.Print.Dock = System.Windows.Forms.DockStyle.Top;
            this.Print.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_printing_446991;
            this.Print.Location = new System.Drawing.Point(50, 347);
            this.Print.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(30, 30);
            this.Print.TabIndex = 28;
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Save
            // 
            this.Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_save_7002186;
            this.Save.Location = new System.Drawing.Point(50, 383);
            this.Save.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(30, 30);
            this.Save.TabIndex = 27;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // HistoryTransition
            // 
            this.HistoryTransition.Interval = 10;
            this.HistoryTransition.Tick += new System.EventHandler(this.HistoryTransition_Tick);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.Lavender;
            this.Del.Cursor = System.Windows.Forms.Cursors.Default;
            this.Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Del.Image = global::WindowsFormsApp1.Properties.Resources.free_icon_delete_button_4823165__1_;
            this.Del.Location = new System.Drawing.Point(343, 3);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(79, 48);
            this.Del.TabIndex = 18;
            this.Del.TabStop = false;
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Holder
            // 
            this.Holder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Holder.ColumnCount = 5;
            this.Holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Holder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Holder.Controls.Add(this.b9, 2, 0);
            this.Holder.Controls.Add(this.b4, 0, 1);
            this.Holder.Controls.Add(this.CalcFinish, 4, 3);
            this.Holder.Controls.Add(this.ClearAll, 4, 2);
            this.Holder.Controls.Add(this.Del, 4, 0);
            this.Holder.Controls.Add(this.ClearS, 4, 1);
            this.Holder.Controls.Add(this.b5, 1, 1);
            this.Holder.Controls.Add(this.Mult, 3, 0);
            this.Holder.Controls.Add(this.b6, 2, 1);
            this.Holder.Controls.Add(this.b1, 0, 2);
            this.Holder.Controls.Add(this.Min, 3, 1);
            this.Holder.Controls.Add(this.Div, 3, 3);
            this.Holder.Controls.Add(this.ChS, 0, 3);
            this.Holder.Controls.Add(this.b3, 2, 2);
            this.Holder.Controls.Add(this.b2, 1, 2);
            this.Holder.Controls.Add(this.Dec, 2, 3);
            this.Holder.Controls.Add(this.Plus, 3, 2);
            this.Holder.Controls.Add(this.b0, 1, 3);
            this.Holder.Controls.Add(this.b7, 1, 0);
            this.Holder.Controls.Add(this.b8, 0, 0);
            this.Holder.Location = new System.Drawing.Point(3, 126);
            this.Holder.Name = "Holder";
            this.Holder.RowCount = 4;
            this.Holder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Holder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Holder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Holder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Holder.Size = new System.Drawing.Size(425, 218);
            this.Holder.TabIndex = 27;
            // 
            // Calculator3000
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(431, 348);
            this.Controls.Add(this.HistoryPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.Holder);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.PrevCalc);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(431, 348);
            this.Name = "Calculator3000";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator3000";
            this.Load += new System.EventHandler(this.Calculator3000_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator3000_KeyDown);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.HistoryPanel.ResumeLayout(false);
            this.Holder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Result;
        public System.Windows.Forms.Label PrevCalc;
        private System.Windows.Forms.Button Overlay;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label programname;
        private System.Windows.Forms.Button HideWindow;
        private System.Windows.Forms.Button Closeb;
        private System.Windows.Forms.Button ReWindow;
        private System.Windows.Forms.Timer menuTransition;
        public System.Windows.Forms.Button ClearS;
        public System.Windows.Forms.Button b4;
        public System.Windows.Forms.Button b5;
        public System.Windows.Forms.Button ClearAll;
        public System.Windows.Forms.Button Del;
        public System.Windows.Forms.Button b3;
        public System.Windows.Forms.Button b6;
        public System.Windows.Forms.Button CalcFinish;
        public System.Windows.Forms.Button b2;
        public System.Windows.Forms.Button Min;
        public System.Windows.Forms.Button Mult;
        public System.Windows.Forms.Button b1;
        public System.Windows.Forms.Button Div;
        public System.Windows.Forms.Button b0;
        public System.Windows.Forms.Button b7;
        public System.Windows.Forms.Button ChS;
        public System.Windows.Forms.Button b9;
        public System.Windows.Forms.Button Dec;
        public System.Windows.Forms.Button b8;
        public System.Windows.Forms.Button Plus;
        private System.Windows.Forms.FlowLayoutPanel SidePanel;
        private System.Windows.Forms.Button Setting;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.FlowLayoutPanel HistoryPanel;
        public System.Windows.Forms.Button Back;
        private System.Windows.Forms.RichTextBox HistoryList;
        private System.Windows.Forms.Timer HistoryTransition;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button ClearH;
        private System.Windows.Forms.TableLayoutPanel Holder;
    }
}

