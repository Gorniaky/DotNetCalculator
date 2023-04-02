namespace DotNetCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            buttonDiv = new Button();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMul = new Button();
            buttonCE = new Button();
            buttonBack = new Button();
            buttonEqu = new Button();
            buttonDec = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button0 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // buttonDiv
            // 
            buttonDiv.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDiv.ForeColor = SystemColors.ControlLight;
            buttonDiv.Location = new Point(302, 376);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(74, 74);
            buttonDiv.TabIndex = 37;
            buttonDiv.TabStop = false;
            buttonDiv.Text = "/";
            buttonDiv.Click += ButtonDiv_Click;
            buttonDiv.KeyDown += KeyDownListener;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = SystemColors.ControlLight;
            buttonAdd.Location = new Point(302, 94);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(74, 74);
            buttonAdd.TabIndex = 38;
            buttonAdd.TabStop = false;
            buttonAdd.Text = "+";
            buttonAdd.Click += ButtonAdd_Click;
            buttonAdd.KeyDown += KeyDownListener;
            // 
            // buttonSub
            // 
            buttonSub.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSub.ForeColor = SystemColors.ControlLight;
            buttonSub.Location = new Point(302, 188);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(74, 74);
            buttonSub.TabIndex = 36;
            buttonSub.TabStop = false;
            buttonSub.Text = "-";
            buttonSub.Click += ButtonSub_Click;
            buttonSub.KeyDown += KeyDownListener;
            // 
            // buttonMul
            // 
            buttonMul.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMul.ForeColor = SystemColors.ControlLight;
            buttonMul.Location = new Point(302, 282);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(74, 74);
            buttonMul.TabIndex = 35;
            buttonMul.TabStop = false;
            buttonMul.Text = "*";
            buttonMul.Click += ButtonMul_Click;
            buttonMul.KeyDown += KeyDownListener;
            // 
            // buttonCE
            // 
            buttonCE.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCE.ForeColor = SystemColors.ControlLight;
            buttonCE.Location = new Point(396, 94);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(74, 74);
            buttonCE.TabIndex = 32;
            buttonCE.TabStop = false;
            buttonCE.Text = "CE";
            buttonCE.Click += ButtonCE_Click;
            buttonCE.KeyDown += KeyDownListener;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.ForeColor = SystemColors.ControlLight;
            buttonBack.Location = new Point(396, 188);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(74, 74);
            buttonBack.TabIndex = 33;
            buttonBack.TabStop = false;
            buttonBack.Text = "<";
            buttonBack.Click += ButtonBack_Click;
            buttonBack.KeyDown += KeyDownListener;
            // 
            // buttonEqu
            // 
            buttonEqu.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqu.ForeColor = SystemColors.ControlLight;
            buttonEqu.Location = new Point(396, 282);
            buttonEqu.Name = "buttonEqu";
            buttonEqu.Size = new Size(74, 168);
            buttonEqu.TabIndex = 34;
            buttonEqu.TabStop = false;
            buttonEqu.Text = "=";
            buttonEqu.Click += ButtonEqual_Click;
            buttonEqu.KeyDown += KeyDownListener;
            // 
            // buttonDec
            // 
            buttonDec.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDec.ForeColor = SystemColors.ControlLight;
            buttonDec.Location = new Point(208, 376);
            buttonDec.Name = "buttonDec";
            buttonDec.Size = new Size(74, 74);
            buttonDec.TabIndex = 31;
            buttonDec.TabStop = false;
            buttonDec.Text = ".";
            buttonDec.Click += ButtonDot_Click;
            buttonDec.KeyDown += KeyDownListener;
            // 
            // button7
            // 
            button7.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlLight;
            button7.Location = new Point(20, 94);
            button7.Name = "button7";
            button7.Size = new Size(74, 74);
            button7.TabIndex = 28;
            button7.TabStop = false;
            button7.Text = "7";
            button7.Click += ButtonNumberClick;
            button7.KeyDown += KeyDownListener;
            // 
            // button8
            // 
            button8.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlLight;
            button8.Location = new Point(114, 94);
            button8.Name = "button8";
            button8.Size = new Size(74, 74);
            button8.TabIndex = 29;
            button8.TabStop = false;
            button8.Text = "8";
            button8.Click += ButtonNumberClick;
            button8.KeyDown += KeyDownListener;
            // 
            // button9
            // 
            button9.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlLight;
            button9.Location = new Point(208, 94);
            button9.Name = "button9";
            button9.Size = new Size(74, 74);
            button9.TabIndex = 30;
            button9.TabStop = false;
            button9.Text = "9";
            button9.Click += ButtonNumberClick;
            button9.KeyDown += KeyDownListener;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLight;
            button4.Location = new Point(20, 188);
            button4.Name = "button4";
            button4.Size = new Size(74, 74);
            button4.TabIndex = 25;
            button4.TabStop = false;
            button4.Text = "4";
            button4.Click += ButtonNumberClick;
            button4.KeyDown += KeyDownListener;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLight;
            button5.Location = new Point(114, 188);
            button5.Name = "button5";
            button5.Size = new Size(74, 74);
            button5.TabIndex = 26;
            button5.TabStop = false;
            button5.Text = "5";
            button5.Click += ButtonNumberClick;
            button5.KeyDown += KeyDownListener;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLight;
            button6.Location = new Point(208, 188);
            button6.Name = "button6";
            button6.Size = new Size(74, 74);
            button6.TabIndex = 27;
            button6.TabStop = false;
            button6.Text = "6";
            button6.Click += ButtonNumberClick;
            button6.KeyDown += KeyDownListener;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(208, 282);
            button3.Name = "button3";
            button3.Size = new Size(74, 74);
            button3.TabIndex = 24;
            button3.TabStop = false;
            button3.Text = "3";
            button3.Click += ButtonNumberClick;
            button3.KeyDown += KeyDownListener;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLight;
            button2.Location = new Point(114, 282);
            button2.Name = "button2";
            button2.Size = new Size(74, 74);
            button2.TabIndex = 23;
            button2.TabStop = false;
            button2.Text = "2";
            button2.Click += ButtonNumberClick;
            button2.KeyDown += KeyDownListener;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Location = new Point(20, 282);
            button1.Name = "button1";
            button1.Size = new Size(74, 74);
            button1.TabIndex = 22;
            button1.TabStop = false;
            button1.Text = "1";
            button1.Click += ButtonNumberClick;
            button1.KeyDown += KeyDownListener;
            // 
            // button0
            // 
            button0.Font = new Font("Arial Rounded MT Bold", 26F, FontStyle.Regular, GraphicsUnit.Point);
            button0.ForeColor = SystemColors.ControlLight;
            button0.Location = new Point(20, 376);
            button0.Name = "button0";
            button0.Size = new Size(168, 74);
            button0.TabIndex = 20;
            button0.TabStop = false;
            button0.Text = "0";
            button0.Click += ButtonNumberClick;
            button0.KeyDown += KeyDownListener;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Desktop;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(0, 20);
            textBox1.MaxLength = 20;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(489, 47);
            textBox1.TabIndex = 21;
            textBox1.TabStop = false;
            textBox1.Text = "0";
            textBox1.KeyDown += KeyDownListener;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Desktop;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(20, 0);
            textBox2.MaxLength = 20;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(449, 24);
            textBox2.TabIndex = 39;
            textBox2.TabStop = false;
            textBox2.KeyDown += KeyDownListener;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(489, 466);
            Controls.Add(buttonDiv);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSub);
            Controls.Add(buttonMul);
            Controls.Add(buttonCE);
            Controls.Add(buttonBack);
            Controls.Add(buttonEqu);
            Controls.Add(buttonDec);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            KeyDown += KeyDownListener;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDiv;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMul;
        private Button buttonCE;
        private Button buttonBack;
        private Button buttonEqu;
        private Button buttonDec;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button0;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}