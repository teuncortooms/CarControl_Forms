namespace CarControl
{
    partial class CarControlForm
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
            this.bt_Up = new System.Windows.Forms.Button();
            this.bt_Down = new System.Windows.Forms.Button();
            this.bt_Right = new System.Windows.Forms.Button();
            this.bt_Left = new System.Windows.Forms.Button();
            this.tb_Log = new System.Windows.Forms.TextBox();
            this.tb_Received = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Up
            // 
            this.bt_Up.Location = new System.Drawing.Point(76, 157);
            this.bt_Up.Name = "bt_Up";
            this.bt_Up.Size = new System.Drawing.Size(23, 23);
            this.bt_Up.TabIndex = 0;
            this.bt_Up.Text = "^";
            this.bt_Up.UseVisualStyleBackColor = true;
            this.bt_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_Up_MouseDown);
            // 
            // bt_Down
            // 
            this.bt_Down.Location = new System.Drawing.Point(76, 186);
            this.bt_Down.Name = "bt_Down";
            this.bt_Down.Size = new System.Drawing.Size(24, 23);
            this.bt_Down.TabIndex = 1;
            this.bt_Down.UseVisualStyleBackColor = true;
            this.bt_Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_Down_MouseDown);
            // 
            // bt_Right
            // 
            this.bt_Right.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Right.Location = new System.Drawing.Point(106, 186);
            this.bt_Right.Name = "bt_Right";
            this.bt_Right.Size = new System.Drawing.Size(24, 23);
            this.bt_Right.TabIndex = 2;
            this.bt_Right.Text = ">";
            this.bt_Right.UseVisualStyleBackColor = false;
            this.bt_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_Right_MouseDown);
            // 
            // bt_Left
            // 
            this.bt_Left.Location = new System.Drawing.Point(46, 186);
            this.bt_Left.Name = "bt_Left";
            this.bt_Left.Size = new System.Drawing.Size(24, 23);
            this.bt_Left.TabIndex = 3;
            this.bt_Left.Text = "<";
            this.bt_Left.UseVisualStyleBackColor = true;
            this.bt_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bt_Left_MouseDown);
            // 
            // tb_Log
            // 
            this.tb_Log.Location = new System.Drawing.Point(175, 78);
            this.tb_Log.Multiline = true;
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.Size = new System.Drawing.Size(138, 131);
            this.tb_Log.TabIndex = 4;
            // 
            // tb_Received
            // 
            this.tb_Received.Location = new System.Drawing.Point(372, 78);
            this.tb_Received.Multiline = true;
            this.tb_Received.Name = "tb_Received";
            this.tb_Received.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Received.Size = new System.Drawing.Size(329, 243);
            this.tb_Received.TabIndex = 5;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(372, 49);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // CarControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.tb_Received);
            this.Controls.Add(this.tb_Log);
            this.Controls.Add(this.bt_Left);
            this.Controls.Add(this.bt_Right);
            this.Controls.Add(this.bt_Down);
            this.Controls.Add(this.bt_Up);
            this.Name = "CarControlForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Up;
        private System.Windows.Forms.Button bt_Down;
        private System.Windows.Forms.Button bt_Right;
        private System.Windows.Forms.Button bt_Left;
        private System.Windows.Forms.TextBox tb_Log;
        private System.Windows.Forms.TextBox tb_Received;
        private System.Windows.Forms.Button btn_Connect;
    }
}

