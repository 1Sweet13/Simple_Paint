namespace Simple_Paint;

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
        pictureBox1 = new PictureBox();
        button1 = new Button();
        button2 = new Button();
        flowLayoutPanel1 = new FlowLayoutPanel();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button10 = new Button();
        panel1 = new Panel();
        label1 = new Label();
        trackBar1 = new TrackBar();
        colorDialog1 = new ColorDialog();
        saveFileDialog1 = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Left;
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(714, 445);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.Click += button3_Click;
        pictureBox1.MouseDown += pictureBox1_MouseDown;
        pictureBox1.MouseMove += pictureBox1_MouseMove;
        pictureBox1.MouseUp += pictureBox1_MouseUp;
        // 
        // button1
        // 
        button1.Location = new Point(720, 378);
        button1.Name = "button1";
        button1.Size = new Size(137, 31);
        button1.TabIndex = 1;
        button1.Text = "Save";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(720, 415);
        button2.Name = "button2";
        button2.Size = new Size(137, 29);
        button2.TabIndex = 2;
        button2.Text = "Clear";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
        flowLayoutPanel1.Controls.Add(button3);
        flowLayoutPanel1.Controls.Add(button4);
        flowLayoutPanel1.Controls.Add(button5);
        flowLayoutPanel1.Controls.Add(button6);
        flowLayoutPanel1.Controls.Add(button7);
        flowLayoutPanel1.Controls.Add(button8);
        flowLayoutPanel1.Controls.Add(button9);
        flowLayoutPanel1.Controls.Add(button10);
        flowLayoutPanel1.Dock = DockStyle.Top;
        flowLayoutPanel1.Location = new Point(714, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(153, 80);
        flowLayoutPanel1.TabIndex = 3;
        // 
        // button3
        // 
        button3.BackColor = Color.White;
        button3.FlatStyle = FlatStyle.Flat;
        button3.Location = new Point(3, 3);
        button3.Name = "button3";
        button3.Size = new Size(30, 30);
        button3.TabIndex = 4;
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.BackColor = Color.Red;
        button4.FlatStyle = FlatStyle.Flat;
        button4.Location = new Point(39, 3);
        button4.Name = "button4";
        button4.Size = new Size(30, 30);
        button4.TabIndex = 5;
        button4.UseVisualStyleBackColor = false;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.BackColor = Color.Orange;
        button5.FlatStyle = FlatStyle.Flat;
        button5.Location = new Point(75, 3);
        button5.Name = "button5";
        button5.Size = new Size(30, 30);
        button5.TabIndex = 6;
        button5.UseVisualStyleBackColor = false;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.BackColor = Color.Yellow;
        button6.FlatStyle = FlatStyle.Flat;
        button6.Location = new Point(111, 3);
        button6.Name = "button6";
        button6.Size = new Size(30, 30);
        button6.TabIndex = 7;
        button6.UseVisualStyleBackColor = false;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.BackColor = Color.Green;
        button7.FlatStyle = FlatStyle.Flat;
        button7.Location = new Point(3, 39);
        button7.Name = "button7";
        button7.Size = new Size(30, 30);
        button7.TabIndex = 8;
        button7.UseVisualStyleBackColor = false;
        button7.Click += button7_Click;
        // 
        // button8
        // 
        button8.BackColor = Color.Blue;
        button8.FlatStyle = FlatStyle.Flat;
        button8.Location = new Point(39, 39);
        button8.Name = "button8";
        button8.Size = new Size(30, 30);
        button8.TabIndex = 9;
        button8.UseVisualStyleBackColor = false;
        button8.Click += button8_Click;
        // 
        // button9
        // 
        button9.BackColor = Color.Black;
        button9.FlatStyle = FlatStyle.Flat;
        button9.Location = new Point(75, 39);
        button9.Name = "button9";
        button9.Size = new Size(30, 30);
        button9.TabIndex = 10;
        button9.UseVisualStyleBackColor = false;
        button9.Click += button9_Click;
        // 
        // button10
        // 
        button10.BackColor = Color.White;
        button10.Location = new Point(111, 39);
        button10.Name = "button10";
        button10.Size = new Size(30, 30);
        button10.TabIndex = 11;
        button10.UseVisualStyleBackColor = false;
        button10.Click += button10_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(label1);
        panel1.Controls.Add(trackBar1);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(714, 80);
        panel1.Name = "panel1";
        panel1.Size = new Size(153, 100);
        panel1.TabIndex = 4;
        // 
        // label1
        // 
        label1.Location = new Point(26, 5);
        label1.Name = "label1";
        label1.Size = new Size(109, 23);
        label1.TabIndex = 5;
        label1.Text = "Выбор толщины";
        // 
        // trackBar1
        // 
        trackBar1.Dock = DockStyle.Bottom;
        trackBar1.Location = new Point(0, 55);
        trackBar1.Name = "trackBar1";
        trackBar1.Size = new Size(153, 45);
        trackBar1.TabIndex = 0;
        trackBar1.ValueChanged += trackBar1_ValueChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(867, 445);
        Controls.Add(panel1);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Button button1;
    private Button button2;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Panel panel1;
    private Label label1;
    private TrackBar trackBar1;
    private ColorDialog colorDialog1;
    private SaveFileDialog saveFileDialog1;
}