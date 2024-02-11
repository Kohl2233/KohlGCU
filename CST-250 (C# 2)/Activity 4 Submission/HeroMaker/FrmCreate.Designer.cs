namespace HeroMaker
{
    partial class FrmCreate
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
            lblTrooperName = new Label();
            textTrooperName = new TextBox();
            gbServiceBranch = new GroupBox();
            cBoxNavy = new CheckBox();
            cBoxArmy = new CheckBox();
            listBoxTrooperType = new ListBox();
            gbTrooperType = new GroupBox();
            groupBox1 = new GroupBox();
            hScrollBarSanity = new HScrollBar();
            lblSanity = new Label();
            hScrollBarStamina = new HScrollBar();
            lblStamina = new Label();
            hScrollBarAccuracy = new HScrollBar();
            lblAccuracy = new Label();
            gbDeployments = new GroupBox();
            radBtnMandalore = new RadioButton();
            radBtnGeonosis = new RadioButton();
            radBtnCorellia = new RadioButton();
            radBtnDantooine = new RadioButton();
            radBtnKashyyyk = new RadioButton();
            radBtnNaboo = new RadioButton();
            radBtnHoth = new RadioButton();
            radBtnTatooine = new RadioButton();
            radBtnKamino = new RadioButton();
            radBtnCoruscant = new RadioButton();
            groupBox2 = new GroupBox();
            dtPickerCombat = new DateTimePicker();
            lblDateFirstCombat = new Label();
            lblDateOfEnlistment = new Label();
            dtPickerEnlistment = new DateTimePicker();
            lblYearsService = new Label();
            numUpDownService = new NumericUpDown();
            trackBarDarkSide = new TrackBar();
            lblDarkSideCorruption = new Label();
            lblDarkSideCorVal = new Label();
            btnCreateTrooper = new Button();
            lblArmorColor = new Label();
            colorDialog = new ColorDialog();
            picBoxArmorColor = new PictureBox();
            gbServiceBranch.SuspendLayout();
            gbTrooperType.SuspendLayout();
            groupBox1.SuspendLayout();
            gbDeployments.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownService).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDarkSide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxArmorColor).BeginInit();
            SuspendLayout();
            // 
            // lblTrooperName
            // 
            lblTrooperName.AutoSize = true;
            lblTrooperName.ForeColor = SystemColors.ControlText;
            lblTrooperName.Location = new Point(12, 9);
            lblTrooperName.Name = "lblTrooperName";
            lblTrooperName.Size = new Size(100, 14);
            lblTrooperName.TabIndex = 0;
            lblTrooperName.Text = "Trooper Name:";
            // 
            // textTrooperName
            // 
            textTrooperName.Location = new Point(113, 6);
            textTrooperName.Name = "textTrooperName";
            textTrooperName.Size = new Size(145, 22);
            textTrooperName.TabIndex = 1;
            textTrooperName.WordWrap = false;
            // 
            // gbServiceBranch
            // 
            gbServiceBranch.Controls.Add(cBoxNavy);
            gbServiceBranch.Controls.Add(cBoxArmy);
            gbServiceBranch.Location = new Point(12, 34);
            gbServiceBranch.Name = "gbServiceBranch";
            gbServiceBranch.Size = new Size(246, 52);
            gbServiceBranch.TabIndex = 2;
            gbServiceBranch.TabStop = false;
            gbServiceBranch.Text = "Service Branch";
            // 
            // cBoxNavy
            // 
            cBoxNavy.AutoSize = true;
            cBoxNavy.Location = new Point(128, 21);
            cBoxNavy.Name = "cBoxNavy";
            cBoxNavy.Size = new Size(112, 18);
            cBoxNavy.TabIndex = 1;
            cBoxNavy.Text = "Imperial Navy";
            cBoxNavy.UseVisualStyleBackColor = true;
            cBoxNavy.Click += ServiceBranchCheck_ClickEventHandler;
            // 
            // cBoxArmy
            // 
            cBoxArmy.AutoSize = true;
            cBoxArmy.Location = new Point(8, 21);
            cBoxArmy.Name = "cBoxArmy";
            cBoxArmy.Size = new Size(112, 18);
            cBoxArmy.TabIndex = 0;
            cBoxArmy.Text = "Imperial Army";
            cBoxArmy.UseVisualStyleBackColor = true;
            cBoxArmy.Click += ServiceBranchCheck_ClickEventHandler;
            // 
            // listBoxTrooperType
            // 
            listBoxTrooperType.FormattingEnabled = true;
            listBoxTrooperType.ItemHeight = 14;
            listBoxTrooperType.Items.AddRange(new object[] { "Imperial Stormtrooper", "Snowtrooper", "Sith Trooper", "Cave Trooper", "Coastal Defender Stormtrooper", "Crimson Stormtrooper", "Death Trooper", "Sandtrooper", "Incinerator Trooper", "Jumptrooper", "Shock Trooper", "Mortar Stormtrooper", "Scout Trooper", "Range Trooper", "Shadow Trooper", "Imperial Army Trooper", "Night Trooper", "Purge Trooper", "Imperial Armored Commando", "Dark Trooper" });
            listBoxTrooperType.Location = new Point(6, 24);
            listBoxTrooperType.Name = "listBoxTrooperType";
            listBoxTrooperType.Size = new Size(234, 200);
            listBoxTrooperType.TabIndex = 3;
            listBoxTrooperType.Click += ListBoxTrooperType_ClickEventHandler;
            // 
            // gbTrooperType
            // 
            gbTrooperType.Controls.Add(listBoxTrooperType);
            gbTrooperType.Location = new Point(12, 92);
            gbTrooperType.Name = "gbTrooperType";
            gbTrooperType.Size = new Size(246, 233);
            gbTrooperType.TabIndex = 4;
            gbTrooperType.TabStop = false;
            gbTrooperType.Text = "Trooper Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hScrollBarSanity);
            groupBox1.Controls.Add(lblSanity);
            groupBox1.Controls.Add(hScrollBarStamina);
            groupBox1.Controls.Add(lblStamina);
            groupBox1.Controls.Add(hScrollBarAccuracy);
            groupBox1.Controls.Add(lblAccuracy);
            groupBox1.Location = new Point(264, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 154);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trooper Stats";
            // 
            // hScrollBarSanity
            // 
            hScrollBarSanity.Location = new Point(11, 124);
            hScrollBarSanity.Name = "hScrollBarSanity";
            hScrollBarSanity.Size = new Size(193, 17);
            hScrollBarSanity.TabIndex = 11;
            hScrollBarSanity.Value = 34;
            hScrollBarSanity.Scroll += HScrollSanity_ScrollEventHandler;
            // 
            // lblSanity
            // 
            lblSanity.AutoSize = true;
            lblSanity.Location = new Point(11, 107);
            lblSanity.Name = "lblSanity";
            lblSanity.Size = new Size(46, 14);
            lblSanity.TabIndex = 10;
            lblSanity.Text = "Sanity";
            // 
            // hScrollBarStamina
            // 
            hScrollBarStamina.Location = new Point(11, 80);
            hScrollBarStamina.Name = "hScrollBarStamina";
            hScrollBarStamina.Size = new Size(193, 17);
            hScrollBarStamina.TabIndex = 9;
            hScrollBarStamina.Value = 33;
            hScrollBarStamina.Scroll += HScrollStamina_ScrollEventHandler;
            // 
            // lblStamina
            // 
            lblStamina.AutoSize = true;
            lblStamina.Location = new Point(11, 62);
            lblStamina.Name = "lblStamina";
            lblStamina.Size = new Size(58, 14);
            lblStamina.TabIndex = 8;
            lblStamina.Text = "Stamina";
            // 
            // hScrollBarAccuracy
            // 
            hScrollBarAccuracy.Location = new Point(11, 35);
            hScrollBarAccuracy.Name = "hScrollBarAccuracy";
            hScrollBarAccuracy.Size = new Size(193, 17);
            hScrollBarAccuracy.TabIndex = 7;
            hScrollBarAccuracy.Value = 33;
            hScrollBarAccuracy.Scroll += hScrollAccuracy_ScrollEventHandler;
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Location = new Point(11, 18);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(61, 14);
            lblAccuracy.TabIndex = 7;
            lblAccuracy.Text = "Accuracy";
            // 
            // gbDeployments
            // 
            gbDeployments.Controls.Add(radBtnMandalore);
            gbDeployments.Controls.Add(radBtnGeonosis);
            gbDeployments.Controls.Add(radBtnCorellia);
            gbDeployments.Controls.Add(radBtnDantooine);
            gbDeployments.Controls.Add(radBtnKashyyyk);
            gbDeployments.Controls.Add(radBtnNaboo);
            gbDeployments.Controls.Add(radBtnHoth);
            gbDeployments.Controls.Add(radBtnTatooine);
            gbDeployments.Controls.Add(radBtnKamino);
            gbDeployments.Controls.Add(radBtnCoruscant);
            gbDeployments.Location = new Point(264, 166);
            gbDeployments.Name = "gbDeployments";
            gbDeployments.Size = new Size(215, 159);
            gbDeployments.TabIndex = 7;
            gbDeployments.TabStop = false;
            gbDeployments.Text = "Deployments";
            // 
            // radBtnMandalore
            // 
            radBtnMandalore.AutoSize = true;
            radBtnMandalore.Location = new Point(101, 117);
            radBtnMandalore.Name = "radBtnMandalore";
            radBtnMandalore.Size = new Size(91, 18);
            radBtnMandalore.TabIndex = 9;
            radBtnMandalore.TabStop = true;
            radBtnMandalore.Text = "Mandalore";
            radBtnMandalore.UseVisualStyleBackColor = true;
            radBtnMandalore.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnGeonosis
            // 
            radBtnGeonosis.AutoSize = true;
            radBtnGeonosis.Location = new Point(101, 93);
            radBtnGeonosis.Name = "radBtnGeonosis";
            radBtnGeonosis.Size = new Size(83, 18);
            radBtnGeonosis.TabIndex = 8;
            radBtnGeonosis.TabStop = true;
            radBtnGeonosis.Text = "Geonosis";
            radBtnGeonosis.UseVisualStyleBackColor = true;
            radBtnGeonosis.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnCorellia
            // 
            radBtnCorellia.AutoSize = true;
            radBtnCorellia.Location = new Point(101, 69);
            radBtnCorellia.Name = "radBtnCorellia";
            radBtnCorellia.Size = new Size(72, 18);
            radBtnCorellia.TabIndex = 7;
            radBtnCorellia.TabStop = true;
            radBtnCorellia.Text = "Corellia";
            radBtnCorellia.UseVisualStyleBackColor = true;
            radBtnCorellia.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnDantooine
            // 
            radBtnDantooine.AutoSize = true;
            radBtnDantooine.Location = new Point(101, 45);
            radBtnDantooine.Name = "radBtnDantooine";
            radBtnDantooine.Size = new Size(90, 18);
            radBtnDantooine.TabIndex = 6;
            radBtnDantooine.TabStop = true;
            radBtnDantooine.Text = "Dantooine";
            radBtnDantooine.UseVisualStyleBackColor = true;
            radBtnDantooine.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnKashyyyk
            // 
            radBtnKashyyyk.AutoSize = true;
            radBtnKashyyyk.Location = new Point(101, 21);
            radBtnKashyyyk.Name = "radBtnKashyyyk";
            radBtnKashyyyk.Size = new Size(84, 18);
            radBtnKashyyyk.TabIndex = 5;
            radBtnKashyyyk.TabStop = true;
            radBtnKashyyyk.Text = "Kashyyyk";
            radBtnKashyyyk.UseVisualStyleBackColor = true;
            radBtnKashyyyk.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnNaboo
            // 
            radBtnNaboo.AutoSize = true;
            radBtnNaboo.Location = new Point(6, 117);
            radBtnNaboo.Name = "radBtnNaboo";
            radBtnNaboo.Size = new Size(66, 18);
            radBtnNaboo.TabIndex = 4;
            radBtnNaboo.TabStop = true;
            radBtnNaboo.Text = "Naboo";
            radBtnNaboo.UseVisualStyleBackColor = true;
            radBtnNaboo.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnHoth
            // 
            radBtnHoth.AutoSize = true;
            radBtnHoth.Location = new Point(6, 93);
            radBtnHoth.Name = "radBtnHoth";
            radBtnHoth.Size = new Size(55, 18);
            radBtnHoth.TabIndex = 3;
            radBtnHoth.TabStop = true;
            radBtnHoth.Text = "Hoth";
            radBtnHoth.UseVisualStyleBackColor = true;
            radBtnHoth.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnTatooine
            // 
            radBtnTatooine.AutoSize = true;
            radBtnTatooine.Location = new Point(6, 69);
            radBtnTatooine.Name = "radBtnTatooine";
            radBtnTatooine.Size = new Size(79, 18);
            radBtnTatooine.TabIndex = 2;
            radBtnTatooine.TabStop = true;
            radBtnTatooine.Text = "Tatooine";
            radBtnTatooine.UseVisualStyleBackColor = true;
            radBtnTatooine.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnKamino
            // 
            radBtnKamino.AutoSize = true;
            radBtnKamino.Location = new Point(6, 45);
            radBtnKamino.Name = "radBtnKamino";
            radBtnKamino.Size = new Size(71, 18);
            radBtnKamino.TabIndex = 1;
            radBtnKamino.TabStop = true;
            radBtnKamino.Text = "Kamino";
            radBtnKamino.UseVisualStyleBackColor = true;
            radBtnKamino.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // radBtnCoruscant
            // 
            radBtnCoruscant.AutoSize = true;
            radBtnCoruscant.Location = new Point(6, 21);
            radBtnCoruscant.Name = "radBtnCoruscant";
            radBtnCoruscant.Size = new Size(89, 18);
            radBtnCoruscant.TabIndex = 0;
            radBtnCoruscant.TabStop = true;
            radBtnCoruscant.Text = "Coruscant";
            radBtnCoruscant.UseVisualStyleBackColor = true;
            radBtnCoruscant.Click += RadioBtnDeployment_ClickEventHandler;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtPickerCombat);
            groupBox2.Controls.Add(lblDateFirstCombat);
            groupBox2.Controls.Add(lblDateOfEnlistment);
            groupBox2.Controls.Add(dtPickerEnlistment);
            groupBox2.Location = new Point(485, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(262, 121);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Significant Dates";
            // 
            // dtPickerCombat
            // 
            dtPickerCombat.Location = new Point(6, 85);
            dtPickerCombat.Name = "dtPickerCombat";
            dtPickerCombat.Size = new Size(250, 22);
            dtPickerCombat.TabIndex = 3;
            // 
            // lblDateFirstCombat
            // 
            lblDateFirstCombat.AutoSize = true;
            lblDateFirstCombat.Location = new Point(6, 65);
            lblDateFirstCombat.Name = "lblDateFirstCombat";
            lblDateFirstCombat.Size = new Size(137, 14);
            lblDateFirstCombat.TabIndex = 2;
            lblDateFirstCombat.Text = "Date of First Combat";
            // 
            // lblDateOfEnlistment
            // 
            lblDateOfEnlistment.AutoSize = true;
            lblDateOfEnlistment.Location = new Point(6, 18);
            lblDateOfEnlistment.Name = "lblDateOfEnlistment";
            lblDateOfEnlistment.Size = new Size(123, 14);
            lblDateOfEnlistment.TabIndex = 1;
            lblDateOfEnlistment.Text = "Date of Enlistment";
            // 
            // dtPickerEnlistment
            // 
            dtPickerEnlistment.Location = new Point(6, 35);
            dtPickerEnlistment.Name = "dtPickerEnlistment";
            dtPickerEnlistment.Size = new Size(250, 22);
            dtPickerEnlistment.TabIndex = 0;
            // 
            // lblYearsService
            // 
            lblYearsService.AutoSize = true;
            lblYearsService.Location = new Point(485, 146);
            lblYearsService.Name = "lblYearsService";
            lblYearsService.Size = new Size(106, 14);
            lblYearsService.TabIndex = 9;
            lblYearsService.Text = "Years of Service";
            // 
            // numUpDownService
            // 
            numUpDownService.Location = new Point(597, 138);
            numUpDownService.Name = "numUpDownService";
            numUpDownService.Size = new Size(150, 22);
            numUpDownService.TabIndex = 10;
            numUpDownService.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // trackBarDarkSide
            // 
            trackBarDarkSide.Location = new Point(491, 193);
            trackBarDarkSide.Name = "trackBarDarkSide";
            trackBarDarkSide.Size = new Size(256, 45);
            trackBarDarkSide.TabIndex = 11;
            trackBarDarkSide.Scroll += TrackBarDarkSideCorrupt_ScrollEventHandler;
            // 
            // lblDarkSideCorruption
            // 
            lblDarkSideCorruption.AutoSize = true;
            lblDarkSideCorruption.Location = new Point(485, 176);
            lblDarkSideCorruption.Name = "lblDarkSideCorruption";
            lblDarkSideCorruption.Size = new Size(138, 14);
            lblDarkSideCorruption.TabIndex = 12;
            lblDarkSideCorruption.Text = "Dark Side Corruption";
            // 
            // lblDarkSideCorVal
            // 
            lblDarkSideCorVal.Location = new Point(635, 176);
            lblDarkSideCorVal.Name = "lblDarkSideCorVal";
            lblDarkSideCorVal.Size = new Size(105, 15);
            lblDarkSideCorVal.TabIndex = 13;
            lblDarkSideCorVal.Text = "label1";
            lblDarkSideCorVal.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCreateTrooper
            // 
            btnCreateTrooper.Cursor = Cursors.Hand;
            btnCreateTrooper.Location = new Point(627, 331);
            btnCreateTrooper.Name = "btnCreateTrooper";
            btnCreateTrooper.Size = new Size(120, 39);
            btnCreateTrooper.TabIndex = 14;
            btnCreateTrooper.Text = "Create Trooper";
            btnCreateTrooper.UseVisualStyleBackColor = true;
            btnCreateTrooper.Click += BtnCreateTrooper_ClickEventHandler;
            // 
            // lblArmorColor
            // 
            lblArmorColor.AutoSize = true;
            lblArmorColor.Location = new Point(485, 235);
            lblArmorColor.Name = "lblArmorColor";
            lblArmorColor.Size = new Size(122, 14);
            lblArmorColor.TabIndex = 15;
            lblArmorColor.Text = "Armor Color Picker";
            // 
            // picBoxArmorColor
            // 
            picBoxArmorColor.BorderStyle = BorderStyle.FixedSingle;
            picBoxArmorColor.Location = new Point(485, 252);
            picBoxArmorColor.Name = "picBoxArmorColor";
            picBoxArmorColor.Size = new Size(262, 73);
            picBoxArmorColor.TabIndex = 16;
            picBoxArmorColor.TabStop = false;
            picBoxArmorColor.Click += PictureBoxArmorColor_ClickEventHandler;
            // 
            // FrmCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 382);
            Controls.Add(picBoxArmorColor);
            Controls.Add(lblArmorColor);
            Controls.Add(btnCreateTrooper);
            Controls.Add(lblDarkSideCorVal);
            Controls.Add(lblDarkSideCorruption);
            Controls.Add(trackBarDarkSide);
            Controls.Add(numUpDownService);
            Controls.Add(lblYearsService);
            Controls.Add(groupBox2);
            Controls.Add(gbDeployments);
            Controls.Add(groupBox1);
            Controls.Add(gbTrooperType);
            Controls.Add(gbServiceBranch);
            Controls.Add(textTrooperName);
            Controls.Add(lblTrooperName);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmCreate";
            Text = "Form1";
            gbServiceBranch.ResumeLayout(false);
            gbServiceBranch.PerformLayout();
            gbTrooperType.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbDeployments.ResumeLayout(false);
            gbDeployments.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownService).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDarkSide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxArmorColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrooperName;
        private TextBox textTrooperName;
        private GroupBox gbServiceBranch;
        private CheckBox cBoxNavy;
        private CheckBox cBoxArmy;
        private ListBox listBoxTrooperType;
        private GroupBox gbTrooperType;
        private GroupBox groupBox1;
        private Label lblAccuracy;
        private HScrollBar hScrollBarSanity;
        private Label lblSanity;
        private HScrollBar hScrollBarStamina;
        private Label lblStamina;
        private HScrollBar hScrollBarAccuracy;
        private GroupBox gbDeployments;
        private RadioButton radBtnMandalore;
        private RadioButton radBtnGeonosis;
        private RadioButton radBtnCorellia;
        private RadioButton radBtnDantooine;
        private RadioButton radBtnKashyyyk;
        private RadioButton radBtnNaboo;
        private RadioButton radBtnHoth;
        private RadioButton radBtnTatooine;
        private RadioButton radBtnKamino;
        private RadioButton radBtnCoruscant;
        private GroupBox groupBox2;
        private DateTimePicker dtPickerCombat;
        private Label lblDateFirstCombat;
        private Label lblDateOfEnlistment;
        private DateTimePicker dtPickerEnlistment;
        private Label lblYearsService;
        private NumericUpDown numUpDownService;
        private TrackBar trackBarDarkSide;
        private Label lblDarkSideCorruption;
        private Label lblDarkSideCorVal;
        private Button btnCreateTrooper;
        private Label lblArmorColor;
        private ColorDialog colorDialog;
        private PictureBox picBoxArmorColor;
    }
}