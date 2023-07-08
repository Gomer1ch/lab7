namespace Семестр_2_Лаба_2_Market
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Samsung");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Dell");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Производитель", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("144Hz");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("60Hz");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Герцовка", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Мониторы", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Intel");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("AMD");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("CPU", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Nvidia");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("AMD");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("GPU", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Мониторы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Центральные процессоры", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Графические процессоры", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem49 = new System.Windows.Forms.ListViewItem(new string[] {
            "Samsung gaming monitor 144hz",
            "22830"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem50 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dell gaming monitor 144hz",
            "32132"}, -1);
            System.Windows.Forms.ListViewItem listViewItem51 = new System.Windows.Forms.ListViewItem(new string[] {
            "Samsung office monitor 60hz",
            "43223"}, -1);
            System.Windows.Forms.ListViewItem listViewItem52 = new System.Windows.Forms.ListViewItem(new string[] {
            "Dell office monitor 60hz",
            "34321"}, -1);
            System.Windows.Forms.ListViewItem listViewItem53 = new System.Windows.Forms.ListViewItem(new string[] {
            "Intel i5-10600k",
            "23214"}, -1);
            System.Windows.Forms.ListViewItem listViewItem54 = new System.Windows.Forms.ListViewItem(new string[] {
            "Intel i9-10900",
            "41312"}, -1);
            System.Windows.Forms.ListViewItem listViewItem55 = new System.Windows.Forms.ListViewItem(new string[] {
            "AMD Ryzen 5 3600x",
            "13245"}, -1);
            System.Windows.Forms.ListViewItem listViewItem56 = new System.Windows.Forms.ListViewItem(new string[] {
            "AMD Ryzen 7 5800xt",
            "42112"}, -1);
            System.Windows.Forms.ListViewItem listViewItem57 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nvidia GTX 1660",
            "7564"}, 1);
            System.Windows.Forms.ListViewItem listViewItem58 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nvidia RTX 3070",
            "12345"}, 1);
            System.Windows.Forms.ListViewItem listViewItem59 = new System.Windows.Forms.ListViewItem(new string[] {
            "AMD RX6900 XT",
            "32213"}, 0);
            System.Windows.Forms.ListViewItem listViewItem60 = new System.Windows.Forms.ListViewItem(new string[] {
            "AMD RX5600 XT",
            "32211"}, 0);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1104, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Каталог";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Корзина";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode53.Name = "samsung";
            treeNode53.Text = "Samsung";
            treeNode54.Name = "dell";
            treeNode54.Text = "Dell";
            treeNode55.Name = "Producer";
            treeNode55.Text = "Производитель";
            treeNode56.Name = "144hz";
            treeNode56.Text = "144Hz";
            treeNode57.Name = "60hz";
            treeNode57.Text = "60Hz";
            treeNode58.Name = "Hz";
            treeNode58.Text = "Герцовка";
            treeNode59.Name = "Monitors";
            treeNode59.Text = "Мониторы";
            treeNode60.Name = "Intel";
            treeNode60.Text = "Intel";
            treeNode61.Name = "amdcpu";
            treeNode61.Text = "AMD";
            treeNode62.Name = "CPU";
            treeNode62.Text = "CPU";
            treeNode63.Name = "Nvidia";
            treeNode63.Text = "Nvidia";
            treeNode64.Name = "amdgpu";
            treeNode64.Text = "AMD";
            treeNode65.Name = "GPU";
            treeNode65.Text = "GPU";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode62,
            treeNode65});
            this.treeView1.Size = new System.Drawing.Size(272, 416);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "144.png");
            this.imageList1.Images.SetKeyName(1, "Dell_144Hz.png");
            this.imageList1.Images.SetKeyName(2, "60.png");
            this.imageList1.Images.SetKeyName(3, "Dell_60_Hz.png");
            this.imageList1.Images.SetKeyName(4, "intel_i5_10600.png");
            this.imageList1.Images.SetKeyName(5, "intel_9.png");
            this.imageList1.Images.SetKeyName(6, "amd_ryzen_6.png");
            this.imageList1.Images.SetKeyName(7, "amd_ryzen_7.png");
            this.imageList1.Images.SetKeyName(8, "gtx1660.jpg");
            this.imageList1.Images.SetKeyName(9, "rtx3070.jpg");
            this.imageList1.Images.SetKeyName(10, "6900.png");
            this.imageList1.Images.SetKeyName(11, "5600_.png");
            // 
            // listView1
            // 
            listViewGroup13.Header = "Мониторы";
            listViewGroup13.Name = "Monitors";
            listViewGroup14.Header = "Центральные процессоры";
            listViewGroup14.Name = "CPU";
            listViewGroup15.Header = "Графические процессоры";
            listViewGroup15.Name = "GPU";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.listView1.HideSelection = false;
            listViewItem49.Group = listViewGroup13;
            listViewItem50.Group = listViewGroup13;
            listViewItem51.Group = listViewGroup13;
            listViewItem52.Group = listViewGroup13;
            listViewItem53.Group = listViewGroup14;
            listViewItem54.Group = listViewGroup14;
            listViewItem55.Group = listViewGroup14;
            listViewItem56.Group = listViewGroup14;
            listViewItem57.Group = listViewGroup15;
            listViewItem58.Group = listViewGroup15;
            listViewItem59.Group = listViewGroup15;
            listViewItem60.Group = listViewGroup15;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem49,
            listViewItem50,
            listViewItem51,
            listViewItem52,
            listViewItem53,
            listViewItem54,
            listViewItem55,
            listViewItem56,
            listViewItem57,
            listViewItem58,
            listViewItem59,
            listViewItem60});
            this.listView1.Location = new System.Drawing.Point(281, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 410);
            this.listView1.TabIndex = 1;
            this.listView1.TileSize = new System.Drawing.Size(1, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(243, 410);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1052, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "---";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(670, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Показать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

