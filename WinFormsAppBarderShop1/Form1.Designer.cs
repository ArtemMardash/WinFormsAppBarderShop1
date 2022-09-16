namespace WinFormsAppBarderShop1
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
            this.button1Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2SaveAndSolve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hours1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.HoursOfWaiting = new System.Windows.Forms.ColumnHeader();
            this.MinutesOfWaiting = new System.Windows.Forms.ColumnHeader();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AppointmentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImpatienceClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeToLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1Data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Load
            // 
            this.button1Load.Location = new System.Drawing.Point(23, 62);
            this.button1Load.Name = "button1Load";
            this.button1Load.Size = new System.Drawing.Size(112, 34);
            this.button1Load.TabIndex = 0;
            this.button1Load.Text = "Load Data";
            this.button1Load.UseVisualStyleBackColor = true;
            this.button1Load.Click += new System.EventHandler(this.button1Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solve:";
            // 
            // button2SaveAndSolve
            // 
            this.button2SaveAndSolve.Location = new System.Drawing.Point(532, 78);
            this.button2SaveAndSolve.Name = "button2SaveAndSolve";
            this.button2SaveAndSolve.Size = new System.Drawing.Size(158, 34);
            this.button2SaveAndSolve.TabIndex = 3;
            this.button2SaveAndSolve.Text = "Save and Solve";
            this.button2SaveAndSolve.UseVisualStyleBackColor = true;
            this.button2SaveAndSolve.Click += new System.EventHandler(this.button2SaveAndSolve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hours1,
            this.Minute});
            this.dataGridView1.Location = new System.Drawing.Point(436, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(369, 301);
            this.dataGridView1.TabIndex = 4;
            // 
            // Hours1
            // 
            this.Hours1.HeaderText = "Hours";
            this.Hours1.MinimumWidth = 8;
            this.Hours1.Name = "Hours1";
            this.Hours1.Width = 150;
            // 
            // Minute
            // 
            this.Minute.HeaderText = "Minutes";
            this.Minute.MinimumWidth = 8;
            this.Minute.Name = "Minute";
            this.Minute.Width = 150;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HoursOfWaiting,
            this.MinutesOfWaiting});
            this.listView1.Location = new System.Drawing.Point(12, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 301);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // HoursOfWaiting
            // 
            this.HoursOfWaiting.Text = "Hours";
            this.HoursOfWaiting.Width = 200;
            // 
            // MinutesOfWaiting
            // 
            this.MinutesOfWaiting.Text = "Minutes";
            this.MinutesOfWaiting.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentTime,
            this.ImpatienceClient,
            this.TimeToLeave});
            this.dataGridView2.Location = new System.Drawing.Point(66, 444);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(665, 312);
            this.dataGridView2.TabIndex = 6;
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.HeaderText = "Start time";
            this.AppointmentTime.MinimumWidth = 8;
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.Width = 200;
            // 
            // ImpatienceClient
            // 
            this.ImpatienceClient.HeaderText = "Impatience";
            this.ImpatienceClient.MinimumWidth = 8;
            this.ImpatienceClient.Name = "ImpatienceClient";
            this.ImpatienceClient.Width = 200;
            // 
            // TimeToLeave
            // 
            this.TimeToLeave.HeaderText = "Time to Leave";
            this.TimeToLeave.MinimumWidth = 8;
            this.TimeToLeave.Name = "TimeToLeave";
            this.TimeToLeave.Width = 200;
            // 
            // button1Data
            // 
            this.button1Data.Location = new System.Drawing.Point(12, 781);
            this.button1Data.Name = "button1Data";
            this.button1Data.Size = new System.Drawing.Size(788, 34);
            this.button1Data.TabIndex = 7;
            this.button1Data.Text = "Show Data with solve";
            this.button1Data.UseVisualStyleBackColor = true;
            this.button1Data.Click += new System.EventHandler(this.button1Data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 827);
            this.Controls.Add(this.button1Data);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2SaveAndSolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Load);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1Load;
        private Label label1;
        private Label label2;
        private Button button2SaveAndSolve;
        private DataGridView dataGridView1;
        private ListView listView1;
        private ColumnHeader HoursOfWaiting;
        private ColumnHeader MinutesOfWaiting;
        private DataGridViewTextBoxColumn Hours1;
        private DataGridViewTextBoxColumn Minute;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn AppointmentTime;
        private DataGridViewTextBoxColumn ImpatienceClient;
        private DataGridViewTextBoxColumn TimeToLeave;
        private Button button1Data;
    }
}