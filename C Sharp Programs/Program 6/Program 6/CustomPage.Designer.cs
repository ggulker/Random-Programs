namespace Program_6
{
    partial class CustomPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPage));
            this.SizeBox = new System.Windows.Forms.GroupBox();
            this.LargeRadButton = new System.Windows.Forms.RadioButton();
            this.MediumRadButton = new System.Windows.Forms.RadioButton();
            this.SmallRadButton = new System.Windows.Forms.RadioButton();
            this.PersRadButton = new System.Windows.Forms.RadioButton();
            this.SauceBox = new System.Windows.Forms.GroupBox();
            this.AlfredoRadButton = new System.Windows.Forms.RadioButton();
            this.TomatoRadButton = new System.Windows.Forms.RadioButton();
            this.Whole = new System.Windows.Forms.PictureBox();
            this.RightSide = new System.Windows.Forms.PictureBox();
            this.LeftSide = new System.Windows.Forms.PictureBox();
            this.CheeseBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MozzarellaBox = new System.Windows.Forms.CheckBox();
            this.ChedderBox = new System.Windows.Forms.CheckBox();
            this.ProvoloneBox = new System.Windows.Forms.CheckBox();
            this.MeatsBox = new System.Windows.Forms.GroupBox();
            this.BeefBox = new System.Windows.Forms.CheckBox();
            this.SausageBox = new System.Windows.Forms.CheckBox();
            this.HamBox = new System.Windows.Forms.CheckBox();
            this.BaconBox = new System.Windows.Forms.CheckBox();
            this.PepperoniBox = new System.Windows.Forms.CheckBox();
            this.VeggiBox = new System.Windows.Forms.GroupBox();
            this.SpinachBox = new System.Windows.Forms.CheckBox();
            this.OliveBox = new System.Windows.Forms.CheckBox();
            this.OnionBox = new System.Windows.Forms.CheckBox();
            this.MushroomBox = new System.Windows.Forms.CheckBox();
            this.JalapenoBox = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpecialtyBox = new System.Windows.Forms.ComboBox();
            this.SizeBox.SuspendLayout();
            this.SauceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Whole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSide)).BeginInit();
            this.CheeseBox.SuspendLayout();
            this.MeatsBox.SuspendLayout();
            this.VeggiBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SizeBox
            // 
            this.SizeBox.BackColor = System.Drawing.Color.Maroon;
            this.SizeBox.Controls.Add(this.LargeRadButton);
            this.SizeBox.Controls.Add(this.MediumRadButton);
            this.SizeBox.Controls.Add(this.SmallRadButton);
            this.SizeBox.Controls.Add(this.PersRadButton);
            this.SizeBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SizeBox.Location = new System.Drawing.Point(5, 12);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(135, 141);
            this.SizeBox.TabIndex = 0;
            this.SizeBox.TabStop = false;
            this.SizeBox.Text = "Size";
            // 
            // LargeRadButton
            // 
            this.LargeRadButton.AutoSize = true;
            this.LargeRadButton.Location = new System.Drawing.Point(7, 106);
            this.LargeRadButton.Name = "LargeRadButton";
            this.LargeRadButton.Size = new System.Drawing.Size(115, 28);
            this.LargeRadButton.TabIndex = 3;
            this.LargeRadButton.Text = "Large ($13)";
            this.LargeRadButton.UseVisualStyleBackColor = true;
            this.LargeRadButton.CheckedChanged += new System.EventHandler(this.SizeChanged);
            // 
            // MediumRadButton
            // 
            this.MediumRadButton.AutoSize = true;
            this.MediumRadButton.Location = new System.Drawing.Point(7, 78);
            this.MediumRadButton.Name = "MediumRadButton";
            this.MediumRadButton.Size = new System.Drawing.Size(132, 28);
            this.MediumRadButton.TabIndex = 2;
            this.MediumRadButton.Text = "Medium ($11)";
            this.MediumRadButton.UseVisualStyleBackColor = true;
            this.MediumRadButton.CheckedChanged += new System.EventHandler(this.SizeChanged);
            // 
            // SmallRadButton
            // 
            this.SmallRadButton.AutoSize = true;
            this.SmallRadButton.Location = new System.Drawing.Point(7, 50);
            this.SmallRadButton.Name = "SmallRadButton";
            this.SmallRadButton.Size = new System.Drawing.Size(105, 28);
            this.SmallRadButton.TabIndex = 1;
            this.SmallRadButton.Text = "Small ($7)";
            this.SmallRadButton.UseVisualStyleBackColor = true;
            this.SmallRadButton.CheckedChanged += new System.EventHandler(this.SizeChanged);
            // 
            // PersRadButton
            // 
            this.PersRadButton.AutoSize = true;
            this.PersRadButton.Checked = true;
            this.PersRadButton.Location = new System.Drawing.Point(7, 22);
            this.PersRadButton.Name = "PersRadButton";
            this.PersRadButton.Size = new System.Drawing.Size(125, 28);
            this.PersRadButton.TabIndex = 0;
            this.PersRadButton.TabStop = true;
            this.PersRadButton.Text = "Personal ($5)";
            this.PersRadButton.UseVisualStyleBackColor = true;
            this.PersRadButton.CheckedChanged += new System.EventHandler(this.SizeChanged);
            // 
            // SauceBox
            // 
            this.SauceBox.BackColor = System.Drawing.Color.Maroon;
            this.SauceBox.Controls.Add(this.AlfredoRadButton);
            this.SauceBox.Controls.Add(this.TomatoRadButton);
            this.SauceBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SauceBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SauceBox.Location = new System.Drawing.Point(5, 159);
            this.SauceBox.Name = "SauceBox";
            this.SauceBox.Size = new System.Drawing.Size(135, 85);
            this.SauceBox.TabIndex = 1;
            this.SauceBox.TabStop = false;
            this.SauceBox.Text = "Sauce";
            // 
            // AlfredoRadButton
            // 
            this.AlfredoRadButton.AutoSize = true;
            this.AlfredoRadButton.Location = new System.Drawing.Point(7, 50);
            this.AlfredoRadButton.Name = "AlfredoRadButton";
            this.AlfredoRadButton.Size = new System.Drawing.Size(82, 28);
            this.AlfredoRadButton.TabIndex = 1;
            this.AlfredoRadButton.Text = "Alfredo";
            this.AlfredoRadButton.UseVisualStyleBackColor = true;
            // 
            // TomatoRadButton
            // 
            this.TomatoRadButton.AutoSize = true;
            this.TomatoRadButton.Checked = true;
            this.TomatoRadButton.Location = new System.Drawing.Point(7, 22);
            this.TomatoRadButton.Name = "TomatoRadButton";
            this.TomatoRadButton.Size = new System.Drawing.Size(85, 28);
            this.TomatoRadButton.TabIndex = 0;
            this.TomatoRadButton.TabStop = true;
            this.TomatoRadButton.Text = "Tomato";
            this.TomatoRadButton.UseVisualStyleBackColor = true;
            // 
            // Whole
            // 
            this.Whole.BackColor = System.Drawing.SystemColors.Control;
            this.Whole.BackgroundImage = global::Program_6.Properties.Resources.WholePizzaChosen;
            this.Whole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Whole.Location = new System.Drawing.Point(367, 186);
            this.Whole.Name = "Whole";
            this.Whole.Size = new System.Drawing.Size(59, 59);
            this.Whole.TabIndex = 2;
            this.Whole.TabStop = false;
            this.Whole.WaitOnLoad = true;
            this.Whole.Click += new System.EventHandler(this.Whole_Click);
            // 
            // RightSide
            // 
            this.RightSide.BackgroundImage = global::Program_6.Properties.Resources.RightSideIcon;
            this.RightSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightSide.Location = new System.Drawing.Point(367, 267);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(59, 59);
            this.RightSide.TabIndex = 3;
            this.RightSide.TabStop = false;
            this.RightSide.Click += new System.EventHandler(this.RightSide_Click);
            // 
            // LeftSide
            // 
            this.LeftSide.BackgroundImage = global::Program_6.Properties.Resources.LeftSideIcon;
            this.LeftSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftSide.Location = new System.Drawing.Point(367, 114);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(59, 59);
            this.LeftSide.TabIndex = 4;
            this.LeftSide.TabStop = false;
            this.LeftSide.Click += new System.EventHandler(this.LeftHalf_Click);
            // 
            // CheeseBox
            // 
            this.CheeseBox.BackColor = System.Drawing.Color.Maroon;
            this.CheeseBox.Controls.Add(this.label1);
            this.CheeseBox.Controls.Add(this.MozzarellaBox);
            this.CheeseBox.Controls.Add(this.ChedderBox);
            this.CheeseBox.Controls.Add(this.ProvoloneBox);
            this.CheeseBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheeseBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CheeseBox.Location = new System.Drawing.Point(5, 253);
            this.CheeseBox.Name = "CheeseBox";
            this.CheeseBox.Size = new System.Drawing.Size(135, 128);
            this.CheeseBox.TabIndex = 6;
            this.CheeseBox.TabStop = false;
            this.CheeseBox.Text = "Cheese";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "+$1 per";
            // 
            // MozzarellaBox
            // 
            this.MozzarellaBox.AutoSize = true;
            this.MozzarellaBox.Location = new System.Drawing.Point(7, 98);
            this.MozzarellaBox.Name = "MozzarellaBox";
            this.MozzarellaBox.Size = new System.Drawing.Size(105, 28);
            this.MozzarellaBox.TabIndex = 2;
            this.MozzarellaBox.Text = "Mozzarella";
            this.MozzarellaBox.UseVisualStyleBackColor = true;
            this.MozzarellaBox.CheckedChanged += new System.EventHandler(this.MozzarellaCheck);
            // 
            // ChedderBox
            // 
            this.ChedderBox.AutoSize = true;
            this.ChedderBox.Location = new System.Drawing.Point(7, 72);
            this.ChedderBox.Name = "ChedderBox";
            this.ChedderBox.Size = new System.Drawing.Size(90, 28);
            this.ChedderBox.TabIndex = 1;
            this.ChedderBox.Text = "Chedder";
            this.ChedderBox.UseVisualStyleBackColor = true;
            this.ChedderBox.CheckedChanged += new System.EventHandler(this.ChedderCheck);
            // 
            // ProvoloneBox
            // 
            this.ProvoloneBox.AutoSize = true;
            this.ProvoloneBox.Location = new System.Drawing.Point(7, 45);
            this.ProvoloneBox.Name = "ProvoloneBox";
            this.ProvoloneBox.Size = new System.Drawing.Size(101, 28);
            this.ProvoloneBox.TabIndex = 0;
            this.ProvoloneBox.Text = "Provolone";
            this.ProvoloneBox.UseVisualStyleBackColor = true;
            this.ProvoloneBox.CheckedChanged += new System.EventHandler(this.ProvoloneCheck);
            // 
            // MeatsBox
            // 
            this.MeatsBox.BackColor = System.Drawing.Color.Maroon;
            this.MeatsBox.Controls.Add(this.BeefBox);
            this.MeatsBox.Controls.Add(this.SausageBox);
            this.MeatsBox.Controls.Add(this.HamBox);
            this.MeatsBox.Controls.Add(this.BaconBox);
            this.MeatsBox.Controls.Add(this.PepperoniBox);
            this.MeatsBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeatsBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MeatsBox.Location = new System.Drawing.Point(146, 11);
            this.MeatsBox.Name = "MeatsBox";
            this.MeatsBox.Size = new System.Drawing.Size(154, 176);
            this.MeatsBox.TabIndex = 7;
            this.MeatsBox.TabStop = false;
            this.MeatsBox.Text = "Meats";
            // 
            // BeefBox
            // 
            this.BeefBox.AutoSize = true;
            this.BeefBox.Location = new System.Drawing.Point(7, 134);
            this.BeefBox.Name = "BeefBox";
            this.BeefBox.Size = new System.Drawing.Size(104, 28);
            this.BeefBox.TabIndex = 4;
            this.BeefBox.Text = "Beef($.75)";
            this.BeefBox.UseVisualStyleBackColor = true;
            this.BeefBox.CheckedChanged += new System.EventHandler(this.BeefCheck);
            // 
            // SausageBox
            // 
            this.SausageBox.AutoSize = true;
            this.SausageBox.Location = new System.Drawing.Point(7, 106);
            this.SausageBox.Name = "SausageBox";
            this.SausageBox.Size = new System.Drawing.Size(130, 28);
            this.SausageBox.TabIndex = 3;
            this.SausageBox.Text = "Sausage($.75)";
            this.SausageBox.UseVisualStyleBackColor = true;
            this.SausageBox.CheckedChanged += new System.EventHandler(this.SausageCheck);
            // 
            // HamBox
            // 
            this.HamBox.AutoSize = true;
            this.HamBox.Location = new System.Drawing.Point(7, 78);
            this.HamBox.Name = "HamBox";
            this.HamBox.Size = new System.Drawing.Size(98, 28);
            this.HamBox.TabIndex = 2;
            this.HamBox.Text = "Ham($.5)";
            this.HamBox.UseVisualStyleBackColor = true;
            this.HamBox.CheckedChanged += new System.EventHandler(this.HamCheck);
            // 
            // BaconBox
            // 
            this.BaconBox.AutoSize = true;
            this.BaconBox.Location = new System.Drawing.Point(7, 50);
            this.BaconBox.Name = "BaconBox";
            this.BaconBox.Size = new System.Drawing.Size(107, 28);
            this.BaconBox.TabIndex = 1;
            this.BaconBox.Text = "Bacon($.8)";
            this.BaconBox.UseVisualStyleBackColor = true;
            this.BaconBox.CheckedChanged += new System.EventHandler(this.BaconChecked);
            // 
            // PepperoniBox
            // 
            this.PepperoniBox.AutoSize = true;
            this.PepperoniBox.Location = new System.Drawing.Point(7, 22);
            this.PepperoniBox.Name = "PepperoniBox";
            this.PepperoniBox.Size = new System.Drawing.Size(135, 28);
            this.PepperoniBox.TabIndex = 0;
            this.PepperoniBox.Text = "Pepperoni($.5)";
            this.PepperoniBox.UseVisualStyleBackColor = true;
            this.PepperoniBox.CheckedChanged += new System.EventHandler(this.PepperoniCheck);
            // 
            // VeggiBox
            // 
            this.VeggiBox.BackColor = System.Drawing.Color.Maroon;
            this.VeggiBox.Controls.Add(this.SpinachBox);
            this.VeggiBox.Controls.Add(this.OliveBox);
            this.VeggiBox.Controls.Add(this.OnionBox);
            this.VeggiBox.Controls.Add(this.MushroomBox);
            this.VeggiBox.Controls.Add(this.JalapenoBox);
            this.VeggiBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeggiBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VeggiBox.Location = new System.Drawing.Point(146, 193);
            this.VeggiBox.Name = "VeggiBox";
            this.VeggiBox.Size = new System.Drawing.Size(154, 188);
            this.VeggiBox.TabIndex = 8;
            this.VeggiBox.TabStop = false;
            this.VeggiBox.Text = "Veggies";
            // 
            // SpinachBox
            // 
            this.SpinachBox.AutoSize = true;
            this.SpinachBox.Location = new System.Drawing.Point(6, 132);
            this.SpinachBox.Name = "SpinachBox";
            this.SpinachBox.Size = new System.Drawing.Size(120, 28);
            this.SpinachBox.TabIndex = 4;
            this.SpinachBox.Text = "Spinach($.9)";
            this.SpinachBox.UseVisualStyleBackColor = true;
            this.SpinachBox.CheckedChanged += new System.EventHandler(this.SpinachCheck);
            // 
            // OliveBox
            // 
            this.OliveBox.AutoSize = true;
            this.OliveBox.Location = new System.Drawing.Point(6, 105);
            this.OliveBox.Name = "OliveBox";
            this.OliveBox.Size = new System.Drawing.Size(95, 28);
            this.OliveBox.TabIndex = 3;
            this.OliveBox.Text = "Olive($1)";
            this.OliveBox.UseVisualStyleBackColor = true;
            this.OliveBox.CheckedChanged += new System.EventHandler(this.OliveCheck);
            // 
            // OnionBox
            // 
            this.OnionBox.AutoSize = true;
            this.OnionBox.Location = new System.Drawing.Point(6, 78);
            this.OnionBox.Name = "OnionBox";
            this.OnionBox.Size = new System.Drawing.Size(106, 28);
            this.OnionBox.TabIndex = 2;
            this.OnionBox.Text = "Onion($.5)";
            this.OnionBox.UseVisualStyleBackColor = true;
            this.OnionBox.CheckedChanged += new System.EventHandler(this.OnionCheck);
            // 
            // MushroomBox
            // 
            this.MushroomBox.AutoSize = true;
            this.MushroomBox.Location = new System.Drawing.Point(6, 51);
            this.MushroomBox.Name = "MushroomBox";
            this.MushroomBox.Size = new System.Drawing.Size(139, 28);
            this.MushroomBox.TabIndex = 1;
            this.MushroomBox.Text = "Mushroom($.6)";
            this.MushroomBox.UseVisualStyleBackColor = true;
            this.MushroomBox.CheckedChanged += new System.EventHandler(this.MushroomCheck);
            // 
            // JalapenoBox
            // 
            this.JalapenoBox.AutoSize = true;
            this.JalapenoBox.Location = new System.Drawing.Point(6, 24);
            this.JalapenoBox.Name = "JalapenoBox";
            this.JalapenoBox.Size = new System.Drawing.Size(126, 28);
            this.JalapenoBox.TabIndex = 0;
            this.JalapenoBox.Text = "Jalapeno($.9)";
            this.JalapenoBox.UseVisualStyleBackColor = true;
            this.JalapenoBox.CheckedChanged += new System.EventHandler(this.JalapenoCheck);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(350, 372);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(96, 29);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(350, 337);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(96, 29);
            this.FinishButton.TabIndex = 10;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Maroon;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalLabel.Location = new System.Drawing.Point(308, 9);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(108, 20);
            this.TotalLabel.TabIndex = 11;
            this.TotalLabel.Text = "Total: $5.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(309, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Specialty";
            // 
            // SpecialtyBox
            // 
            this.SpecialtyBox.FormattingEnabled = true;
            this.SpecialtyBox.Items.AddRange(new object[] {
            "Custom",
            "Meat Lover",
            "Veggie Lover",
            "Cheese Lover",
            "Caterina\'s Italian"});
            this.SpecialtyBox.Location = new System.Drawing.Point(313, 59);
            this.SpecialtyBox.Name = "SpecialtyBox";
            this.SpecialtyBox.Size = new System.Drawing.Size(132, 24);
            this.SpecialtyBox.TabIndex = 13;
            this.SpecialtyBox.Text = "Custom";
            this.SpecialtyBox.SelectedIndexChanged += new System.EventHandler(this.SpecialtyBox_SelectedIndexChanged);
            // 
            // CustomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program_6.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 405);
            this.Controls.Add(this.SpecialtyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.VeggiBox);
            this.Controls.Add(this.MeatsBox);
            this.Controls.Add(this.CheeseBox);
            this.Controls.Add(this.LeftSide);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.Whole);
            this.Controls.Add(this.SauceBox);
            this.Controls.Add(this.SizeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomPage";
            this.Text = "Pizza Maker";
            this.SizeBox.ResumeLayout(false);
            this.SizeBox.PerformLayout();
            this.SauceBox.ResumeLayout(false);
            this.SauceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Whole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSide)).EndInit();
            this.CheeseBox.ResumeLayout(false);
            this.CheeseBox.PerformLayout();
            this.MeatsBox.ResumeLayout(false);
            this.MeatsBox.PerformLayout();
            this.VeggiBox.ResumeLayout(false);
            this.VeggiBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SizeBox;
        private System.Windows.Forms.RadioButton LargeRadButton;
        private System.Windows.Forms.RadioButton MediumRadButton;
        private System.Windows.Forms.RadioButton SmallRadButton;
        private System.Windows.Forms.RadioButton PersRadButton;
        private System.Windows.Forms.GroupBox SauceBox;
        private System.Windows.Forms.RadioButton AlfredoRadButton;
        private System.Windows.Forms.RadioButton TomatoRadButton;
        private System.Windows.Forms.PictureBox RightSide;
        private System.Windows.Forms.PictureBox LeftSide;
        private System.Windows.Forms.PictureBox Whole;
        private System.Windows.Forms.GroupBox CheeseBox;
        private System.Windows.Forms.CheckBox MozzarellaBox;
        private System.Windows.Forms.CheckBox ChedderBox;
        private System.Windows.Forms.CheckBox ProvoloneBox;
        private System.Windows.Forms.GroupBox MeatsBox;
        private System.Windows.Forms.CheckBox BeefBox;
        private System.Windows.Forms.CheckBox SausageBox;
        private System.Windows.Forms.CheckBox HamBox;
        private System.Windows.Forms.CheckBox BaconBox;
        private System.Windows.Forms.CheckBox PepperoniBox;
        private System.Windows.Forms.GroupBox VeggiBox;
        private System.Windows.Forms.CheckBox SpinachBox;
        private System.Windows.Forms.CheckBox OliveBox;
        private System.Windows.Forms.CheckBox OnionBox;
        private System.Windows.Forms.CheckBox MushroomBox;
        private System.Windows.Forms.CheckBox JalapenoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpecialtyBox;
    }
}