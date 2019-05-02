namespace HW3_B10523025_陳冠廷
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.draw_circle_bottom = new System.Windows.Forms.Button();
            this.draw_line_bottom = new System.Windows.Forms.Button();
            this.clear_bottom = new System.Windows.Forms.Button();
            this.x_position = new System.Windows.Forms.TextBox();
            this.y_position = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circle1_text = new System.Windows.Forms.TextBox();
            this.circle2_text = new System.Windows.Forms.TextBox();
            this.weight_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // draw_circle_bottom
            // 
            this.draw_circle_bottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.draw_circle_bottom.Font = new System.Drawing.Font("新細明體", 12F);
            this.draw_circle_bottom.Location = new System.Drawing.Point(12, 603);
            this.draw_circle_bottom.Name = "draw_circle_bottom";
            this.draw_circle_bottom.Size = new System.Drawing.Size(153, 34);
            this.draw_circle_bottom.TabIndex = 0;
            this.draw_circle_bottom.Text = "draw point";
            this.draw_circle_bottom.UseVisualStyleBackColor = false;
            this.draw_circle_bottom.Click += new System.EventHandler(this.button1_Click);
            // 
            // draw_line_bottom
            // 
            this.draw_line_bottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.draw_line_bottom.Font = new System.Drawing.Font("新細明體", 12F);
            this.draw_line_bottom.Location = new System.Drawing.Point(12, 673);
            this.draw_line_bottom.Name = "draw_line_bottom";
            this.draw_line_bottom.Size = new System.Drawing.Size(153, 34);
            this.draw_line_bottom.TabIndex = 1;
            this.draw_line_bottom.Text = "draw line";
            this.draw_line_bottom.UseVisualStyleBackColor = false;
            this.draw_line_bottom.Click += new System.EventHandler(this.draw_line_bottom_Click);
            // 
            // clear_bottom
            // 
            this.clear_bottom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clear_bottom.Font = new System.Drawing.Font("新細明體", 12F);
            this.clear_bottom.Location = new System.Drawing.Point(178, 731);
            this.clear_bottom.Name = "clear_bottom";
            this.clear_bottom.Size = new System.Drawing.Size(153, 34);
            this.clear_bottom.TabIndex = 2;
            this.clear_bottom.Text = "clear";
            this.clear_bottom.UseVisualStyleBackColor = false;
            this.clear_bottom.Click += new System.EventHandler(this.button3_Click);
            // 
            // x_position
            // 
            this.x_position.Location = new System.Drawing.Point(225, 612);
            this.x_position.Name = "x_position";
            this.x_position.Size = new System.Drawing.Size(30, 25);
            this.x_position.TabIndex = 3;
            // 
            // y_position
            // 
            this.y_position.Location = new System.Drawing.Point(331, 612);
            this.y_position.Name = "y_position";
            this.y_position.Size = new System.Drawing.Size(30, 25);
            this.y_position.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(192, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(297, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // circle1_text
            // 
            this.circle1_text.Location = new System.Drawing.Point(348, 683);
            this.circle1_text.Name = "circle1_text";
            this.circle1_text.Size = new System.Drawing.Size(30, 25);
            this.circle1_text.TabIndex = 7;
            // 
            // circle2_text
            // 
            this.circle2_text.Location = new System.Drawing.Point(243, 681);
            this.circle2_text.Name = "circle2_text";
            this.circle2_text.Size = new System.Drawing.Size(30, 25);
            this.circle2_text.TabIndex = 8;
            // 
            // weight_text
            // 
            this.weight_text.Location = new System.Drawing.Point(464, 683);
            this.weight_text.Name = "weight_text";
            this.weight_text.Size = new System.Drawing.Size(30, 25);
            this.weight_text.TabIndex = 11;
            this.weight_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(174, 687);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "point1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(279, 688);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "point2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(384, 688);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "weight:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(12, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Find MST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1512, 777);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight_text);
            this.Controls.Add(this.circle2_text);
            this.Controls.Add(this.circle1_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y_position);
            this.Controls.Add(this.x_position);
            this.Controls.Add(this.clear_bottom);
            this.Controls.Add(this.draw_line_bottom);
            this.Controls.Add(this.draw_circle_bottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw_circle_bottom;
        private System.Windows.Forms.Button draw_line_bottom;
        private System.Windows.Forms.Button clear_bottom;
        private System.Windows.Forms.TextBox x_position;
        private System.Windows.Forms.TextBox y_position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox circle1_text;
        private System.Windows.Forms.TextBox circle2_text;
        private System.Windows.Forms.TextBox weight_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

