namespace Hotel_Manager
{
    partial class FoodMenu
    {
       private System.ComponentModel.IContainer components = null;
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
            this.foodPanel = new MetroFramework.Controls.MetroPanel();
            this.dinnerQTY = new MetroFramework.Controls.MetroTextBox();
            this.lunchQTY = new MetroFramework.Controls.MetroTextBox();
            this.breakfastQTY = new MetroFramework.Controls.MetroTextBox();
            this.dinnerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.lunchCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.breakfastCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.needPanel = new MetroFramework.Controls.MetroPanel();
            this.surpriseCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.towelsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.cleaningCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nextButton = new MetroFramework.Controls.MetroButton();
            this.foodPanel.SuspendLayout();
            this.needPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodPanel
            // 
            this.foodPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.foodPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.foodPanel.Controls.Add(this.dinnerQTY);
            this.foodPanel.Controls.Add(this.lunchQTY);
            this.foodPanel.Controls.Add(this.breakfastQTY);
            this.foodPanel.Controls.Add(this.dinnerCheckBox);
            this.foodPanel.Controls.Add(this.lunchCheckBox);
            this.foodPanel.Controls.Add(this.breakfastCheckBox);
            this.foodPanel.Controls.Add(this.metroLabel1);
            this.foodPanel.HorizontalScrollbarBarColor = true;
            this.foodPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.foodPanel.HorizontalScrollbarSize = 12;
            this.foodPanel.Location = new System.Drawing.Point(19, 78);
            this.foodPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(443, 452);
            this.foodPanel.TabIndex = 5;
            this.foodPanel.UseCustomBackColor = true;
            this.foodPanel.UseCustomForeColor = true;
            this.foodPanel.UseStyleColors = true;
            this.foodPanel.VerticalScrollbarBarColor = true;
            this.foodPanel.VerticalScrollbarHighlightOnWheel = false;
            this.foodPanel.VerticalScrollbarSize = 13;
            // 
            // dinnerQTY
            // 
            this.dinnerQTY.BackColor = System.Drawing.Color.White;
            this.dinnerQTY.Enabled = false;
            this.dinnerQTY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.dinnerQTY.Lines = new string[0];
            this.dinnerQTY.Location = new System.Drawing.Point(19, 402);
            this.dinnerQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dinnerQTY.MaxLength = 32767;
            this.dinnerQTY.Name = "dinnerQTY";
            this.dinnerQTY.PasswordChar = '\0';
            this.dinnerQTY.PromptText = "Quantity ?";
            this.dinnerQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dinnerQTY.SelectedText = "";
            this.dinnerQTY.Size = new System.Drawing.Size(172, 36);
            this.dinnerQTY.Style = MetroFramework.MetroColorStyle.White;
            this.dinnerQTY.TabIndex = 40;
            this.dinnerQTY.UseCustomBackColor = true;
            this.dinnerQTY.UseSelectable = true;
            // 
            // lunchQTY
            // 
            this.lunchQTY.BackColor = System.Drawing.Color.White;
            this.lunchQTY.Enabled = false;
            this.lunchQTY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lunchQTY.Lines = new string[0];
            this.lunchQTY.Location = new System.Drawing.Point(229, 223);
            this.lunchQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lunchQTY.MaxLength = 32767;
            this.lunchQTY.Name = "lunchQTY";
            this.lunchQTY.PasswordChar = '\0';
            this.lunchQTY.PromptText = "Quantity ?";
            this.lunchQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lunchQTY.SelectedText = "";
            this.lunchQTY.Size = new System.Drawing.Size(192, 36);
            this.lunchQTY.Style = MetroFramework.MetroColorStyle.White;
            this.lunchQTY.TabIndex = 39;
            this.lunchQTY.UseCustomBackColor = true;
            this.lunchQTY.UseSelectable = true;
            // 
            // breakfastQTY
            // 
            this.breakfastQTY.BackColor = System.Drawing.Color.White;
            this.breakfastQTY.Enabled = false;
            this.breakfastQTY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.breakfastQTY.Lines = new string[0];
            this.breakfastQTY.Location = new System.Drawing.Point(19, 223);
            this.breakfastQTY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakfastQTY.MaxLength = 32767;
            this.breakfastQTY.Name = "breakfastQTY";
            this.breakfastQTY.PasswordChar = '\0';
            this.breakfastQTY.PromptText = "Quantity ?";
            this.breakfastQTY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.breakfastQTY.SelectedText = "";
            this.breakfastQTY.Size = new System.Drawing.Size(172, 36);
            this.breakfastQTY.Style = MetroFramework.MetroColorStyle.White;
            this.breakfastQTY.TabIndex = 38;
            this.breakfastQTY.UseCustomBackColor = true;
            this.breakfastQTY.UseSelectable = true;
            // 
            // dinnerCheckBox
            // 
            this.dinnerCheckBox.AutoSize = true;
            this.dinnerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.dinnerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.dinnerCheckBox.Location = new System.Drawing.Point(19, 378);
            this.dinnerCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dinnerCheckBox.Name = "dinnerCheckBox";
            this.dinnerCheckBox.Size = new System.Drawing.Size(115, 20);
            this.dinnerCheckBox.TabIndex = 5;
            this.dinnerCheckBox.Text = "Dinner   ($15)";
            this.dinnerCheckBox.UseCustomBackColor = true;
            this.dinnerCheckBox.UseSelectable = true;
            this.dinnerCheckBox.CheckedChanged += new System.EventHandler(this.dinnerCheckBox_CheckedChanged);
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.lunchCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.lunchCheckBox.Location = new System.Drawing.Point(229, 192);
            this.lunchCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(109, 20);
            this.lunchCheckBox.TabIndex = 4;
            this.lunchCheckBox.Text = "Lunch   ($15)";
            this.lunchCheckBox.UseCustomBackColor = true;
            this.lunchCheckBox.UseSelectable = true;
            this.lunchCheckBox.CheckedChanged += new System.EventHandler(this.lunchCheckBox_CheckedChanged);
            // 
            // breakfastCheckBox
            // 
            this.breakfastCheckBox.AutoSize = true;
            this.breakfastCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.breakfastCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.breakfastCheckBox.Location = new System.Drawing.Point(19, 192);
            this.breakfastCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakfastCheckBox.Name = "breakfastCheckBox";
            this.breakfastCheckBox.Size = new System.Drawing.Size(125, 20);
            this.breakfastCheckBox.TabIndex = 3;
            this.breakfastCheckBox.Text = "Break Fast  ($7)";
            this.breakfastCheckBox.UseCustomBackColor = true;
            this.breakfastCheckBox.UseSelectable = true;
            this.breakfastCheckBox.CheckedChanged += new System.EventHandler(this.breakfastCheckBox_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(4, 12);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(231, 34);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Selection de Repas :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // needPanel
            // 
            this.needPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.needPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.needPanel.Controls.Add(this.surpriseCheckBox);
            this.needPanel.Controls.Add(this.towelsCheckBox);
            this.needPanel.Controls.Add(this.cleaningCheckBox);
            this.needPanel.Controls.Add(this.metroLabel2);
            this.needPanel.HorizontalScrollbarBarColor = true;
            this.needPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.needPanel.HorizontalScrollbarSize = 12;
            this.needPanel.Location = new System.Drawing.Point(473, 78);
            this.needPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.needPanel.Name = "needPanel";
            this.needPanel.Size = new System.Drawing.Size(219, 401);
            this.needPanel.TabIndex = 6;
            this.needPanel.UseCustomBackColor = true;
            this.needPanel.UseCustomForeColor = true;
            this.needPanel.UseStyleColors = true;
            this.needPanel.VerticalScrollbarBarColor = true;
            this.needPanel.VerticalScrollbarHighlightOnWheel = false;
            this.needPanel.VerticalScrollbarSize = 13;
            // 
            // surpriseCheckBox
            // 
            this.surpriseCheckBox.AutoSize = true;
            this.surpriseCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.surpriseCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.surpriseCheckBox.Location = new System.Drawing.Point(24, 158);
            this.surpriseCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surpriseCheckBox.Name = "surpriseCheckBox";
            this.surpriseCheckBox.Size = new System.Drawing.Size(139, 20);
            this.surpriseCheckBox.TabIndex = 44;
            this.surpriseCheckBox.Text = "Sweetest surprise";
            this.surpriseCheckBox.UseCustomBackColor = true;
            this.surpriseCheckBox.UseSelectable = true;
            // 
            // towelsCheckBox
            // 
            this.towelsCheckBox.AutoSize = true;
            this.towelsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.towelsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.towelsCheckBox.Location = new System.Drawing.Point(24, 112);
            this.towelsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.towelsCheckBox.Name = "towelsCheckBox";
            this.towelsCheckBox.Size = new System.Drawing.Size(70, 20);
            this.towelsCheckBox.TabIndex = 42;
            this.towelsCheckBox.Text = "Towels";
            this.towelsCheckBox.UseCustomBackColor = true;
            this.towelsCheckBox.UseSelectable = true;
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.cleaningCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cleaningCheckBox.Location = new System.Drawing.Point(24, 68);
            this.cleaningCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(83, 20);
            this.cleaningCheckBox.TabIndex = 41;
            this.cleaningCheckBox.Text = "Cleaning";
            this.cleaningCheckBox.UseCustomBackColor = true;
            this.cleaningCheckBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(4, 12);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(161, 34);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Special needs";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(473, 487);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(219, 42);
            this.nextButton.TabIndex = 45;
            this.nextButton.Text = "Suivant";
            this.nextButton.UseSelectable = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 544);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.needPanel);
            this.Controls.Add(this.foodPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FoodMenu";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Text = "Menu Alimentaire :";
            this.Load += new System.EventHandler(this.FoodMenu_Load);
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            this.needPanel.ResumeLayout(false);
            this.needPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel foodPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox breakfastQTY;
        public MetroFramework.Controls.MetroTextBox dinnerQTY;
        public MetroFramework.Controls.MetroTextBox lunchQTY;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroCheckBox dinnerCheckBox;
        public MetroFramework.Controls.MetroCheckBox lunchCheckBox;
        public MetroFramework.Controls.MetroCheckBox breakfastCheckBox;
        public MetroFramework.Controls.MetroCheckBox surpriseCheckBox;
        public MetroFramework.Controls.MetroCheckBox towelsCheckBox;
        public MetroFramework.Controls.MetroCheckBox cleaningCheckBox;
        public MetroFramework.Controls.MetroPanel needPanel;
        public MetroFramework.Controls.MetroButton nextButton;
    }
}