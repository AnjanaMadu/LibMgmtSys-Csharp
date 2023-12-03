namespace MyApp1
{
    partial class LibraryApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            stuFindBtn = new Button();
            label6 = new Label();
            findStuN = new TextBox();
            groupBox2 = new GroupBox();
            stuRmBtn = new Button();
            label5 = new Label();
            rmStuID = new TextBox();
            groupBox1 = new GroupBox();
            addStuBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            addStuG = new TextBox();
            addStuN = new TextBox();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            findBkBtn = new Button();
            label4 = new Label();
            findBkN = new TextBox();
            groupBox5 = new GroupBox();
            rnBkBtn = new Button();
            label7 = new Label();
            rmBkId = new TextBox();
            groupBox6 = new GroupBox();
            addBkbtn = new Button();
            label8 = new Label();
            label9 = new Label();
            addBkA = new TextBox();
            addbkN = new TextBox();
            tabPage3 = new TabPage();
            hvntRet = new DataGridView();
            label12 = new Label();
            numStu = new TextBox();
            numBk = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tabPage4 = new TabPage();
            groupBox7 = new GroupBox();
            RetBtn = new Button();
            label13 = new Label();
            label14 = new Label();
            retStuId = new TextBox();
            retBkId = new TextBox();
            groupBox8 = new GroupBox();
            Issuebtn = new Button();
            label15 = new Label();
            label16 = new Label();
            IssueStuId = new TextBox();
            issueBkId = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hvntRet).BeginInit();
            tabPage4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(909, 671);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(901, 638);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Students";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(stuFindBtn);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(findStuN);
            groupBox3.Location = new Point(18, 314);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(858, 302);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Find Students";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(817, 187);
            dataGridView1.TabIndex = 5;
            // 
            // stuFindBtn
            // 
            stuFindBtn.Location = new Point(734, 35);
            stuFindBtn.Name = "stuFindBtn";
            stuFindBtn.Size = new Size(94, 28);
            stuFindBtn.TabIndex = 4;
            stuFindBtn.Text = "Find";
            stuFindBtn.UseVisualStyleBackColor = true;
            stuFindBtn.Click += stuFindBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 40);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 1;
            label6.Text = "Student Name:";
            // 
            // findStuN
            // 
            findStuN.Location = new Point(186, 35);
            findStuN.Name = "findStuN";
            findStuN.Size = new Size(542, 27);
            findStuN.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stuRmBtn);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(rmStuID);
            groupBox2.Location = new Point(18, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 123);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Remove Students";
            // 
            // stuRmBtn
            // 
            stuRmBtn.Location = new Point(659, 79);
            stuRmBtn.Name = "stuRmBtn";
            stuRmBtn.Size = new Size(166, 26);
            stuRmBtn.TabIndex = 4;
            stuRmBtn.Text = "Remove";
            stuRmBtn.UseVisualStyleBackColor = true;
            stuRmBtn.Click += stuRmBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 40);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 1;
            label5.Text = "Student ID:";
            // 
            // rmStuID
            // 
            rmStuID.Location = new Point(186, 35);
            rmStuID.Name = "rmStuID";
            rmStuID.Size = new Size(642, 27);
            rmStuID.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addStuBtn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(addStuG);
            groupBox1.Controls.Add(addStuN);
            groupBox1.Location = new Point(18, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Students";
            // 
            // addStuBtn
            // 
            addStuBtn.Location = new Point(662, 108);
            addStuBtn.Name = "addStuBtn";
            addStuBtn.Size = new Size(166, 26);
            addStuBtn.TabIndex = 4;
            addStuBtn.Text = "Add";
            addStuBtn.UseVisualStyleBackColor = true;
            addStuBtn.Click += addStuBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 73);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 3;
            label3.Text = "Student Grade:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 40);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Student Name:";
            // 
            // addStuG
            // 
            addStuG.Location = new Point(186, 68);
            addStuG.Name = "addStuG";
            addStuG.Size = new Size(642, 27);
            addStuG.TabIndex = 2;
            // 
            // addStuN
            // 
            addStuN.Location = new Point(186, 35);
            addStuN.Name = "addStuN";
            addStuN.Size = new Size(642, 27);
            addStuN.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(901, 638);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Books";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Controls.Add(findBkBtn);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(findBkN);
            groupBox4.Location = new Point(21, 317);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(858, 302);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Finf Books";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(25, 84);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(817, 187);
            dataGridView2.TabIndex = 5;
            // 
            // findBkBtn
            // 
            findBkBtn.Location = new Point(734, 35);
            findBkBtn.Name = "findBkBtn";
            findBkBtn.Size = new Size(94, 28);
            findBkBtn.TabIndex = 4;
            findBkBtn.Text = "Find";
            findBkBtn.UseVisualStyleBackColor = true;
            findBkBtn.Click += findBkBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 40);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 1;
            label4.Text = "Book Name";
            // 
            // findBkN
            // 
            findBkN.Location = new Point(186, 35);
            findBkN.Name = "findBkN";
            findBkN.Size = new Size(542, 27);
            findBkN.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rnBkBtn);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(rmBkId);
            groupBox5.Location = new Point(21, 184);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(858, 123);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Remove Books";
            // 
            // rnBkBtn
            // 
            rnBkBtn.Location = new Point(659, 79);
            rnBkBtn.Name = "rnBkBtn";
            rnBkBtn.Size = new Size(166, 26);
            rnBkBtn.TabIndex = 4;
            rnBkBtn.Text = "Remove";
            rnBkBtn.UseVisualStyleBackColor = true;
            rnBkBtn.Click += rnBkBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 40);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 1;
            label7.Text = "Book ID";
            // 
            // rmBkId
            // 
            rmBkId.Location = new Point(186, 35);
            rmBkId.Name = "rmBkId";
            rmBkId.Size = new Size(642, 27);
            rmBkId.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(addBkbtn);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(addBkA);
            groupBox6.Controls.Add(addbkN);
            groupBox6.Location = new Point(21, 19);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(858, 147);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Add Books";
            // 
            // addBkbtn
            // 
            addBkbtn.Location = new Point(662, 108);
            addBkbtn.Name = "addBkbtn";
            addBkbtn.Size = new Size(166, 26);
            addBkbtn.TabIndex = 4;
            addBkbtn.Text = "Add";
            addBkbtn.UseVisualStyleBackColor = true;
            addBkbtn.Click += addBkbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 73);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 3;
            label8.Text = "Book author";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 40);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 1;
            label9.Text = "Book name:";
            // 
            // addBkA
            // 
            addBkA.Location = new Point(186, 68);
            addBkA.Name = "addBkA";
            addBkA.Size = new Size(642, 27);
            addBkA.TabIndex = 2;
            // 
            // addbkN
            // 
            addbkN.Location = new Point(186, 35);
            addbkN.Name = "addbkN";
            addbkN.Size = new Size(642, 27);
            addbkN.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(hvntRet);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(numStu);
            tabPage3.Controls.Add(numBk);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(901, 638);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reports";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // hvntRet
            // 
            hvntRet.BackgroundColor = SystemColors.Control;
            hvntRet.BorderStyle = BorderStyle.None;
            hvntRet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hvntRet.Location = new Point(37, 209);
            hvntRet.Name = "hvntRet";
            hvntRet.RowHeadersWidth = 51;
            hvntRet.Size = new Size(823, 402);
            hvntRet.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(37, 158);
            label12.Name = "label12";
            label12.Size = new Size(263, 28);
            label12.TabIndex = 4;
            label12.Text = "Books that havent returned";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // numStu
            // 
            numStu.BorderStyle = BorderStyle.None;
            numStu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numStu.Location = new Point(250, 91);
            numStu.Name = "numStu";
            numStu.Size = new Size(125, 27);
            numStu.TabIndex = 3;
            // 
            // numBk
            // 
            numBk.BorderStyle = BorderStyle.None;
            numBk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numBk.Location = new Point(250, 40);
            numBk.Name = "numBk";
            numBk.Size = new Size(125, 27);
            numBk.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(37, 91);
            label11.Name = "label11";
            label11.Size = new Size(153, 28);
            label11.TabIndex = 1;
            label11.Text = "Total Students:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(37, 39);
            label10.Name = "label10";
            label10.Size = new Size(133, 28);
            label10.TabIndex = 0;
            label10.Text = "Total Books: ";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox7);
            tabPage4.Controls.Add(groupBox8);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(901, 638);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Issue Books";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(RetBtn);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(retStuId);
            groupBox7.Controls.Add(retBkId);
            groupBox7.Location = new Point(21, 246);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(858, 147);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Return Books";
            // 
            // RetBtn
            // 
            RetBtn.Location = new Point(662, 108);
            RetBtn.Name = "RetBtn";
            RetBtn.Size = new Size(166, 26);
            RetBtn.TabIndex = 4;
            RetBtn.Text = "Return";
            RetBtn.UseVisualStyleBackColor = true;
            RetBtn.Click += RetBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(48, 73);
            label13.Name = "label13";
            label13.Size = new Size(79, 20);
            label13.TabIndex = 3;
            label13.Text = "Student ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(48, 40);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 1;
            label14.Text = "Book ID";
            // 
            // retStuId
            // 
            retStuId.Location = new Point(186, 68);
            retStuId.Name = "retStuId";
            retStuId.Size = new Size(642, 27);
            retStuId.TabIndex = 2;
            // 
            // retBkId
            // 
            retBkId.Location = new Point(186, 35);
            retBkId.Name = "retBkId";
            retBkId.Size = new Size(642, 27);
            retBkId.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(Issuebtn);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(label16);
            groupBox8.Controls.Add(IssueStuId);
            groupBox8.Controls.Add(issueBkId);
            groupBox8.Location = new Point(21, 36);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(858, 147);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Issue Books";
            // 
            // Issuebtn
            // 
            Issuebtn.Location = new Point(662, 108);
            Issuebtn.Name = "Issuebtn";
            Issuebtn.Size = new Size(166, 26);
            Issuebtn.TabIndex = 4;
            Issuebtn.Text = "Issue";
            Issuebtn.UseVisualStyleBackColor = true;
            Issuebtn.Click += Issuebtn_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(48, 73);
            label15.Name = "label15";
            label15.Size = new Size(79, 20);
            label15.TabIndex = 3;
            label15.Text = "Student ID";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(48, 40);
            label16.Name = "label16";
            label16.Size = new Size(62, 20);
            label16.TabIndex = 1;
            label16.Text = "Book ID";
            // 
            // IssueStuId
            // 
            IssueStuId.Location = new Point(186, 68);
            IssueStuId.Name = "IssueStuId";
            IssueStuId.Size = new Size(642, 27);
            IssueStuId.TabIndex = 2;
            // 
            // issueBkId
            // 
            issueBkId.Location = new Point(186, 35);
            issueBkId.Name = "issueBkId";
            issueBkId.Size = new Size(642, 27);
            issueBkId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 31);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Library Admin Panel";
            // 
            // LibraryApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 726);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "LibraryApp";
            Text = "LibraryApp";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hvntRet).EndInit();
            tabPage4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox addStuG;
        private TextBox addStuN;
        private Button addStuBtn;
        private GroupBox groupBox2;
        private Button stuRmBtn;
        private Label label5;
        private TextBox rmStuID;
        private GroupBox groupBox3;
        private Button stuFindBtn;
        private Label label6;
        private TextBox findStuN;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private Button findBkBtn;
        private Label label4;
        private TextBox findBkN;
        private GroupBox groupBox5;
        private Button rnBkBtn;
        private Label label7;
        private TextBox rmBkId;
        private GroupBox groupBox6;
        private Button addBkbtn;
        private Label label8;
        private Label label9;
        private TextBox addBkA;
        private TextBox addbkN;
        private Label label11;
        private Label label10;
        private Label label12;
        private TextBox numStu;
        private TextBox numBk;
        private DataGridView hvntRet;
        private TabPage tabPage4;
        private GroupBox groupBox7;
        private Button RetBtn;
        private Label label13;
        private Label label14;
        private TextBox retStuId;
        private TextBox retBkId;
        private GroupBox groupBox8;
        private Button Issuebtn;
        private Label label15;
        private Label label16;
        private TextBox IssueStuId;
        private TextBox issueBkId;
    }
}