namespace DesafioRestfy
{
    partial class RestfyForm
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
            this.consumeButton = new System.Windows.Forms.Button();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HashDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // consumeButton
            // 
            this.consumeButton.Location = new System.Drawing.Point(22, 12);
            this.consumeButton.Name = "consumeButton";
            this.consumeButton.Size = new System.Drawing.Size(99, 23);
            this.consumeButton.TabIndex = 1;
            this.consumeButton.Text = "Consumir API";
            this.consumeButton.UseVisualStyleBackColor = true;
            this.consumeButton.Click += new System.EventHandler(this.consumeButton_Click);
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(364, 54);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(157, 23);
            this.companyTextBox.TabIndex = 3;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(78, 54);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(157, 23);
            this.userTextBox.TabIndex = 3;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(306, 57);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(58, 15);
            this.companyLabel.TabIndex = 4;
            this.companyLabel.Text = "Empresa :";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(22, 57);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 15);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Usuário :";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(546, 54);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "Filtrar";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Nome";
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Empresa";
            this.Company.Name = "Company";
            this.Company.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Hash
            // 
            this.Hash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hash.DataPropertyName = "Hash";
            this.Hash.HeaderText = "Hash";
            this.Hash.Name = "Hash";
            this.Hash.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HashDescription
            // 
            this.HashDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HashDescription.DataPropertyName = "HashDescription";
            this.HashDescription.HeaderText = "Hash Desc";
            this.HashDescription.Name = "HashDescription";
            this.HashDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Company,
            this.Hash,
            this.HashDescription});
            this.dataGrid.Location = new System.Drawing.Point(12, 94);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(764, 334);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.Text = "dataGrid";
            // 
            // RestfyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.consumeButton);
            this.Controls.Add(this.dataGrid);
            this.Text = "Desafio Restfy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button consumeButton;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn HashDescription;
    }
}

