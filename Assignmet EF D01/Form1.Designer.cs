namespace Assignmet_EF_D01
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
            components = new System.ComponentModel.Container();
            dataGridViewStudents = new DataGridView();
            textBoxFname = new TextBox();
            textBoxAge = new TextBox();
            textBoxAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxDepartment = new ComboBox();
            buttonAdd = new Button();
            textBoxLname = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label5 = new Label();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(3, 256);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(776, 182);
            dataGridViewStudents.TabIndex = 0;
            dataGridViewStudents.RowHeaderMouseDoubleClick += dataGridViewStudents_RowHeaderMouseDoubleClick;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(663, 12);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(125, 27);
            textBoxFname.TabIndex = 1;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(663, 87);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(125, 27);
            textBoxAge.TabIndex = 2;
            textBoxAge.TextChanged += textBoxAge_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(663, 135);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 4;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(583, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 5;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 142);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(542, 180);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(637, 177);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(151, 28);
            comboBoxDepartment.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(694, 211);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(663, 45);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(125, 27);
            textBoxLname.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 52);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 12;
            label5.Text = "LastName";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(581, 211);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += button2_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(471, 211);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(label5);
            Controls.Add(textBoxLname);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxDepartment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxFname);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private TextBox textBoxFname;
        private TextBox textBoxAge;
        private TextBox textBoxAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxDepartment;
        private Button buttonAdd;
        private TextBox textBoxLname;
        private ContextMenuStrip contextMenuStrip1;
        private Label label5;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}
