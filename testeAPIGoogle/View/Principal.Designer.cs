namespace testeAPIGoogle
{
    partial class Principal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnConsuAPI = new System.Windows.Forms.Button();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEndConsu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsuTodos = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCad);
            this.groupBox1.Controls.Add(this.btnConsuAPI);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(697, 49);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(88, 28);
            this.btnCad.TabIndex = 7;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnConsuAPI
            // 
            this.btnConsuAPI.Location = new System.Drawing.Point(697, 16);
            this.btnConsuAPI.Name = "btnConsuAPI";
            this.btnConsuAPI.Size = new System.Drawing.Size(88, 28);
            this.btnConsuAPI.TabIndex = 6;
            this.btnConsuAPI.Text = "Consultar API";
            this.btnConsuAPI.UseVisualStyleBackColor = true;
            this.btnConsuAPI.Click += new System.EventHandler(this.btnConsuAPI_Click);
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(248, 54);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Latitude:";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(77, 54);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 20);
            this.txtLong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longetude: ";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(77, 24);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(614, 20);
            this.txtEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEndConsu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnConsuTodos);
            this.groupBox2.Controls.Add(this.dgvResultados);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar";
            // 
            // txtEndConsu
            // 
            this.txtEndConsu.Location = new System.Drawing.Point(77, 24);
            this.txtEndConsu.Name = "txtEndConsu";
            this.txtEndConsu.Size = new System.Drawing.Size(567, 20);
            this.txtEndConsu.TabIndex = 9;
            this.txtEndConsu.TextChanged += new System.EventHandler(this.txtEndConsu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endereço:";
            // 
            // btnConsuTodos
            // 
            this.btnConsuTodos.Location = new System.Drawing.Point(666, 19);
            this.btnConsuTodos.Name = "btnConsuTodos";
            this.btnConsuTodos.Size = new System.Drawing.Size(119, 28);
            this.btnConsuTodos.TabIndex = 8;
            this.btnConsuTodos.Text = "Consultar Todos";
            this.btnConsuTodos.UseVisualStyleBackColor = true;
            this.btnConsuTodos.Click += new System.EventHandler(this.btnConsuTodos_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(0, 56);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.Size = new System.Drawing.Size(791, 149);
            this.dgvResultados.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnConsuAPI;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnConsuTodos;
        private System.Windows.Forms.TextBox txtEndConsu;
        private System.Windows.Forms.Label label4;
    }
}

