namespace WindowsFormsVerzweigungen_C_sharp
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.B_if = new System.Windows.Forms.Button();
			this.B_if_else = new System.Windows.Forms.Button();
			this.B_tern_Op = new System.Windows.Forms.Button();
			this.B_if_else_if = new System.Windows.Forms.Button();
			this.B_log_AND = new System.Windows.Forms.Button();
			this.B_log_OR = new System.Windows.Forms.Button();
			this.B_log_xOR = new System.Windows.Forms.Button();
			this.LBL_x = new System.Windows.Forms.Label();
			this.LBL_y = new System.Windows.Forms.Label();
			this.Nud_x = new System.Windows.Forms.NumericUpDown();
			this.Nud_y = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LBL_fixAnz = new System.Windows.Forms.Label();
			this.LBL_result = new System.Windows.Forms.Label();
			this.B_switch = new System.Windows.Forms.Button();
			this.B_switch2 = new System.Windows.Forms.Button();
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Nud_x)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Nud_y)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// B_if
			// 
			this.B_if.Location = new System.Drawing.Point(24, 24);
			this.B_if.Name = "B_if";
			this.B_if.Size = new System.Drawing.Size(137, 43);
			this.B_if.TabIndex = 2;
			this.B_if.Text = "if";
			this.B_if.UseVisualStyleBackColor = true;
			this.B_if.Click += new System.EventHandler(this.B_if_Click);
			// 
			// B_if_else
			// 
			this.B_if_else.Location = new System.Drawing.Point(24, 77);
			this.B_if_else.Name = "B_if_else";
			this.B_if_else.Size = new System.Drawing.Size(137, 43);
			this.B_if_else.TabIndex = 3;
			this.B_if_else.Text = "if else";
			this.B_if_else.UseVisualStyleBackColor = true;
			this.B_if_else.Click += new System.EventHandler(this.B_if_else_Click);
			// 
			// B_tern_Op
			// 
			this.B_tern_Op.Location = new System.Drawing.Point(24, 126);
			this.B_tern_Op.Name = "B_tern_Op";
			this.B_tern_Op.Size = new System.Drawing.Size(137, 43);
			this.B_tern_Op.TabIndex = 4;
			this.B_tern_Op.Text = "Ternärer Operator";
			this.B_tern_Op.UseVisualStyleBackColor = true;
			this.B_tern_Op.Click += new System.EventHandler(this.B_tern_Op_Click);
			// 
			// B_if_else_if
			// 
			this.B_if_else_if.Location = new System.Drawing.Point(24, 175);
			this.B_if_else_if.Name = "B_if_else_if";
			this.B_if_else_if.Size = new System.Drawing.Size(137, 43);
			this.B_if_else_if.TabIndex = 5;
			this.B_if_else_if.Text = "if else if";
			this.B_if_else_if.UseVisualStyleBackColor = true;
			this.B_if_else_if.Click += new System.EventHandler(this.B_if_else_if_Click);
			// 
			// B_log_AND
			// 
			this.B_log_AND.Location = new System.Drawing.Point(24, 224);
			this.B_log_AND.Name = "B_log_AND";
			this.B_log_AND.Size = new System.Drawing.Size(137, 43);
			this.B_log_AND.TabIndex = 6;
			this.B_log_AND.Text = "log. Und";
			this.B_log_AND.UseVisualStyleBackColor = true;
			this.B_log_AND.Click += new System.EventHandler(this.B_log_AND_Click);
			// 
			// B_log_OR
			// 
			this.B_log_OR.Location = new System.Drawing.Point(24, 273);
			this.B_log_OR.Name = "B_log_OR";
			this.B_log_OR.Size = new System.Drawing.Size(137, 43);
			this.B_log_OR.TabIndex = 7;
			this.B_log_OR.Text = "log. Oder";
			this.B_log_OR.UseVisualStyleBackColor = true;
			this.B_log_OR.Click += new System.EventHandler(this.B_log_OR_Click);
			// 
			// B_log_xOR
			// 
			this.B_log_xOR.Location = new System.Drawing.Point(24, 322);
			this.B_log_xOR.Name = "B_log_xOR";
			this.B_log_xOR.Size = new System.Drawing.Size(137, 43);
			this.B_log_xOR.TabIndex = 8;
			this.B_log_xOR.Text = "log. exkl. Oder";
			this.B_log_xOR.UseVisualStyleBackColor = true;
			this.B_log_xOR.Click += new System.EventHandler(this.B_log_xOR_Click);
			// 
			// LBL_x
			// 
			this.LBL_x.AutoSize = true;
			this.LBL_x.Location = new System.Drawing.Point(377, 61);
			this.LBL_x.Name = "LBL_x";
			this.LBL_x.Size = new System.Drawing.Size(18, 17);
			this.LBL_x.TabIndex = 7;
			this.LBL_x.Text = "x:";
			// 
			// LBL_y
			// 
			this.LBL_y.AutoSize = true;
			this.LBL_y.Location = new System.Drawing.Point(377, 103);
			this.LBL_y.Name = "LBL_y";
			this.LBL_y.Size = new System.Drawing.Size(19, 17);
			this.LBL_y.TabIndex = 8;
			this.LBL_y.Text = "y:";
			// 
			// Nud_x
			// 
			this.Nud_x.Location = new System.Drawing.Point(418, 59);
			this.Nud_x.Name = "Nud_x";
			this.Nud_x.Size = new System.Drawing.Size(120, 22);
			this.Nud_x.TabIndex = 0;
			this.Nud_x.ValueChanged += new System.EventHandler(this.Nud_x_ValueChanged);
			// 
			// Nud_y
			// 
			this.Nud_y.Location = new System.Drawing.Point(418, 101);
			this.Nud_y.Name = "Nud_y";
			this.Nud_y.Size = new System.Drawing.Size(120, 22);
			this.Nud_y.TabIndex = 1;
			this.Nud_y.ValueChanged += new System.EventHandler(this.Nud_y_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.domainUpDown1);
			this.panel1.Controls.Add(this.B_switch2);
			this.panel1.Controls.Add(this.B_switch);
			this.panel1.Controls.Add(this.LBL_result);
			this.panel1.Controls.Add(this.LBL_fixAnz);
			this.panel1.Controls.Add(this.Nud_y);
			this.panel1.Controls.Add(this.Nud_x);
			this.panel1.Controls.Add(this.LBL_y);
			this.panel1.Controls.Add(this.LBL_x);
			this.panel1.Controls.Add(this.B_log_xOR);
			this.panel1.Controls.Add(this.B_log_OR);
			this.panel1.Controls.Add(this.B_log_AND);
			this.panel1.Controls.Add(this.B_if_else_if);
			this.panel1.Controls.Add(this.B_tern_Op);
			this.panel1.Controls.Add(this.B_if_else);
			this.panel1.Controls.Add(this.B_if);
			this.panel1.Location = new System.Drawing.Point(25, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(665, 392);
			this.panel1.TabIndex = 11;
			// 
			// LBL_fixAnz
			// 
			this.LBL_fixAnz.AutoSize = true;
			this.LBL_fixAnz.Location = new System.Drawing.Point(226, 152);
			this.LBL_fixAnz.Name = "LBL_fixAnz";
			this.LBL_fixAnz.Size = new System.Drawing.Size(68, 17);
			this.LBL_fixAnz.TabIndex = 11;
			this.LBL_fixAnz.Text = "Ergebnis:";
			// 
			// LBL_result
			// 
			this.LBL_result.AutoSize = true;
			this.LBL_result.Location = new System.Drawing.Point(296, 152);
			this.LBL_result.Name = "LBL_result";
			this.LBL_result.Size = new System.Drawing.Size(0, 17);
			this.LBL_result.TabIndex = 12;
			// 
			// B_switch
			// 
			this.B_switch.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.B_switch.Location = new System.Drawing.Point(229, 273);
			this.B_switch.Name = "B_switch";
			this.B_switch.Size = new System.Drawing.Size(166, 43);
			this.B_switch.TabIndex = 13;
			this.B_switch.Text = "switch ... case Teil 1";
			this.B_switch.UseVisualStyleBackColor = false;
			this.B_switch.Click += new System.EventHandler(this.B_switch_Click);
			// 
			// B_switch2
			// 
			this.B_switch2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.B_switch2.Location = new System.Drawing.Point(230, 322);
			this.B_switch2.Name = "B_switch2";
			this.B_switch2.Size = new System.Drawing.Size(166, 43);
			this.B_switch2.TabIndex = 14;
			this.B_switch2.Text = "switch ... case Teil 2";
			this.B_switch2.UseVisualStyleBackColor = false;
			this.B_switch2.Click += new System.EventHandler(this.B_switch2_Click);
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Items.Add("Bordeaux");
			this.domainUpDown1.Items.Add("Nizza");
			this.domainUpDown1.Items.Add("Berlin");
			this.domainUpDown1.Location = new System.Drawing.Point(418, 333);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.Size = new System.Drawing.Size(176, 22);
			this.domainUpDown1.TabIndex = 15;
			this.domainUpDown1.Text = "Bitte Stad wählen";
			this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.Nud_x)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Nud_y)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button B_if;
		private System.Windows.Forms.Button B_if_else;
		private System.Windows.Forms.Button B_tern_Op;
		private System.Windows.Forms.Button B_if_else_if;
		private System.Windows.Forms.Button B_log_AND;
		private System.Windows.Forms.Button B_log_OR;
		private System.Windows.Forms.Button B_log_xOR;
		private System.Windows.Forms.Label LBL_x;
		private System.Windows.Forms.Label LBL_y;
		private System.Windows.Forms.NumericUpDown Nud_x;
		private System.Windows.Forms.NumericUpDown Nud_y;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label LBL_result;
		private System.Windows.Forms.Label LBL_fixAnz;
		private System.Windows.Forms.Button B_switch;
		private System.Windows.Forms.Button B_switch2;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
	}
}

