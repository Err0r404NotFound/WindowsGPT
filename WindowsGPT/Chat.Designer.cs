
namespace WindowsGPT
{
    partial class Chat
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Envia = new System.Windows.Forms.Panel();
            this.Mensaje_sms = new System.Windows.Forms.Label();
            this.nombre_sms = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtwriter = new System.Windows.Forms.ToolStripTextBox();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.Envia.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Envia);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(836, 491);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Envia
            // 
            this.Envia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(32)))));
            this.Envia.Controls.Add(this.Mensaje_sms);
            this.Envia.Controls.Add(this.nombre_sms);
            this.Envia.Dock = System.Windows.Forms.DockStyle.Top;
            this.Envia.Location = new System.Drawing.Point(3, 3);
            this.Envia.Name = "Envia";
            this.Envia.Size = new System.Drawing.Size(808, 74);
            this.Envia.TabIndex = 0;
            this.Envia.Visible = false;
            // 
            // Mensaje_sms
            // 
            this.Mensaje_sms.AutoSize = true;
            this.Mensaje_sms.BackColor = System.Drawing.Color.LightGreen;
            this.Mensaje_sms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mensaje_sms.Dock = System.Windows.Forms.DockStyle.Left;
            this.Mensaje_sms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mensaje_sms.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje_sms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Mensaje_sms.Location = new System.Drawing.Point(0, 29);
            this.Mensaje_sms.Margin = new System.Windows.Forms.Padding(0);
            this.Mensaje_sms.Name = "Mensaje_sms";
            this.Mensaje_sms.Padding = new System.Windows.Forms.Padding(5);
            this.Mensaje_sms.Size = new System.Drawing.Size(235, 32);
            this.Mensaje_sms.TabIndex = 1;
            this.Mensaje_sms.Text = "Me podrias abrir la calculadora?";
            this.Mensaje_sms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mensaje_sms.Visible = false;
            // 
            // nombre_sms
            // 
            this.nombre_sms.Dock = System.Windows.Forms.DockStyle.Top;
            this.nombre_sms.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_sms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombre_sms.Location = new System.Drawing.Point(0, 0);
            this.nombre_sms.Name = "nombre_sms";
            this.nombre_sms.Size = new System.Drawing.Size(808, 29);
            this.nombre_sms.TabIndex = 0;
            this.nombre_sms.Text = "Diego G.";
            this.nombre_sms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nombre_sms.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(32)))));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtwriter,
            this.btnSend,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 492);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(836, 53);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtwriter
            // 
            this.txtwriter.AcceptsReturn = true;
            this.txtwriter.AutoSize = false;
            this.txtwriter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(32)))));
            this.txtwriter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtwriter.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwriter.ForeColor = System.Drawing.SystemColors.Window;
            this.txtwriter.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.txtwriter.Name = "txtwriter";
            this.txtwriter.Size = new System.Drawing.Size(700, 54);
            // 
            // btnSend
            // 
            this.btnSend.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSend.AutoSize = false;
            this.btnSend.BackgroundImage = global::WindowsGPT.Properties.Resources.icons8_enviado_60;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSend.Image = global::WindowsGPT.Properties.Resources.icons8_enviado_60;
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(60, 50);
            this.btnSend.Text = "toolStripButton1";
            this.btnSend.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 1);
            this.label1.TabIndex = 1;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(836, 541);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Chat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsGTP";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Envia.ResumeLayout(false);
            this.Envia.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Envia;
        private System.Windows.Forms.Label Mensaje_sms;
        private System.Windows.Forms.Label nombre_sms;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtwriter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSend;
    }
}

