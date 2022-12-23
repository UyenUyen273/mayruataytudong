namespace MayRuaTayTuDong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_image2 = new System.Windows.Forms.Label();
            this.lbl_image1 = new System.Windows.Forms.Label();
            this.lbl_dungdichday = new System.Windows.Forms.Label();
            this.lbl_dungdichchuadu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tree = new System.Windows.Forms.Label();
            this.llb_snowman = new System.Windows.Forms.Label();
            this.lbl_mayruataytudong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_image2);
            this.panel1.Controls.Add(this.lbl_image1);
            this.panel1.Controls.Add(this.lbl_dungdichday);
            this.panel1.Controls.Add(this.lbl_dungdichchuadu);
            this.panel1.Location = new System.Drawing.Point(-2, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 315);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 111);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 117);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(341, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 79);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2913557.png");
            this.imageList1.Images.SetKeyName(1, "4201973.png");
            this.imageList1.Images.SetKeyName(2, "4201892.png");
            this.imageList1.Images.SetKeyName(3, "1409305.png");
            this.imageList1.Images.SetKeyName(4, "9209416.png");
            // 
            // lbl_image2
            // 
            this.lbl_image2.BackColor = System.Drawing.Color.Red;
            this.lbl_image2.ImageIndex = 1;
            this.lbl_image2.ImageList = this.imageList1;
            this.lbl_image2.Location = new System.Drawing.Point(341, 153);
            this.lbl_image2.Name = "lbl_image2";
            this.lbl_image2.Size = new System.Drawing.Size(80, 79);
            this.lbl_image2.TabIndex = 4;
            this.lbl_image2.Click += new System.EventHandler(this.lbl_image2_Click);
            // 
            // lbl_image1
            // 
            this.lbl_image1.BackColor = System.Drawing.Color.Cyan;
            this.lbl_image1.ImageIndex = 0;
            this.lbl_image1.ImageList = this.imageList1;
            this.lbl_image1.Location = new System.Drawing.Point(61, 164);
            this.lbl_image1.Name = "lbl_image1";
            this.lbl_image1.Size = new System.Drawing.Size(82, 79);
            this.lbl_image1.TabIndex = 3;
            // 
            // lbl_dungdichday
            // 
            this.lbl_dungdichday.BackColor = System.Drawing.Color.Cyan;
            this.lbl_dungdichday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dungdichday.Font = new System.Drawing.Font("Gill Sans MT Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dungdichday.Location = new System.Drawing.Point(279, 28);
            this.lbl_dungdichday.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_dungdichday.Name = "lbl_dungdichday";
            this.lbl_dungdichday.Size = new System.Drawing.Size(200, 89);
            this.lbl_dungdichday.TabIndex = 2;
            this.lbl_dungdichday.Text = "DUNG DỊCH CÒN ĐẦY";
            this.lbl_dungdichday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_dungdichday.Click += new System.EventHandler(this.lbl_dungdich2_Click);
            // 
            // lbl_dungdichchuadu
            // 
            this.lbl_dungdichchuadu.BackColor = System.Drawing.Color.Red;
            this.lbl_dungdichchuadu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dungdichchuadu.Font = new System.Drawing.Font("Gill Sans MT Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dungdichchuadu.Location = new System.Drawing.Point(279, 28);
            this.lbl_dungdichchuadu.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_dungdichchuadu.Name = "lbl_dungdichchuadu";
            this.lbl_dungdichchuadu.Size = new System.Drawing.Size(200, 89);
            this.lbl_dungdichchuadu.TabIndex = 1;
            this.lbl_dungdichchuadu.Text = "DUNG DỊCH CHƯA ĐỦ";
            this.lbl_dungdichchuadu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_dungdichchuadu.Click += new System.EventHandler(this.lbl_dungdichchuadu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.lbl_tree);
            this.panel2.Controls.Add(this.llb_snowman);
            this.panel2.Controls.Add(this.lbl_mayruataytudong);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 140);
            this.panel2.TabIndex = 1;
            // 
            // lbl_tree
            // 
            this.lbl_tree.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tree.ImageKey = "9209416.png";
            this.lbl_tree.ImageList = this.imageList1;
            this.lbl_tree.Location = new System.Drawing.Point(710, 28);
            this.lbl_tree.Name = "lbl_tree";
            this.lbl_tree.Size = new System.Drawing.Size(80, 79);
            this.lbl_tree.TabIndex = 5;
            // 
            // llb_snowman
            // 
            this.llb_snowman.BackColor = System.Drawing.Color.Transparent;
            this.llb_snowman.ImageKey = "1409305.png";
            this.llb_snowman.ImageList = this.imageList1;
            this.llb_snowman.Location = new System.Drawing.Point(5, 28);
            this.llb_snowman.Name = "llb_snowman";
            this.llb_snowman.Size = new System.Drawing.Size(80, 79);
            this.llb_snowman.TabIndex = 6;
            // 
            // lbl_mayruataytudong
            // 
            this.lbl_mayruataytudong.BackColor = System.Drawing.Color.Cyan;
            this.lbl_mayruataytudong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mayruataytudong.Location = new System.Drawing.Point(91, 39);
            this.lbl_mayruataytudong.Name = "lbl_mayruataytudong";
            this.lbl_mayruataytudong.Size = new System.Drawing.Size(613, 68);
            this.lbl_mayruataytudong.TabIndex = 4;
            this.lbl_mayruataytudong.Text = "MÁY RỬA TAY TỰ ĐỘNG";
            this.lbl_mayruataytudong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mayruataytudong.Click += new System.EventHandler(this.lbl_mayruataytudong_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ImageList imageList1;
        private Label lbl_image2;
        private Label lbl_image1;
        private Label lbl_dungdichday;
        private Label lbl_dungdichchuadu;
        private Label lbl_tree;
        private Label llb_snowman;
        private Label lbl_mayruataytudong;
        private Label label1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
    }
}