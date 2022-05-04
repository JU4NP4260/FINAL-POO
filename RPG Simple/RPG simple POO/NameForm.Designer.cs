namespace RPG_simple_POO
{
    partial class NameForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Occidental");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Oriental");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPlayerRace = new System.Windows.Forms.ListView();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Jugador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del jugador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 23);
            this.txtName.TabIndex = 2;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(68, 257);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(190, 47);
            this.btnCreatePlayer.TabIndex = 3;
            this.btnCreatePlayer.Text = "Confirmar creación del personaje";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raza del personaje";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstPlayerRace
            // 
            this.lstPlayerRace.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lstPlayerRace.Location = new System.Drawing.Point(12, 159);
            this.lstPlayerRace.Name = "lstPlayerRace";
            this.lstPlayerRace.Size = new System.Drawing.Size(308, 58);
            this.lstPlayerRace.TabIndex = 6;
            this.lstPlayerRace.UseCompatibleStateImageBehavior = false;
            this.lstPlayerRace.View = System.Windows.Forms.View.List;
            this.lstPlayerRace.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.ForeColor = System.Drawing.Color.Red;
            this.lblErrorText.Location = new System.Drawing.Point(17, 103);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(141, 15);
            this.lblErrorText.TabIndex = 7;
            this.lblErrorText.Text = "No se ingresó un nombre";
            this.lblErrorText.Visible = false;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 316);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrorText);
            this.Controls.Add(this.lstPlayerRace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear un nuevo jugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Button btnCreatePlayer;
        private Label label3;
        private ListView lstPlayerRace;
        private Label lblErrorText;
    }
}