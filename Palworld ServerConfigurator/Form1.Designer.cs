namespace Palworld_ServerConfigurator
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            EnableInvaderEnemy = new ComboBox();
            StartLocationSelectByMap = new ComboBox();
            AutoResetGuildNoOnlinePlayers = new ComboBox();
            label23 = new Label();
            ServerPlayerMaxNum = new TextBox();
            label16 = new Label();
            CoopPlayerMaxNum = new TextBox();
            label15 = new Label();
            label14 = new Label();
            GuildPlayerMaxNum = new TextBox();
            label13 = new Label();
            label1 = new Label();
            DayTimeSpeedRate = new TextBox();
            AutoResetGuildTimeNoOnlinePlayers = new TextBox();
            label2 = new Label();
            label12 = new Label();
            NightTimeSpeedRate = new TextBox();
            label4 = new Label();
            label11 = new Label();
            ExpRate = new TextBox();
            BaseCampWorkerMaxNum = new TextBox();
            label3 = new Label();
            label10 = new Label();
            BuildObjectDamageRate = new TextBox();
            CollectionObjectRespawnSpeedRate = new TextBox();
            label8 = new Label();
            label9 = new Label();
            BuildObjectDeteriorationRate = new TextBox();
            BaseCampMaxNUm = new TextBox();
            label7 = new Label();
            label5 = new Label();
            CollectionDropRate = new TextBox();
            EnemyDropItemRate = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            PublicIp = new TextBox();
            label21 = new Label();
            PublicPort = new TextBox();
            label22 = new Label();
            ServerPassword = new TextBox();
            label20 = new Label();
            AdminPassword = new TextBox();
            label19 = new Label();
            ServerDescription = new TextBox();
            label18 = new Label();
            ServerName = new TextBox();
            label17 = new Label();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            PalEggDefaultHatchingTime = new TextBox();
            label37 = new Label();
            PalAutoHpRegeneRateInSleep = new TextBox();
            label38 = new Label();
            PalAutoHPRegeneRate = new TextBox();
            label39 = new Label();
            PalStaminaDecreaceRate = new TextBox();
            label40 = new Label();
            PalStomachDecreaceRate = new TextBox();
            label41 = new Label();
            PalDamageRateDefense = new TextBox();
            label42 = new Label();
            PalDamageRateAttack = new TextBox();
            label43 = new Label();
            PalSpawnNumRate = new TextBox();
            label44 = new Label();
            PalCaptureRate = new TextBox();
            label45 = new Label();
            groupBox3 = new GroupBox();
            EnableAimAssistKeyboard = new ComboBox();
            EnableAimAssistPad = new ComboBox();
            EnableFriendlyFire = new ComboBox();
            EnablePlayerToPlayerDamage = new ComboBox();
            WorkSpeedRate = new TextBox();
            label34 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            PlayerAutoHpRegeneRateInSleep = new TextBox();
            label24 = new Label();
            PlayerAutoHPRegeneRate = new TextBox();
            label25 = new Label();
            PlayerStaminaDecreaceRate = new TextBox();
            label26 = new Label();
            PlayerStomachDecreaceRate = new TextBox();
            label27 = new Label();
            PlayerDamageRateDefense = new TextBox();
            label28 = new Label();
            PlayerDamageRateAttack = new TextBox();
            label29 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            label35 = new Label();
            label36 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(589, 908);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(581, 875);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Common Parameters";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(429, 177);
            button1.Name = "button1";
            button1.Size = new Size(125, 50);
            button1.TabIndex = 43;
            button1.Text = "Generate and save file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Palworld_Icon_PNG;
            pictureBox1.Location = new Point(429, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label35);
            groupBox2.Controls.Add(EnableInvaderEnemy);
            groupBox2.Controls.Add(StartLocationSelectByMap);
            groupBox2.Controls.Add(AutoResetGuildNoOnlinePlayers);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(ServerPlayerMaxNum);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(CoopPlayerMaxNum);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(GuildPlayerMaxNum);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(DayTimeSpeedRate);
            groupBox2.Controls.Add(AutoResetGuildTimeNoOnlinePlayers);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(NightTimeSpeedRate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(ExpRate);
            groupBox2.Controls.Add(BaseCampWorkerMaxNum);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(BuildObjectDamageRate);
            groupBox2.Controls.Add(CollectionObjectRespawnSpeedRate);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(BuildObjectDeteriorationRate);
            groupBox2.Controls.Add(BaseCampMaxNUm);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(CollectionDropRate);
            groupBox2.Controls.Add(EnemyDropItemRate);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Rockwell", 9F);
            groupBox2.Location = new Point(6, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 604);
            groupBox2.TabIndex = 41;
            groupBox2.TabStop = false;
            groupBox2.Text = "World";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // EnableInvaderEnemy
            // 
            EnableInvaderEnemy.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            EnableInvaderEnemy.ForeColor = Color.Purple;
            EnableInvaderEnemy.FormattingEnabled = true;
            EnableInvaderEnemy.Items.AddRange(new object[] { "False", "True" });
            EnableInvaderEnemy.Location = new Point(10, 561);
            EnableInvaderEnemy.Name = "EnableInvaderEnemy";
            EnableInvaderEnemy.Size = new Size(151, 26);
            EnableInvaderEnemy.TabIndex = 52;
            EnableInvaderEnemy.Text = "True";
            // 
            // StartLocationSelectByMap
            // 
            StartLocationSelectByMap.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            StartLocationSelectByMap.ForeColor = Color.Purple;
            StartLocationSelectByMap.FormattingEnabled = true;
            StartLocationSelectByMap.Items.AddRange(new object[] { "False", "True" });
            StartLocationSelectByMap.Location = new Point(271, 446);
            StartLocationSelectByMap.Name = "StartLocationSelectByMap";
            StartLocationSelectByMap.Size = new Size(151, 26);
            StartLocationSelectByMap.TabIndex = 51;
            StartLocationSelectByMap.Text = "False";
            // 
            // AutoResetGuildNoOnlinePlayers
            // 
            AutoResetGuildNoOnlinePlayers.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            AutoResetGuildNoOnlinePlayers.ForeColor = Color.Purple;
            AutoResetGuildNoOnlinePlayers.FormattingEnabled = true;
            AutoResetGuildNoOnlinePlayers.Items.AddRange(new object[] { "False", "True" });
            AutoResetGuildNoOnlinePlayers.Location = new Point(11, 382);
            AutoResetGuildNoOnlinePlayers.Name = "AutoResetGuildNoOnlinePlayers";
            AutoResetGuildNoOnlinePlayers.Size = new Size(151, 26);
            AutoResetGuildNoOnlinePlayers.TabIndex = 50;
            AutoResetGuildNoOnlinePlayers.Text = "False";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Blue;
            label23.Location = new Point(9, 541);
            label23.Name = "label23";
            label23.Size = new Size(160, 17);
            label23.TabIndex = 48;
            label23.Text = "EnableInvaderEnemy";
            // 
            // ServerPlayerMaxNum
            // 
            ServerPlayerMaxNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ServerPlayerMaxNum.ForeColor = Color.Purple;
            ServerPlayerMaxNum.Location = new Point(274, 504);
            ServerPlayerMaxNum.Name = "ServerPlayerMaxNum";
            ServerPlayerMaxNum.Size = new Size(144, 27);
            ServerPlayerMaxNum.TabIndex = 47;
            ServerPlayerMaxNum.Text = "32";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(271, 481);
            label16.Name = "label16";
            label16.Size = new Size(161, 17);
            label16.TabIndex = 46;
            label16.Text = "ServerPlayerMaxNum";
            // 
            // CoopPlayerMaxNum
            // 
            CoopPlayerMaxNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CoopPlayerMaxNum.ForeColor = Color.Purple;
            CoopPlayerMaxNum.Location = new Point(12, 504);
            CoopPlayerMaxNum.Name = "CoopPlayerMaxNum";
            CoopPlayerMaxNum.Size = new Size(144, 27);
            CoopPlayerMaxNum.TabIndex = 45;
            CoopPlayerMaxNum.Text = "4";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Blue;
            label15.Location = new Point(8, 481);
            label15.Name = "label15";
            label15.Size = new Size(153, 17);
            label15.TabIndex = 44;
            label15.Text = "CoopPlayerMaxNum";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Blue;
            label14.Location = new Point(267, 421);
            label14.Name = "label14";
            label14.Size = new Size(192, 17);
            label14.TabIndex = 42;
            label14.Text = "StartLocationSelectByMap";
            // 
            // GuildPlayerMaxNum
            // 
            GuildPlayerMaxNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GuildPlayerMaxNum.ForeColor = Color.Purple;
            GuildPlayerMaxNum.Location = new Point(12, 444);
            GuildPlayerMaxNum.Name = "GuildPlayerMaxNum";
            GuildPlayerMaxNum.Size = new Size(144, 27);
            GuildPlayerMaxNum.TabIndex = 41;
            GuildPlayerMaxNum.Text = "20";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(7, 421);
            label13.Name = "label13";
            label13.Size = new Size(155, 17);
            label13.TabIndex = 40;
            label13.Text = "GuildPlayerMaxNum";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 8;
            label1.Text = "DayTimeSpeedRate ";
            // 
            // DayTimeSpeedRate
            // 
            DayTimeSpeedRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DayTimeSpeedRate.ForeColor = Color.Purple;
            DayTimeSpeedRate.Location = new Point(11, 59);
            DayTimeSpeedRate.Name = "DayTimeSpeedRate";
            DayTimeSpeedRate.Size = new Size(144, 27);
            DayTimeSpeedRate.TabIndex = 9;
            DayTimeSpeedRate.Text = "1.000000";
            // 
            // AutoResetGuildTimeNoOnlinePlayers
            // 
            AutoResetGuildTimeNoOnlinePlayers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AutoResetGuildTimeNoOnlinePlayers.ForeColor = Color.Purple;
            AutoResetGuildTimeNoOnlinePlayers.Location = new Point(271, 382);
            AutoResetGuildTimeNoOnlinePlayers.Name = "AutoResetGuildTimeNoOnlinePlayers";
            AutoResetGuildTimeNoOnlinePlayers.Size = new Size(144, 27);
            AutoResetGuildTimeNoOnlinePlayers.TabIndex = 31;
            AutoResetGuildTimeNoOnlinePlayers.Text = "72.000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(264, 36);
            label2.Name = "label2";
            label2.Size = new Size(158, 17);
            label2.TabIndex = 10;
            label2.Text = "NightTimeSpeedRate";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(271, 359);
            label12.Name = "label12";
            label12.Size = new Size(277, 17);
            label12.TabIndex = 30;
            label12.Text = "AutoResetGuildTimeNoOnlinePlayers";
            label12.Click += label12_Click;
            // 
            // NightTimeSpeedRate
            // 
            NightTimeSpeedRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            NightTimeSpeedRate.ForeColor = Color.Purple;
            NightTimeSpeedRate.Location = new Point(267, 59);
            NightTimeSpeedRate.Name = "NightTimeSpeedRate";
            NightTimeSpeedRate.Size = new Size(144, 27);
            NightTimeSpeedRate.TabIndex = 11;
            NightTimeSpeedRate.Text = "1.000000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 12;
            label4.Text = "ExpRate";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(6, 359);
            label11.Name = "label11";
            label11.Size = new Size(241, 17);
            label11.TabIndex = 28;
            label11.Text = "AutoResetGuildNoOnlinePlayers";
            // 
            // ExpRate
            // 
            ExpRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ExpRate.ForeColor = Color.Purple;
            ExpRate.Location = new Point(11, 122);
            ExpRate.Name = "ExpRate";
            ExpRate.Size = new Size(144, 27);
            ExpRate.TabIndex = 13;
            ExpRate.Text = "1.000000";
            // 
            // BaseCampWorkerMaxNum
            // 
            BaseCampWorkerMaxNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BaseCampWorkerMaxNum.ForeColor = Color.Purple;
            BaseCampWorkerMaxNum.Location = new Point(271, 319);
            BaseCampWorkerMaxNum.Name = "BaseCampWorkerMaxNum";
            BaseCampWorkerMaxNum.Size = new Size(144, 27);
            BaseCampWorkerMaxNum.TabIndex = 27;
            BaseCampWorkerMaxNum.Text = "15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(263, 99);
            label3.Name = "label3";
            label3.Size = new Size(183, 17);
            label3.TabIndex = 14;
            label3.Text = "BuildObjectDamageRate";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(271, 296);
            label10.Name = "label10";
            label10.Size = new Size(198, 17);
            label10.TabIndex = 26;
            label10.Text = "BaseCampWorkerMaxNum";
            // 
            // BuildObjectDamageRate
            // 
            BuildObjectDamageRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuildObjectDamageRate.ForeColor = Color.Purple;
            BuildObjectDamageRate.Location = new Point(269, 122);
            BuildObjectDamageRate.Name = "BuildObjectDamageRate";
            BuildObjectDamageRate.Size = new Size(144, 27);
            BuildObjectDamageRate.TabIndex = 15;
            BuildObjectDamageRate.Text = "1.000000";
            // 
            // CollectionObjectRespawnSpeedRate
            // 
            CollectionObjectRespawnSpeedRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CollectionObjectRespawnSpeedRate.ForeColor = Color.Purple;
            CollectionObjectRespawnSpeedRate.Location = new Point(10, 319);
            CollectionObjectRespawnSpeedRate.Name = "CollectionObjectRespawnSpeedRate";
            CollectionObjectRespawnSpeedRate.Size = new Size(144, 27);
            CollectionObjectRespawnSpeedRate.TabIndex = 25;
            CollectionObjectRespawnSpeedRate.Text = "1.000000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(4, 162);
            label8.Name = "label8";
            label8.Size = new Size(221, 17);
            label8.TabIndex = 16;
            label8.Text = "BuildObjectDeteriorationRate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(4, 296);
            label9.Name = "label9";
            label9.Size = new Size(270, 17);
            label9.TabIndex = 24;
            label9.Text = "CollectionObjectRespawnSpeedRate";
            // 
            // BuildObjectDeteriorationRate
            // 
            BuildObjectDeteriorationRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BuildObjectDeteriorationRate.ForeColor = Color.Purple;
            BuildObjectDeteriorationRate.Location = new Point(9, 185);
            BuildObjectDeteriorationRate.Name = "BuildObjectDeteriorationRate";
            BuildObjectDeteriorationRate.Size = new Size(144, 27);
            BuildObjectDeteriorationRate.TabIndex = 17;
            BuildObjectDeteriorationRate.Text = "1.000000";
            // 
            // BaseCampMaxNUm
            // 
            BaseCampMaxNUm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BaseCampMaxNUm.ForeColor = Color.Purple;
            BaseCampMaxNUm.Location = new Point(271, 251);
            BaseCampMaxNUm.Name = "BaseCampMaxNUm";
            BaseCampMaxNUm.Size = new Size(144, 27);
            BaseCampMaxNUm.TabIndex = 23;
            BaseCampMaxNUm.Text = "128";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(269, 162);
            label7.Name = "label7";
            label7.Size = new Size(149, 17);
            label7.TabIndex = 18;
            label7.Text = "CollectionDropRate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(271, 228);
            label5.Name = "label5";
            label5.Size = new Size(144, 17);
            label5.TabIndex = 22;
            label5.Text = "BaseCampMaxNum";
            // 
            // CollectionDropRate
            // 
            CollectionDropRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CollectionDropRate.ForeColor = Color.Purple;
            CollectionDropRate.Location = new Point(271, 185);
            CollectionDropRate.Name = "CollectionDropRate";
            CollectionDropRate.Size = new Size(144, 27);
            CollectionDropRate.TabIndex = 19;
            CollectionDropRate.Text = "1.000000";
            // 
            // EnemyDropItemRate
            // 
            EnemyDropItemRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EnemyDropItemRate.ForeColor = Color.Purple;
            EnemyDropItemRate.Location = new Point(12, 251);
            EnemyDropItemRate.Name = "EnemyDropItemRate";
            EnemyDropItemRate.Size = new Size(144, 27);
            EnemyDropItemRate.TabIndex = 21;
            EnemyDropItemRate.Text = "1.000000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(6, 228);
            label6.Name = "label6";
            label6.Size = new Size(154, 17);
            label6.TabIndex = 20;
            label6.Text = "EnemyDropItemRate";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PublicIp);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(PublicPort);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(ServerPassword);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(AdminPassword);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(ServerDescription);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(ServerName);
            groupBox1.Controls.Add(label17);
            groupBox1.Font = new Font("Rockwell", 9F);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 235);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Server";
            // 
            // PublicIp
            // 
            PublicIp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PublicIp.ForeColor = Color.Purple;
            PublicIp.Location = new Point(194, 188);
            PublicIp.Name = "PublicIp";
            PublicIp.Size = new Size(144, 27);
            PublicIp.TabIndex = 51;
            PublicIp.Text = "127.0.0.1";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Blue;
            label21.Location = new Point(191, 165);
            label21.Name = "label21";
            label21.Size = new Size(68, 17);
            label21.TabIndex = 50;
            label21.Text = "PublicIP";
            // 
            // PublicPort
            // 
            PublicPort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PublicPort.ForeColor = Color.Purple;
            PublicPort.Location = new Point(9, 188);
            PublicPort.Name = "PublicPort";
            PublicPort.Size = new Size(144, 27);
            PublicPort.TabIndex = 49;
            PublicPort.Text = "8211";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Blue;
            label22.Location = new Point(6, 165);
            label22.Name = "label22";
            label22.Size = new Size(83, 17);
            label22.TabIndex = 48;
            label22.Text = "PublicPort";
            // 
            // ServerPassword
            // 
            ServerPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ServerPassword.ForeColor = Color.Purple;
            ServerPassword.Location = new Point(194, 124);
            ServerPassword.Name = "ServerPassword";
            ServerPassword.Size = new Size(144, 27);
            ServerPassword.TabIndex = 47;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Blue;
            label20.Location = new Point(191, 101);
            label20.Name = "label20";
            label20.Size = new Size(121, 17);
            label20.TabIndex = 46;
            label20.Text = "ServerPassword";
            // 
            // AdminPassword
            // 
            AdminPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdminPassword.ForeColor = Color.Purple;
            AdminPassword.Location = new Point(9, 124);
            AdminPassword.Name = "AdminPassword";
            AdminPassword.Size = new Size(144, 27);
            AdminPassword.TabIndex = 45;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Blue;
            label19.Location = new Point(6, 101);
            label19.Name = "label19";
            label19.Size = new Size(121, 17);
            label19.TabIndex = 44;
            label19.Text = "AdminPassword";
            // 
            // ServerDescription
            // 
            ServerDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ServerDescription.ForeColor = Color.Purple;
            ServerDescription.Location = new Point(194, 59);
            ServerDescription.Name = "ServerDescription";
            ServerDescription.Size = new Size(144, 27);
            ServerDescription.TabIndex = 43;
            ServerDescription.Text = "Test Server";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Blue;
            label18.Location = new Point(191, 36);
            label18.Name = "label18";
            label18.Size = new Size(137, 17);
            label18.TabIndex = 42;
            label18.Text = "ServerDescription";
            // 
            // ServerName
            // 
            ServerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ServerName.ForeColor = Color.Purple;
            ServerName.Location = new Point(9, 59);
            ServerName.Name = "ServerName";
            ServerName.Size = new Size(153, 27);
            ServerName.TabIndex = 41;
            ServerName.Text = "YOUR_SERVER_NAME";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Blue;
            label17.Location = new Point(6, 36);
            label17.Name = "label17";
            label17.Size = new Size(95, 17);
            label17.TabIndex = 40;
            label17.Text = "ServerName";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(581, 875);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Players / Pals Parameters";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label36);
            groupBox4.Controls.Add(PalEggDefaultHatchingTime);
            groupBox4.Controls.Add(label37);
            groupBox4.Controls.Add(PalAutoHpRegeneRateInSleep);
            groupBox4.Controls.Add(label38);
            groupBox4.Controls.Add(PalAutoHPRegeneRate);
            groupBox4.Controls.Add(label39);
            groupBox4.Controls.Add(PalStaminaDecreaceRate);
            groupBox4.Controls.Add(label40);
            groupBox4.Controls.Add(PalStomachDecreaceRate);
            groupBox4.Controls.Add(label41);
            groupBox4.Controls.Add(PalDamageRateDefense);
            groupBox4.Controls.Add(label42);
            groupBox4.Controls.Add(PalDamageRateAttack);
            groupBox4.Controls.Add(label43);
            groupBox4.Controls.Add(PalSpawnNumRate);
            groupBox4.Controls.Add(label44);
            groupBox4.Controls.Add(PalCaptureRate);
            groupBox4.Controls.Add(label45);
            groupBox4.Location = new Point(8, 431);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(567, 438);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pals";
            // 
            // PalEggDefaultHatchingTime
            // 
            PalEggDefaultHatchingTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalEggDefaultHatchingTime.ForeColor = Color.Purple;
            PalEggDefaultHatchingTime.Location = new Point(10, 320);
            PalEggDefaultHatchingTime.Name = "PalEggDefaultHatchingTime";
            PalEggDefaultHatchingTime.Size = new Size(144, 27);
            PalEggDefaultHatchingTime.TabIndex = 91;
            PalEggDefaultHatchingTime.Text = "72.000000";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.ForeColor = Color.Blue;
            label37.Location = new Point(7, 297);
            label37.Name = "label37";
            label37.Size = new Size(196, 20);
            label37.TabIndex = 90;
            label37.Text = "PalEggDefaultHatchingTime";
            // 
            // PalAutoHpRegeneRateInSleep
            // 
            PalAutoHpRegeneRateInSleep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalAutoHpRegeneRateInSleep.ForeColor = Color.Purple;
            PalAutoHpRegeneRateInSleep.Location = new Point(232, 256);
            PalAutoHpRegeneRateInSleep.Name = "PalAutoHpRegeneRateInSleep";
            PalAutoHpRegeneRateInSleep.Size = new Size(144, 27);
            PalAutoHpRegeneRateInSleep.TabIndex = 89;
            PalAutoHpRegeneRateInSleep.Text = "1.000000";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.ForeColor = Color.Blue;
            label38.Location = new Point(229, 233);
            label38.Name = "label38";
            label38.Size = new Size(209, 20);
            label38.TabIndex = 88;
            label38.Text = "PalAutoHpRegeneRateInSleep";
            // 
            // PalAutoHPRegeneRate
            // 
            PalAutoHPRegeneRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalAutoHPRegeneRate.ForeColor = Color.Purple;
            PalAutoHPRegeneRate.Location = new Point(10, 256);
            PalAutoHPRegeneRate.Name = "PalAutoHPRegeneRate";
            PalAutoHPRegeneRate.Size = new Size(144, 27);
            PalAutoHPRegeneRate.TabIndex = 87;
            PalAutoHPRegeneRate.Text = "1.000000";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.ForeColor = Color.Blue;
            label39.Location = new Point(7, 233);
            label39.Name = "label39";
            label39.Size = new Size(159, 20);
            label39.TabIndex = 86;
            label39.Text = "PalAutoHPRegeneRate";
            // 
            // PalStaminaDecreaceRate
            // 
            PalStaminaDecreaceRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalStaminaDecreaceRate.ForeColor = Color.Purple;
            PalStaminaDecreaceRate.Location = new Point(232, 191);
            PalStaminaDecreaceRate.Name = "PalStaminaDecreaceRate";
            PalStaminaDecreaceRate.Size = new Size(144, 27);
            PalStaminaDecreaceRate.TabIndex = 85;
            PalStaminaDecreaceRate.Text = "1.000000";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.ForeColor = Color.Blue;
            label40.Location = new Point(229, 168);
            label40.Name = "label40";
            label40.Size = new Size(174, 20);
            label40.TabIndex = 84;
            label40.Text = "PalStaminaDecreaceRate";
            // 
            // PalStomachDecreaceRate
            // 
            PalStomachDecreaceRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalStomachDecreaceRate.ForeColor = Color.Purple;
            PalStomachDecreaceRate.Location = new Point(10, 191);
            PalStomachDecreaceRate.Name = "PalStomachDecreaceRate";
            PalStomachDecreaceRate.Size = new Size(144, 27);
            PalStomachDecreaceRate.TabIndex = 83;
            PalStomachDecreaceRate.Text = "1.000000";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.ForeColor = Color.Blue;
            label41.Location = new Point(7, 168);
            label41.Name = "label41";
            label41.Size = new Size(178, 20);
            label41.TabIndex = 82;
            label41.Text = "PalStomachDecreaceRate";
            // 
            // PalDamageRateDefense
            // 
            PalDamageRateDefense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalDamageRateDefense.ForeColor = Color.Purple;
            PalDamageRateDefense.Location = new Point(232, 127);
            PalDamageRateDefense.Name = "PalDamageRateDefense";
            PalDamageRateDefense.Size = new Size(144, 27);
            PalDamageRateDefense.TabIndex = 81;
            PalDamageRateDefense.Text = "1.000000";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.ForeColor = Color.Blue;
            label42.Location = new Point(229, 104);
            label42.Name = "label42";
            label42.Size = new Size(169, 20);
            label42.TabIndex = 80;
            label42.Text = "PalDamageRateDefense";
            // 
            // PalDamageRateAttack
            // 
            PalDamageRateAttack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalDamageRateAttack.ForeColor = Color.Purple;
            PalDamageRateAttack.Location = new Point(10, 127);
            PalDamageRateAttack.Name = "PalDamageRateAttack";
            PalDamageRateAttack.Size = new Size(144, 27);
            PalDamageRateAttack.TabIndex = 79;
            PalDamageRateAttack.Text = "1.000000";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.ForeColor = Color.Blue;
            label43.Location = new Point(7, 104);
            label43.Name = "label43";
            label43.Size = new Size(157, 20);
            label43.TabIndex = 78;
            label43.Text = "PalDamageRateAttack";
            // 
            // PalSpawnNumRate
            // 
            PalSpawnNumRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalSpawnNumRate.ForeColor = Color.Purple;
            PalSpawnNumRate.Location = new Point(232, 62);
            PalSpawnNumRate.Name = "PalSpawnNumRate";
            PalSpawnNumRate.Size = new Size(144, 27);
            PalSpawnNumRate.TabIndex = 77;
            PalSpawnNumRate.Text = "1.000000";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.ForeColor = Color.Blue;
            label44.Location = new Point(229, 39);
            label44.Name = "label44";
            label44.Size = new Size(134, 20);
            label44.TabIndex = 76;
            label44.Text = "PalSpawnNumRate";
            // 
            // PalCaptureRate
            // 
            PalCaptureRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PalCaptureRate.ForeColor = Color.Purple;
            PalCaptureRate.Location = new Point(10, 62);
            PalCaptureRate.Name = "PalCaptureRate";
            PalCaptureRate.Size = new Size(153, 27);
            PalCaptureRate.TabIndex = 75;
            PalCaptureRate.Text = "1.000000";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.ForeColor = Color.Blue;
            label45.Location = new Point(7, 39);
            label45.Name = "label45";
            label45.Size = new Size(110, 20);
            label45.TabIndex = 74;
            label45.Text = "PalCaptureRate";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EnableAimAssistKeyboard);
            groupBox3.Controls.Add(EnableAimAssistPad);
            groupBox3.Controls.Add(EnableFriendlyFire);
            groupBox3.Controls.Add(EnablePlayerToPlayerDamage);
            groupBox3.Controls.Add(WorkSpeedRate);
            groupBox3.Controls.Add(label34);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(label32);
            groupBox3.Controls.Add(label33);
            groupBox3.Controls.Add(PlayerAutoHpRegeneRateInSleep);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(PlayerAutoHPRegeneRate);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(PlayerStaminaDecreaceRate);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(PlayerStomachDecreaceRate);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(PlayerDamageRateDefense);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(PlayerDamageRateAttack);
            groupBox3.Controls.Add(label29);
            groupBox3.Font = new Font("Rockwell", 9F);
            groupBox3.Location = new Point(6, 11);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(569, 414);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Players";
            // 
            // EnableAimAssistKeyboard
            // 
            EnableAimAssistKeyboard.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            EnableAimAssistKeyboard.ForeColor = Color.Purple;
            EnableAimAssistKeyboard.FormattingEnabled = true;
            EnableAimAssistKeyboard.Items.AddRange(new object[] { "False", "True" });
            EnableAimAssistKeyboard.Location = new Point(231, 315);
            EnableAimAssistKeyboard.Name = "EnableAimAssistKeyboard";
            EnableAimAssistKeyboard.Size = new Size(151, 26);
            EnableAimAssistKeyboard.TabIndex = 77;
            EnableAimAssistKeyboard.Text = "False";
            // 
            // EnableAimAssistPad
            // 
            EnableAimAssistPad.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            EnableAimAssistPad.ForeColor = Color.Purple;
            EnableAimAssistPad.FormattingEnabled = true;
            EnableAimAssistPad.Items.AddRange(new object[] { "False", "True" });
            EnableAimAssistPad.Location = new Point(9, 315);
            EnableAimAssistPad.Name = "EnableAimAssistPad";
            EnableAimAssistPad.Size = new Size(151, 26);
            EnableAimAssistPad.TabIndex = 76;
            EnableAimAssistPad.Text = "True";
            // 
            // EnableFriendlyFire
            // 
            EnableFriendlyFire.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            EnableFriendlyFire.ForeColor = Color.Purple;
            EnableFriendlyFire.FormattingEnabled = true;
            EnableFriendlyFire.Items.AddRange(new object[] { "False", "True" });
            EnableFriendlyFire.Location = new Point(231, 251);
            EnableFriendlyFire.Name = "EnableFriendlyFire";
            EnableFriendlyFire.Size = new Size(151, 26);
            EnableFriendlyFire.TabIndex = 75;
            EnableFriendlyFire.Text = "False";
            // 
            // EnablePlayerToPlayerDamage
            // 
            EnablePlayerToPlayerDamage.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            EnablePlayerToPlayerDamage.ForeColor = Color.Purple;
            EnablePlayerToPlayerDamage.FormattingEnabled = true;
            EnablePlayerToPlayerDamage.Items.AddRange(new object[] { "False", "True" });
            EnablePlayerToPlayerDamage.Location = new Point(9, 251);
            EnablePlayerToPlayerDamage.Name = "EnablePlayerToPlayerDamage";
            EnablePlayerToPlayerDamage.Size = new Size(151, 26);
            EnablePlayerToPlayerDamage.TabIndex = 74;
            EnablePlayerToPlayerDamage.Text = "False";
            // 
            // WorkSpeedRate
            // 
            WorkSpeedRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            WorkSpeedRate.ForeColor = Color.Purple;
            WorkSpeedRate.Location = new Point(12, 376);
            WorkSpeedRate.Name = "WorkSpeedRate";
            WorkSpeedRate.Size = new Size(144, 27);
            WorkSpeedRate.TabIndex = 73;
            WorkSpeedRate.Text = "1.000000";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.ForeColor = Color.Blue;
            label34.Location = new Point(9, 353);
            label34.Name = "label34";
            label34.Size = new Size(122, 17);
            label34.TabIndex = 72;
            label34.Text = "WorkSpeedRate";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.ForeColor = Color.Blue;
            label30.Location = new Point(228, 290);
            label30.Name = "label30";
            label30.Size = new Size(195, 17);
            label30.TabIndex = 70;
            label30.Text = "EnableAimAssistKeyboard";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.ForeColor = Color.Blue;
            label31.Location = new Point(6, 290);
            label31.Name = "label31";
            label31.Size = new Size(153, 17);
            label31.TabIndex = 68;
            label31.Text = "EnableAimAssistPad";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.ForeColor = Color.Blue;
            label32.Location = new Point(228, 226);
            label32.Name = "label32";
            label32.Size = new Size(145, 17);
            label32.TabIndex = 66;
            label32.Text = "EnableFriendlyFire";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.ForeColor = Color.Blue;
            label33.Location = new Point(6, 226);
            label33.Name = "label33";
            label33.Size = new Size(224, 17);
            label33.TabIndex = 64;
            label33.Text = "EnablePlayerToPlayerDamage";
            // 
            // PlayerAutoHpRegeneRateInSleep
            // 
            PlayerAutoHpRegeneRateInSleep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerAutoHpRegeneRateInSleep.ForeColor = Color.Purple;
            PlayerAutoHpRegeneRateInSleep.Location = new Point(231, 184);
            PlayerAutoHpRegeneRateInSleep.Name = "PlayerAutoHpRegeneRateInSleep";
            PlayerAutoHpRegeneRateInSleep.Size = new Size(144, 27);
            PlayerAutoHpRegeneRateInSleep.TabIndex = 63;
            PlayerAutoHpRegeneRateInSleep.Text = "1.000000";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Blue;
            label24.Location = new Point(228, 161);
            label24.Name = "label24";
            label24.Size = new Size(245, 17);
            label24.TabIndex = 62;
            label24.Text = "PlayerAutoHpRegeneRateInSleep";
            // 
            // PlayerAutoHPRegeneRate
            // 
            PlayerAutoHPRegeneRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerAutoHPRegeneRate.ForeColor = Color.Purple;
            PlayerAutoHPRegeneRate.Location = new Point(9, 184);
            PlayerAutoHPRegeneRate.Name = "PlayerAutoHPRegeneRate";
            PlayerAutoHPRegeneRate.Size = new Size(144, 27);
            PlayerAutoHPRegeneRate.TabIndex = 61;
            PlayerAutoHPRegeneRate.Text = "1.000000";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Blue;
            label25.Location = new Point(6, 161);
            label25.Name = "label25";
            label25.Size = new Size(191, 17);
            label25.TabIndex = 60;
            label25.Text = "PlayerAutoHPRegeneRate";
            // 
            // PlayerStaminaDecreaceRate
            // 
            PlayerStaminaDecreaceRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerStaminaDecreaceRate.ForeColor = Color.Purple;
            PlayerStaminaDecreaceRate.Location = new Point(231, 120);
            PlayerStaminaDecreaceRate.Name = "PlayerStaminaDecreaceRate";
            PlayerStaminaDecreaceRate.Size = new Size(144, 27);
            PlayerStaminaDecreaceRate.TabIndex = 59;
            PlayerStaminaDecreaceRate.Text = "1.000000";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.Blue;
            label26.Location = new Point(228, 97);
            label26.Name = "label26";
            label26.Size = new Size(208, 17);
            label26.TabIndex = 58;
            label26.Text = "PlayerStaminaDecreaceRate";
            // 
            // PlayerStomachDecreaceRate
            // 
            PlayerStomachDecreaceRate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerStomachDecreaceRate.ForeColor = Color.Purple;
            PlayerStomachDecreaceRate.Location = new Point(9, 120);
            PlayerStomachDecreaceRate.Name = "PlayerStomachDecreaceRate";
            PlayerStomachDecreaceRate.Size = new Size(144, 27);
            PlayerStomachDecreaceRate.TabIndex = 57;
            PlayerStomachDecreaceRate.Text = "1.000000";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.Blue;
            label27.Location = new Point(6, 97);
            label27.Name = "label27";
            label27.Size = new Size(212, 17);
            label27.TabIndex = 56;
            label27.Text = "PlayerStomachDecreaceRate";
            // 
            // PlayerDamageRateDefense
            // 
            PlayerDamageRateDefense.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerDamageRateDefense.ForeColor = Color.Purple;
            PlayerDamageRateDefense.Location = new Point(231, 55);
            PlayerDamageRateDefense.Name = "PlayerDamageRateDefense";
            PlayerDamageRateDefense.Size = new Size(144, 27);
            PlayerDamageRateDefense.TabIndex = 55;
            PlayerDamageRateDefense.Text = "1.000000";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.Blue;
            label28.Location = new Point(228, 32);
            label28.Name = "label28";
            label28.Size = new Size(200, 17);
            label28.TabIndex = 54;
            label28.Text = "PlayerDamageRateDefense";
            // 
            // PlayerDamageRateAttack
            // 
            PlayerDamageRateAttack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            PlayerDamageRateAttack.ForeColor = Color.Purple;
            PlayerDamageRateAttack.Location = new Point(9, 55);
            PlayerDamageRateAttack.Name = "PlayerDamageRateAttack";
            PlayerDamageRateAttack.Size = new Size(153, 27);
            PlayerDamageRateAttack.TabIndex = 53;
            PlayerDamageRateAttack.Text = "1.000000";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.Blue;
            label29.Location = new Point(6, 32);
            label29.Name = "label29";
            label29.Size = new Size(187, 17);
            label29.TabIndex = 52;
            label29.Text = "PlayerDamageRateAttack";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Rockwell", 6F);
            label35.Location = new Point(434, 584);
            label35.Name = "label35";
            label35.Size = new Size(129, 12);
            label35.TabIndex = 53;
            label35.Text = "Created by MaStErTaRaCe";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Rockwell", 6F);
            label36.Location = new Point(436, 414);
            label36.Name = "label36";
            label36.Size = new Size(129, 12);
            label36.TabIndex = 92;
            label36.Text = "Created by MaStErTaRaCe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 908);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Palworld Server Configurator";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox BaseCampMaxNUm;
        private Label label5;
        private TextBox EnemyDropItemRate;
        private Label label6;
        private TextBox CollectionDropRate;
        private Label label7;
        private TextBox BuildObjectDeteriorationRate;
        private Label label8;
        private TextBox BuildObjectDamageRate;
        private Label label3;
        private TextBox ExpRate;
        private Label label4;
        private TextBox NightTimeSpeedRate;
        private Label label2;
        private TextBox DayTimeSpeedRate;
        private Label label1;
        private TextBox CollectionObjectRespawnSpeedRate;
        private Label label9;
        private TextBox AutoResetGuildTimeNoOnlinePlayers;
        private Label label12;
        private Label label11;
        private TextBox BaseCampWorkerMaxNum;
        private Label label10;
        private GroupBox groupBox1;
        private TextBox PublicIp;
        private Label label21;
        private TextBox PublicPort;
        private Label label22;
        private TextBox ServerPassword;
        private Label label20;
        private TextBox AdminPassword;
        private Label label19;
        private TextBox ServerDescription;
        private Label label18;
        private TextBox ServerName;
        private Label label17;
        private GroupBox groupBox2;
        private TextBox ServerPlayerMaxNum;
        private Label label16;
        private TextBox CoopPlayerMaxNum;
        private Label label15;
        private Label label14;
        private TextBox GuildPlayerMaxNum;
        private Label label13;
        private Label label23;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private TextBox PlayerAutoHpRegeneRateInSleep;
        private Label label24;
        private TextBox PlayerAutoHPRegeneRate;
        private Label label25;
        private TextBox PlayerStaminaDecreaceRate;
        private Label label26;
        private TextBox PlayerStomachDecreaceRate;
        private Label label27;
        private TextBox PlayerDamageRateDefense;
        private Label label28;
        private TextBox PlayerDamageRateAttack;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private GroupBox groupBox4;
        private TextBox PalEggDefaultHatchingTime;
        private Label label37;
        private TextBox PalAutoHpRegeneRateInSleep;
        private Label label38;
        private TextBox PalAutoHPRegeneRate;
        private Label label39;
        private TextBox PalStaminaDecreaceRate;
        private Label label40;
        private TextBox PalStomachDecreaceRate;
        private Label label41;
        private TextBox PalDamageRateDefense;
        private Label label42;
        private TextBox PalDamageRateAttack;
        private Label label43;
        private TextBox PalSpawnNumRate;
        private Label label44;
        private TextBox PalCaptureRate;
        private Label label45;
        private TextBox WorkSpeedRate;
        private Label label34;
        private Button button1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox AutoResetGuildNoOnlinePlayers;
        private ComboBox StartLocationSelectByMap;
        private ComboBox EnableInvaderEnemy;
        private ComboBox EnablePlayerToPlayerDamage;
        private ComboBox EnableFriendlyFire;
        private ComboBox EnableAimAssistPad;
        private ComboBox EnableAimAssistKeyboard;
        private ToolTip toolTip1;
        private Label label35;
        private Label label36;
    }
}
