﻿using System;
using System.Windows.Forms;

namespace RigsterForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LogPage = new System.Windows.Forms.TabPage();
            this.collectionPanle = new System.Windows.Forms.Panel();
            this.groupBox_Adress = new System.Windows.Forms.GroupBox();
            this.AdressCheck = new System.Windows.Forms.CheckBox();
            this.refComboBox = new System.Windows.Forms.ComboBox();
            this.commAdressTb = new System.Windows.Forms.TextBox();
            this.Comm_Road_TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Comm_Country_combobox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Comm_City_combobox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.regisAdressTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.accountID_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Rgis_Road_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Rgis_Country_combobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Rgis_City_combobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_account_number = new System.Windows.Forms.TextBox();
            this.textBox_account_divn = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_account_name = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox_mate = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mate_Add_phoneBtn = new System.Windows.Forms.Button();
            this.m_phone_pannel_0 = new System.Windows.Forms.Panel();
            this.m_delete_phone_button_0 = new System.Windows.Forms.Button();
            this.textBox_name_m0 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.SearchBtn_mate = new System.Windows.Forms.Button();
            this.textBox_mate_IDnumber = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox_mate_name = new System.Windows.Forms.TextBox();
            this.ButtonPannel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ClearInfoBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.RecentEditTimeLabel = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.firstLogTimeLabel = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.SerialNumLabel = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox_newBorn = new System.Windows.Forms.GroupBox();
            this.nb_num_TextBOX = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.Add_newBorn_Btn = new System.Windows.Forms.Button();
            this._newBorn_panel_0 = new System.Windows.Forms.Panel();
            this.newBornDelete_Btn_0 = new System.Windows.Forms.Button();
            this.birthdayCB_0 = new System.Windows.Forms.ComboBox();
            this.birthMonthCB_0 = new System.Windows.Forms.ComboBox();
            this.birthYearCB_0 = new System.Windows.Forms.ComboBox();
            this.yearLabelText_0 = new System.Windows.Forms.Label();
            this.dayLabelText = new System.Windows.Forms.Label();
            this.monthLabelText = new System.Windows.Forms.Label();
            this.nbBirthDateHint = new System.Windows.Forms.Label();
            this.birthDate_Label = new System.Windows.Forms.Label();
            this.textBox_newBorn_IDnumber_0 = new System.Windows.Forms.TextBox();
            this.nb_ID_label = new System.Windows.Forms.Label();
            this.newBornNameLabel = new System.Windows.Forms.Label();
            this.textBox_name_nb0 = new System.Windows.Forms.TextBox();
            this.SearchBtn_newBorn = new System.Windows.Forms.Button();
            this.groupBox_query = new System.Windows.Forms.GroupBox();
            this.query_relation = new System.Windows.Forms.TextBox();
            this.Add_query_phoneBtn = new System.Windows.Forms.Button();
            this.q_phone_pannel_0 = new System.Windows.Forms.Panel();
            this.q_delete_phone_button_0 = new System.Windows.Forms.Button();
            this.textBox_name_q0 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.SearchBtn_query = new System.Windows.Forms.Button();
            this.textBox_query_IDnumber = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_query_name = new System.Windows.Forms.TextBox();
            this.groupBox_apply = new System.Windows.Forms.GroupBox();
            this.Add_apply_phoneBtn = new System.Windows.Forms.Button();
            this.a_phone_pannel_0 = new System.Windows.Forms.Panel();
            this.a_delete_phone_button_0 = new System.Windows.Forms.Button();
            this.textBox_name_a0 = new System.Windows.Forms.TextBox();
            this.contactText_label = new System.Windows.Forms.Label();
            this.SearchBtn_apply = new System.Windows.Forms.Button();
            this.textBox_apply_IDnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_apply_name = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.collectionPanel1 = new System.Windows.Forms.Panel();
            this.RemitDateBtn = new System.Windows.Forms.Button();
            this.batchSensorBtn = new System.Windows.Forms.Button();
            this.exportRemitBTN = new System.Windows.Forms.Button();
            this.exportPDFBtn = new System.Windows.Forms.Button();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.IDsearchBtn = new System.Windows.Forms.Button();
            this.IDsearchBOX = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.exportExcelBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.search_end_dd = new System.Windows.Forms.ComboBox();
            this.search_start_dd = new System.Windows.Forms.ComboBox();
            this.search_end_mm = new System.Windows.Forms.ComboBox();
            this.search_end_yy = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.search_start_mm = new System.Windows.Forms.ComboBox();
            this.search_start_yy = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settings_panel = new System.Windows.Forms.Panel();
            this.remitFormatTB4 = new System.Windows.Forms.TextBox();
            this.remitFormatTB3 = new System.Windows.Forms.TextBox();
            this.remitFormatTB2 = new System.Windows.Forms.TextBox();
            this.remitFormatTB1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label14876 = new System.Windows.Forms.Label();
            this.label1324 = new System.Windows.Forms.Label();
            this.change_remitFormatBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.change_databasePthBtn = new System.Windows.Forms.Button();
            this.dataBAsePath_setTB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.changeAllowanceBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.allowanceSetting_TB = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.LogPage.SuspendLayout();
            this.collectionPanle.SuspendLayout();
            this.groupBox_Adress.SuspendLayout();
            this.groupBox_mate.SuspendLayout();
            this.m_phone_pannel_0.SuspendLayout();
            this.ButtonPannel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.groupBox_newBorn.SuspendLayout();
            this._newBorn_panel_0.SuspendLayout();
            this.groupBox_query.SuspendLayout();
            this.q_phone_pannel_0.SuspendLayout();
            this.groupBox_apply.SuspendLayout();
            this.a_phone_pannel_0.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.collectionPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            this.settingsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settings_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.LogPage);
            this.tabControl.Controls.Add(this.historyPage);
            this.tabControl.Controls.Add(this.settingsPage);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // LogPage
            // 
            resources.ApplyResources(this.LogPage, "LogPage");
            this.LogPage.BackColor = System.Drawing.Color.AliceBlue;
            this.LogPage.Controls.Add(this.collectionPanle);
            this.LogPage.Controls.Add(this.checkBox3);
            this.LogPage.Controls.Add(this.label10);
            this.LogPage.Name = "LogPage";
            // 
            // collectionPanle
            // 
            this.collectionPanle.BackColor = System.Drawing.Color.Transparent;
            this.collectionPanle.Controls.Add(this.groupBox_Adress);
            this.collectionPanle.Controls.Add(this.groupBox_mate);
            this.collectionPanle.Controls.Add(this.ButtonPannel);
            this.collectionPanle.Controls.Add(this.infoPanel);
            this.collectionPanle.Controls.Add(this.groupBox_newBorn);
            this.collectionPanle.Controls.Add(this.groupBox_query);
            this.collectionPanle.Controls.Add(this.groupBox_apply);
            resources.ApplyResources(this.collectionPanle, "collectionPanle");
            this.collectionPanle.Name = "collectionPanle";
            // 
            // groupBox_Adress
            // 
            this.groupBox_Adress.BackColor = System.Drawing.Color.White;
            this.groupBox_Adress.Controls.Add(this.AdressCheck);
            this.groupBox_Adress.Controls.Add(this.refComboBox);
            this.groupBox_Adress.Controls.Add(this.commAdressTb);
            this.groupBox_Adress.Controls.Add(this.Comm_Road_TextBox);
            this.groupBox_Adress.Controls.Add(this.label13);
            this.groupBox_Adress.Controls.Add(this.Comm_Country_combobox);
            this.groupBox_Adress.Controls.Add(this.label14);
            this.groupBox_Adress.Controls.Add(this.Comm_City_combobox);
            this.groupBox_Adress.Controls.Add(this.label15);
            this.groupBox_Adress.Controls.Add(this.regisAdressTb);
            this.groupBox_Adress.Controls.Add(this.label11);
            this.groupBox_Adress.Controls.Add(this.accountID_tb);
            this.groupBox_Adress.Controls.Add(this.label12);
            this.groupBox_Adress.Controls.Add(this.Rgis_Road_TextBox);
            this.groupBox_Adress.Controls.Add(this.label9);
            this.groupBox_Adress.Controls.Add(this.Rgis_Country_combobox);
            this.groupBox_Adress.Controls.Add(this.label8);
            this.groupBox_Adress.Controls.Add(this.Rgis_City_combobox);
            this.groupBox_Adress.Controls.Add(this.label7);
            this.groupBox_Adress.Controls.Add(this.label6);
            this.groupBox_Adress.Controls.Add(this.label5);
            this.groupBox_Adress.Controls.Add(this.textBox_account_number);
            this.groupBox_Adress.Controls.Add(this.textBox_account_divn);
            this.groupBox_Adress.Controls.Add(this.label29);
            this.groupBox_Adress.Controls.Add(this.textBox_account_name);
            this.groupBox_Adress.Controls.Add(this.label28);
            resources.ApplyResources(this.groupBox_Adress, "groupBox_Adress");
            this.groupBox_Adress.ForeColor = System.Drawing.Color.Black;
            this.groupBox_Adress.Name = "groupBox_Adress";
            this.groupBox_Adress.TabStop = false;
            // 
            // AdressCheck
            // 
            resources.ApplyResources(this.AdressCheck, "AdressCheck");
            this.AdressCheck.Name = "AdressCheck";
            this.AdressCheck.UseVisualStyleBackColor = true;
            // 
            // refComboBox
            // 
            this.refComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.refComboBox, "refComboBox");
            this.refComboBox.FormattingEnabled = true;
            this.refComboBox.Name = "refComboBox";
            this.refComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedChange);
            // 
            // commAdressTb
            // 
            this.commAdressTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.commAdressTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.commAdressTb, "commAdressTb");
            this.commAdressTb.ForeColor = System.Drawing.Color.DarkBlue;
            this.commAdressTb.HideSelection = false;
            this.commAdressTb.Name = "commAdressTb";
            this.commAdressTb.ReadOnly = true;
            // 
            // Comm_Road_TextBox
            // 
            this.Comm_Road_TextBox.AcceptsReturn = true;
            this.Comm_Road_TextBox.AcceptsTab = true;
            resources.ApplyResources(this.Comm_Road_TextBox, "Comm_Road_TextBox");
            this.Comm_Road_TextBox.Name = "Comm_Road_TextBox";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // Comm_Country_combobox
            // 
            this.Comm_Country_combobox.DropDownHeight = 600;
            resources.ApplyResources(this.Comm_Country_combobox, "Comm_Country_combobox");
            this.Comm_Country_combobox.FormattingEnabled = true;
            this.Comm_Country_combobox.Name = "Comm_Country_combobox";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // Comm_City_combobox
            // 
            this.Comm_City_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Comm_City_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Comm_City_combobox.DropDownHeight = 600;
            resources.ApplyResources(this.Comm_City_combobox, "Comm_City_combobox");
            this.Comm_City_combobox.FormattingEnabled = true;
            this.Comm_City_combobox.Name = "Comm_City_combobox";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // regisAdressTb
            // 
            this.regisAdressTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.regisAdressTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.regisAdressTb, "regisAdressTb");
            this.regisAdressTb.ForeColor = System.Drawing.Color.DarkBlue;
            this.regisAdressTb.HideSelection = false;
            this.regisAdressTb.Name = "regisAdressTb";
            this.regisAdressTb.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // accountID_tb
            // 
            this.accountID_tb.AcceptsReturn = true;
            this.accountID_tb.AcceptsTab = true;
            resources.ApplyResources(this.accountID_tb, "accountID_tb");
            this.accountID_tb.Name = "accountID_tb";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // Rgis_Road_TextBox
            // 
            this.Rgis_Road_TextBox.AcceptsReturn = true;
            this.Rgis_Road_TextBox.AcceptsTab = true;
            resources.ApplyResources(this.Rgis_Road_TextBox, "Rgis_Road_TextBox");
            this.Rgis_Road_TextBox.Name = "Rgis_Road_TextBox";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Rgis_Country_combobox
            // 
            this.Rgis_Country_combobox.DropDownHeight = 600;
            resources.ApplyResources(this.Rgis_Country_combobox, "Rgis_Country_combobox");
            this.Rgis_Country_combobox.FormattingEnabled = true;
            this.Rgis_Country_combobox.Name = "Rgis_Country_combobox";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // Rgis_City_combobox
            // 
            this.Rgis_City_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Rgis_City_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Rgis_City_combobox.DropDownHeight = 600;
            resources.ApplyResources(this.Rgis_City_combobox, "Rgis_City_combobox");
            this.Rgis_City_combobox.FormattingEnabled = true;
            this.Rgis_City_combobox.Name = "Rgis_City_combobox";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox_account_number
            // 
            this.textBox_account_number.AcceptsReturn = true;
            this.textBox_account_number.AcceptsTab = true;
            resources.ApplyResources(this.textBox_account_number, "textBox_account_number");
            this.textBox_account_number.Name = "textBox_account_number";
            // 
            // textBox_account_divn
            // 
            this.textBox_account_divn.AcceptsReturn = true;
            this.textBox_account_divn.AcceptsTab = true;
            resources.ApplyResources(this.textBox_account_divn, "textBox_account_divn");
            this.textBox_account_divn.Name = "textBox_account_divn";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // textBox_account_name
            // 
            this.textBox_account_name.AcceptsReturn = true;
            this.textBox_account_name.AcceptsTab = true;
            resources.ApplyResources(this.textBox_account_name, "textBox_account_name");
            this.textBox_account_name.Name = "textBox_account_name";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // groupBox_mate
            // 
            this.groupBox_mate.BackColor = System.Drawing.Color.White;
            this.groupBox_mate.Controls.Add(this.label4);
            this.groupBox_mate.Controls.Add(this.mate_Add_phoneBtn);
            this.groupBox_mate.Controls.Add(this.m_phone_pannel_0);
            this.groupBox_mate.Controls.Add(this.SearchBtn_mate);
            this.groupBox_mate.Controls.Add(this.textBox_mate_IDnumber);
            this.groupBox_mate.Controls.Add(this.label77);
            this.groupBox_mate.Controls.Add(this.textBox_mate_name);
            resources.ApplyResources(this.groupBox_mate, "groupBox_mate");
            this.groupBox_mate.ForeColor = System.Drawing.Color.Black;
            this.groupBox_mate.Name = "groupBox_mate";
            this.groupBox_mate.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // mate_Add_phoneBtn
            // 
            this.mate_Add_phoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.mate_Add_phoneBtn, "mate_Add_phoneBtn");
            this.mate_Add_phoneBtn.Name = "mate_Add_phoneBtn";
            this.mate_Add_phoneBtn.UseVisualStyleBackColor = true;
            this.mate_Add_phoneBtn.Click += new System.EventHandler(this.Add_panel_Btn_Click);
            // 
            // m_phone_pannel_0
            // 
            this.m_phone_pannel_0.BackColor = System.Drawing.Color.Azure;
            this.m_phone_pannel_0.Controls.Add(this.m_delete_phone_button_0);
            this.m_phone_pannel_0.Controls.Add(this.textBox_name_m0);
            this.m_phone_pannel_0.Controls.Add(this.label74);
            resources.ApplyResources(this.m_phone_pannel_0, "m_phone_pannel_0");
            this.m_phone_pannel_0.Name = "m_phone_pannel_0";
            // 
            // m_delete_phone_button_0
            // 
            this.m_delete_phone_button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.m_delete_phone_button_0, "m_delete_phone_button_0");
            this.m_delete_phone_button_0.Name = "m_delete_phone_button_0";
            this.m_delete_phone_button_0.UseVisualStyleBackColor = true;
            this.m_delete_phone_button_0.Click += new System.EventHandler(this.Delete_panel_Btn_Click);
            // 
            // textBox_name_m0
            // 
            this.textBox_name_m0.AcceptsReturn = true;
            this.textBox_name_m0.AcceptsTab = true;
            resources.ApplyResources(this.textBox_name_m0, "textBox_name_m0");
            this.textBox_name_m0.Name = "textBox_name_m0";
            // 
            // label74
            // 
            resources.ApplyResources(this.label74, "label74");
            this.label74.Name = "label74";
            // 
            // SearchBtn_mate
            // 
            resources.ApplyResources(this.SearchBtn_mate, "SearchBtn_mate");
            this.SearchBtn_mate.Name = "SearchBtn_mate";
            this.SearchBtn_mate.UseVisualStyleBackColor = true;
            this.SearchBtn_mate.Click += new System.EventHandler(this.Search_ID_Btn_Click);
            // 
            // textBox_mate_IDnumber
            // 
            this.textBox_mate_IDnumber.AcceptsReturn = true;
            this.textBox_mate_IDnumber.AcceptsTab = true;
            resources.ApplyResources(this.textBox_mate_IDnumber, "textBox_mate_IDnumber");
            this.textBox_mate_IDnumber.Name = "textBox_mate_IDnumber";
            // 
            // label77
            // 
            resources.ApplyResources(this.label77, "label77");
            this.label77.Name = "label77";
            // 
            // textBox_mate_name
            // 
            this.textBox_mate_name.AcceptsReturn = true;
            this.textBox_mate_name.AcceptsTab = true;
            resources.ApplyResources(this.textBox_mate_name, "textBox_mate_name");
            this.textBox_mate_name.Name = "textBox_mate_name";
            // 
            // ButtonPannel
            // 
            this.ButtonPannel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPannel.Controls.Add(this.CancelBtn);
            this.ButtonPannel.Controls.Add(this.ClearInfoBtn);
            this.ButtonPannel.Controls.Add(this.saveBtn);
            resources.ApplyResources(this.ButtonPannel, "ButtonPannel");
            this.ButtonPannel.Name = "ButtonPannel";
            // 
            // CancelBtn
            // 
            resources.ApplyResources(this.CancelBtn, "CancelBtn");
            this.CancelBtn.ForeColor = System.Drawing.Color.Red;
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ClearInfoBtn
            // 
            resources.ApplyResources(this.ClearInfoBtn, "ClearInfoBtn");
            this.ClearInfoBtn.Name = "ClearInfoBtn";
            this.ClearInfoBtn.UseVisualStyleBackColor = true;
            this.ClearInfoBtn.Click += new System.EventHandler(this.ClearInfoBtn_Click);
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Controls.Add(this.RecentEditTimeLabel);
            this.infoPanel.Controls.Add(this.label45);
            this.infoPanel.Controls.Add(this.firstLogTimeLabel);
            this.infoPanel.Controls.Add(this.label43);
            this.infoPanel.Controls.Add(this.SerialNumLabel);
            this.infoPanel.Controls.Add(this.label41);
            resources.ApplyResources(this.infoPanel, "infoPanel");
            this.infoPanel.Name = "infoPanel";
            // 
            // RecentEditTimeLabel
            // 
            resources.ApplyResources(this.RecentEditTimeLabel, "RecentEditTimeLabel");
            this.RecentEditTimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.RecentEditTimeLabel.Name = "RecentEditTimeLabel";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.ForeColor = System.Drawing.Color.Gray;
            this.label45.Name = "label45";
            // 
            // firstLogTimeLabel
            // 
            resources.ApplyResources(this.firstLogTimeLabel, "firstLogTimeLabel");
            this.firstLogTimeLabel.ForeColor = System.Drawing.Color.Gray;
            this.firstLogTimeLabel.Name = "firstLogTimeLabel";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.ForeColor = System.Drawing.Color.Gray;
            this.label43.Name = "label43";
            // 
            // SerialNumLabel
            // 
            resources.ApplyResources(this.SerialNumLabel, "SerialNumLabel");
            this.SerialNumLabel.ForeColor = System.Drawing.Color.Gray;
            this.SerialNumLabel.Name = "SerialNumLabel";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.ForeColor = System.Drawing.Color.Gray;
            this.label41.Name = "label41";
            // 
            // groupBox_newBorn
            // 
            this.groupBox_newBorn.BackColor = System.Drawing.Color.White;
            this.groupBox_newBorn.Controls.Add(this.nb_num_TextBOX);
            this.groupBox_newBorn.Controls.Add(this.label40);
            this.groupBox_newBorn.Controls.Add(this.Add_newBorn_Btn);
            this.groupBox_newBorn.Controls.Add(this._newBorn_panel_0);
            this.groupBox_newBorn.Controls.Add(this.SearchBtn_newBorn);
            resources.ApplyResources(this.groupBox_newBorn, "groupBox_newBorn");
            this.groupBox_newBorn.ForeColor = System.Drawing.Color.Black;
            this.groupBox_newBorn.Name = "groupBox_newBorn";
            this.groupBox_newBorn.TabStop = false;
            // 
            // nb_num_TextBOX
            // 
            this.nb_num_TextBOX.AcceptsReturn = true;
            this.nb_num_TextBOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.nb_num_TextBOX, "nb_num_TextBOX");
            this.nb_num_TextBOX.Name = "nb_num_TextBOX";
            this.nb_num_TextBOX.ReadOnly = true;
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // Add_newBorn_Btn
            // 
            this.Add_newBorn_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Add_newBorn_Btn, "Add_newBorn_Btn");
            this.Add_newBorn_Btn.Name = "Add_newBorn_Btn";
            this.Add_newBorn_Btn.UseVisualStyleBackColor = true;
            this.Add_newBorn_Btn.Click += new System.EventHandler(this.Add_panel_Btn_Click);
            // 
            // _newBorn_panel_0
            // 
            this._newBorn_panel_0.BackColor = System.Drawing.Color.Honeydew;
            this._newBorn_panel_0.Controls.Add(this.newBornDelete_Btn_0);
            this._newBorn_panel_0.Controls.Add(this.birthdayCB_0);
            this._newBorn_panel_0.Controls.Add(this.birthMonthCB_0);
            this._newBorn_panel_0.Controls.Add(this.birthYearCB_0);
            this._newBorn_panel_0.Controls.Add(this.yearLabelText_0);
            this._newBorn_panel_0.Controls.Add(this.dayLabelText);
            this._newBorn_panel_0.Controls.Add(this.monthLabelText);
            this._newBorn_panel_0.Controls.Add(this.nbBirthDateHint);
            this._newBorn_panel_0.Controls.Add(this.birthDate_Label);
            this._newBorn_panel_0.Controls.Add(this.textBox_newBorn_IDnumber_0);
            this._newBorn_panel_0.Controls.Add(this.nb_ID_label);
            this._newBorn_panel_0.Controls.Add(this.newBornNameLabel);
            this._newBorn_panel_0.Controls.Add(this.textBox_name_nb0);
            resources.ApplyResources(this._newBorn_panel_0, "_newBorn_panel_0");
            this._newBorn_panel_0.Name = "_newBorn_panel_0";
            // 
            // newBornDelete_Btn_0
            // 
            resources.ApplyResources(this.newBornDelete_Btn_0, "newBornDelete_Btn_0");
            this.newBornDelete_Btn_0.Name = "newBornDelete_Btn_0";
            this.newBornDelete_Btn_0.UseVisualStyleBackColor = true;
            this.newBornDelete_Btn_0.Click += new System.EventHandler(this.Delete_panel_Btn_Click);
            // 
            // birthdayCB_0
            // 
            this.birthdayCB_0.DropDownHeight = 200;
            resources.ApplyResources(this.birthdayCB_0, "birthdayCB_0");
            this.birthdayCB_0.FormattingEnabled = true;
            this.birthdayCB_0.Name = "birthdayCB_0";
            // 
            // birthMonthCB_0
            // 
            this.birthMonthCB_0.DropDownHeight = 200;
            resources.ApplyResources(this.birthMonthCB_0, "birthMonthCB_0");
            this.birthMonthCB_0.FormattingEnabled = true;
            this.birthMonthCB_0.Name = "birthMonthCB_0";
            // 
            // birthYearCB_0
            // 
            this.birthYearCB_0.DropDownHeight = 200;
            resources.ApplyResources(this.birthYearCB_0, "birthYearCB_0");
            this.birthYearCB_0.FormattingEnabled = true;
            this.birthYearCB_0.Name = "birthYearCB_0";
            // 
            // yearLabelText_0
            // 
            resources.ApplyResources(this.yearLabelText_0, "yearLabelText_0");
            this.yearLabelText_0.Name = "yearLabelText_0";
            // 
            // dayLabelText
            // 
            resources.ApplyResources(this.dayLabelText, "dayLabelText");
            this.dayLabelText.Name = "dayLabelText";
            // 
            // monthLabelText
            // 
            resources.ApplyResources(this.monthLabelText, "monthLabelText");
            this.monthLabelText.Name = "monthLabelText";
            // 
            // nbBirthDateHint
            // 
            resources.ApplyResources(this.nbBirthDateHint, "nbBirthDateHint");
            this.nbBirthDateHint.Name = "nbBirthDateHint";
            // 
            // birthDate_Label
            // 
            resources.ApplyResources(this.birthDate_Label, "birthDate_Label");
            this.birthDate_Label.Name = "birthDate_Label";
            // 
            // textBox_newBorn_IDnumber_0
            // 
            this.textBox_newBorn_IDnumber_0.AcceptsReturn = true;
            this.textBox_newBorn_IDnumber_0.AcceptsTab = true;
            resources.ApplyResources(this.textBox_newBorn_IDnumber_0, "textBox_newBorn_IDnumber_0");
            this.textBox_newBorn_IDnumber_0.Name = "textBox_newBorn_IDnumber_0";
            // 
            // nb_ID_label
            // 
            resources.ApplyResources(this.nb_ID_label, "nb_ID_label");
            this.nb_ID_label.Name = "nb_ID_label";
            // 
            // newBornNameLabel
            // 
            resources.ApplyResources(this.newBornNameLabel, "newBornNameLabel");
            this.newBornNameLabel.Name = "newBornNameLabel";
            // 
            // textBox_name_nb0
            // 
            this.textBox_name_nb0.AcceptsReturn = true;
            this.textBox_name_nb0.AcceptsTab = true;
            resources.ApplyResources(this.textBox_name_nb0, "textBox_name_nb0");
            this.textBox_name_nb0.Name = "textBox_name_nb0";
            // 
            // SearchBtn_newBorn
            // 
            resources.ApplyResources(this.SearchBtn_newBorn, "SearchBtn_newBorn");
            this.SearchBtn_newBorn.Name = "SearchBtn_newBorn";
            this.SearchBtn_newBorn.UseVisualStyleBackColor = true;
            this.SearchBtn_newBorn.Click += new System.EventHandler(this.Search_ID_Btn_Click);
            // 
            // groupBox_query
            // 
            this.groupBox_query.BackColor = System.Drawing.Color.White;
            this.groupBox_query.Controls.Add(this.query_relation);
            this.groupBox_query.Controls.Add(this.Add_query_phoneBtn);
            this.groupBox_query.Controls.Add(this.q_phone_pannel_0);
            this.groupBox_query.Controls.Add(this.label24);
            this.groupBox_query.Controls.Add(this.SearchBtn_query);
            this.groupBox_query.Controls.Add(this.textBox_query_IDnumber);
            this.groupBox_query.Controls.Add(this.label25);
            this.groupBox_query.Controls.Add(this.label26);
            this.groupBox_query.Controls.Add(this.textBox_query_name);
            resources.ApplyResources(this.groupBox_query, "groupBox_query");
            this.groupBox_query.ForeColor = System.Drawing.Color.Black;
            this.groupBox_query.Name = "groupBox_query";
            this.groupBox_query.TabStop = false;
            // 
            // query_relation
            // 
            this.query_relation.AcceptsReturn = true;
            this.query_relation.AcceptsTab = true;
            resources.ApplyResources(this.query_relation, "query_relation");
            this.query_relation.Name = "query_relation";
            // 
            // Add_query_phoneBtn
            // 
            this.Add_query_phoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Add_query_phoneBtn, "Add_query_phoneBtn");
            this.Add_query_phoneBtn.Name = "Add_query_phoneBtn";
            this.Add_query_phoneBtn.UseVisualStyleBackColor = true;
            this.Add_query_phoneBtn.Click += new System.EventHandler(this.Add_panel_Btn_Click);
            // 
            // q_phone_pannel_0
            // 
            this.q_phone_pannel_0.BackColor = System.Drawing.Color.Azure;
            this.q_phone_pannel_0.Controls.Add(this.q_delete_phone_button_0);
            this.q_phone_pannel_0.Controls.Add(this.textBox_name_q0);
            this.q_phone_pannel_0.Controls.Add(this.label23);
            resources.ApplyResources(this.q_phone_pannel_0, "q_phone_pannel_0");
            this.q_phone_pannel_0.Name = "q_phone_pannel_0";
            // 
            // q_delete_phone_button_0
            // 
            this.q_delete_phone_button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.q_delete_phone_button_0, "q_delete_phone_button_0");
            this.q_delete_phone_button_0.Name = "q_delete_phone_button_0";
            this.q_delete_phone_button_0.UseVisualStyleBackColor = true;
            this.q_delete_phone_button_0.Click += new System.EventHandler(this.Delete_panel_Btn_Click);
            // 
            // textBox_name_q0
            // 
            this.textBox_name_q0.AcceptsReturn = true;
            this.textBox_name_q0.AcceptsTab = true;
            resources.ApplyResources(this.textBox_name_q0, "textBox_name_q0");
            this.textBox_name_q0.Name = "textBox_name_q0";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // SearchBtn_query
            // 
            resources.ApplyResources(this.SearchBtn_query, "SearchBtn_query");
            this.SearchBtn_query.Name = "SearchBtn_query";
            this.SearchBtn_query.UseVisualStyleBackColor = true;
            this.SearchBtn_query.Click += new System.EventHandler(this.Search_ID_Btn_Click);
            // 
            // textBox_query_IDnumber
            // 
            this.textBox_query_IDnumber.AcceptsReturn = true;
            this.textBox_query_IDnumber.AcceptsTab = true;
            resources.ApplyResources(this.textBox_query_IDnumber, "textBox_query_IDnumber");
            this.textBox_query_IDnumber.Name = "textBox_query_IDnumber";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // textBox_query_name
            // 
            this.textBox_query_name.AcceptsReturn = true;
            this.textBox_query_name.AcceptsTab = true;
            resources.ApplyResources(this.textBox_query_name, "textBox_query_name");
            this.textBox_query_name.Name = "textBox_query_name";
            // 
            // groupBox_apply
            // 
            this.groupBox_apply.BackColor = System.Drawing.Color.White;
            this.groupBox_apply.Controls.Add(this.Add_apply_phoneBtn);
            this.groupBox_apply.Controls.Add(this.a_phone_pannel_0);
            this.groupBox_apply.Controls.Add(this.SearchBtn_apply);
            this.groupBox_apply.Controls.Add(this.textBox_apply_IDnumber);
            this.groupBox_apply.Controls.Add(this.label3);
            this.groupBox_apply.Controls.Add(this.label2);
            this.groupBox_apply.Controls.Add(this.textBox_apply_name);
            resources.ApplyResources(this.groupBox_apply, "groupBox_apply");
            this.groupBox_apply.ForeColor = System.Drawing.Color.Black;
            this.groupBox_apply.Name = "groupBox_apply";
            this.groupBox_apply.TabStop = false;
            // 
            // Add_apply_phoneBtn
            // 
            this.Add_apply_phoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Add_apply_phoneBtn, "Add_apply_phoneBtn");
            this.Add_apply_phoneBtn.Name = "Add_apply_phoneBtn";
            this.Add_apply_phoneBtn.UseVisualStyleBackColor = true;
            this.Add_apply_phoneBtn.Click += new System.EventHandler(this.Add_panel_Btn_Click);
            // 
            // a_phone_pannel_0
            // 
            this.a_phone_pannel_0.BackColor = System.Drawing.Color.Azure;
            this.a_phone_pannel_0.Controls.Add(this.a_delete_phone_button_0);
            this.a_phone_pannel_0.Controls.Add(this.textBox_name_a0);
            this.a_phone_pannel_0.Controls.Add(this.contactText_label);
            resources.ApplyResources(this.a_phone_pannel_0, "a_phone_pannel_0");
            this.a_phone_pannel_0.Name = "a_phone_pannel_0";
            // 
            // a_delete_phone_button_0
            // 
            this.a_delete_phone_button_0.BackColor = System.Drawing.SystemColors.Control;
            this.a_delete_phone_button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.a_delete_phone_button_0, "a_delete_phone_button_0");
            this.a_delete_phone_button_0.Name = "a_delete_phone_button_0";
            this.a_delete_phone_button_0.UseVisualStyleBackColor = false;
            this.a_delete_phone_button_0.Click += new System.EventHandler(this.Delete_panel_Btn_Click);
            // 
            // textBox_name_a0
            // 
            this.textBox_name_a0.AcceptsReturn = true;
            this.textBox_name_a0.AcceptsTab = true;
            resources.ApplyResources(this.textBox_name_a0, "textBox_name_a0");
            this.textBox_name_a0.Name = "textBox_name_a0";
            // 
            // contactText_label
            // 
            resources.ApplyResources(this.contactText_label, "contactText_label");
            this.contactText_label.Name = "contactText_label";
            // 
            // SearchBtn_apply
            // 
            resources.ApplyResources(this.SearchBtn_apply, "SearchBtn_apply");
            this.SearchBtn_apply.Name = "SearchBtn_apply";
            this.SearchBtn_apply.UseVisualStyleBackColor = true;
            this.SearchBtn_apply.Click += new System.EventHandler(this.Search_ID_Btn_Click);
            // 
            // textBox_apply_IDnumber
            // 
            this.textBox_apply_IDnumber.AcceptsReturn = true;
            this.textBox_apply_IDnumber.AcceptsTab = true;
            resources.ApplyResources(this.textBox_apply_IDnumber, "textBox_apply_IDnumber");
            this.textBox_apply_IDnumber.Name = "textBox_apply_IDnumber";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_apply_name
            // 
            this.textBox_apply_name.AcceptsReturn = true;
            this.textBox_apply_name.AcceptsTab = true;
            resources.ApplyResources(this.textBox_apply_name, "textBox_apply_name");
            this.textBox_apply_name.Name = "textBox_apply_name";
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Name = "label10";
            // 
            // historyPage
            // 
            resources.ApplyResources(this.historyPage, "historyPage");
            this.historyPage.Controls.Add(this.collectionPanel1);
            this.historyPage.Controls.Add(this.label16);
            this.historyPage.Controls.Add(this.search_end_dd);
            this.historyPage.Controls.Add(this.search_start_dd);
            this.historyPage.Controls.Add(this.search_end_mm);
            this.historyPage.Controls.Add(this.search_end_yy);
            this.historyPage.Controls.Add(this.label48);
            this.historyPage.Controls.Add(this.label49);
            this.historyPage.Controls.Add(this.label50);
            this.historyPage.Controls.Add(this.search_start_mm);
            this.historyPage.Controls.Add(this.search_start_yy);
            this.historyPage.Controls.Add(this.label44);
            this.historyPage.Controls.Add(this.label46);
            this.historyPage.Controls.Add(this.label47);
            this.historyPage.Controls.Add(this.label42);
            this.historyPage.Controls.Add(this.label39);
            this.historyPage.Controls.Add(this.historyGridView);
            this.historyPage.Name = "historyPage";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // collectionPanel1
            // 
            this.collectionPanel1.BackColor = System.Drawing.Color.Transparent;
            this.collectionPanel1.Controls.Add(this.RemitDateBtn);
            this.collectionPanel1.Controls.Add(this.batchSensorBtn);
            this.collectionPanel1.Controls.Add(this.exportRemitBTN);
            this.collectionPanel1.Controls.Add(this.exportPDFBtn);
            this.collectionPanel1.Controls.Add(this.clearSearchBtn);
            this.collectionPanel1.Controls.Add(this.IDsearchBtn);
            this.collectionPanel1.Controls.Add(this.IDsearchBOX);
            this.collectionPanel1.Controls.Add(this.label51);
            this.collectionPanel1.Controls.Add(this.exportExcelBtn);
            resources.ApplyResources(this.collectionPanel1, "collectionPanel1");
            this.collectionPanel1.Name = "collectionPanel1";
            // 
            // RemitDateBtn
            // 
            resources.ApplyResources(this.RemitDateBtn, "RemitDateBtn");
            this.RemitDateBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.RemitDateBtn.Name = "RemitDateBtn";
            this.RemitDateBtn.UseVisualStyleBackColor = true;
            this.RemitDateBtn.Click += new System.EventHandler(this.RemitDateBtn_Click);
            // 
            // batchSensorBtn
            // 
            resources.ApplyResources(this.batchSensorBtn, "batchSensorBtn");
            this.batchSensorBtn.ForeColor = System.Drawing.Color.Maroon;
            this.batchSensorBtn.Name = "batchSensorBtn";
            this.batchSensorBtn.UseVisualStyleBackColor = true;
            this.batchSensorBtn.Click += new System.EventHandler(this.batchSensorBtn_Click);
            // 
            // exportRemitBTN
            // 
            resources.ApplyResources(this.exportRemitBTN, "exportRemitBTN");
            this.exportRemitBTN.Name = "exportRemitBTN";
            this.exportRemitBTN.UseVisualStyleBackColor = true;
            this.exportRemitBTN.Click += new System.EventHandler(this.exportRemitBTN_Click);
            // 
            // exportPDFBtn
            // 
            resources.ApplyResources(this.exportPDFBtn, "exportPDFBtn");
            this.exportPDFBtn.Name = "exportPDFBtn";
            this.exportPDFBtn.UseVisualStyleBackColor = true;
            this.exportPDFBtn.Click += new System.EventHandler(this.exportPDFBtn_Click);
            // 
            // clearSearchBtn
            // 
            resources.ApplyResources(this.clearSearchBtn, "clearSearchBtn");
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.UseVisualStyleBackColor = true;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // IDsearchBtn
            // 
            resources.ApplyResources(this.IDsearchBtn, "IDsearchBtn");
            this.IDsearchBtn.Name = "IDsearchBtn";
            this.IDsearchBtn.UseVisualStyleBackColor = true;
            this.IDsearchBtn.Click += new System.EventHandler(this.IDsearchBtn_Click);
            // 
            // IDsearchBOX
            // 
            resources.ApplyResources(this.IDsearchBOX, "IDsearchBOX");
            this.IDsearchBOX.Name = "IDsearchBOX";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Name = "label51";
            // 
            // exportExcelBtn
            // 
            resources.ApplyResources(this.exportExcelBtn, "exportExcelBtn");
            this.exportExcelBtn.Name = "exportExcelBtn";
            this.exportExcelBtn.UseVisualStyleBackColor = true;
            this.exportExcelBtn.Click += new System.EventHandler(this.exportExcelBtn_Click);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // search_end_dd
            // 
            this.search_end_dd.DropDownHeight = 150;
            resources.ApplyResources(this.search_end_dd, "search_end_dd");
            this.search_end_dd.FormattingEnabled = true;
            this.search_end_dd.Name = "search_end_dd";
            // 
            // search_start_dd
            // 
            this.search_start_dd.DropDownHeight = 150;
            resources.ApplyResources(this.search_start_dd, "search_start_dd");
            this.search_start_dd.FormattingEnabled = true;
            this.search_start_dd.Name = "search_start_dd";
            // 
            // search_end_mm
            // 
            this.search_end_mm.DropDownHeight = 150;
            resources.ApplyResources(this.search_end_mm, "search_end_mm");
            this.search_end_mm.FormattingEnabled = true;
            this.search_end_mm.Name = "search_end_mm";
            // 
            // search_end_yy
            // 
            this.search_end_yy.DropDownHeight = 150;
            resources.ApplyResources(this.search_end_yy, "search_end_yy");
            this.search_end_yy.FormattingEnabled = true;
            this.search_end_yy.Name = "search_end_yy";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // search_start_mm
            // 
            this.search_start_mm.DropDownHeight = 150;
            resources.ApplyResources(this.search_start_mm, "search_start_mm");
            this.search_start_mm.FormattingEnabled = true;
            this.search_start_mm.Name = "search_start_mm";
            // 
            // search_start_yy
            // 
            this.search_start_yy.DropDownHeight = 150;
            resources.ApplyResources(this.search_start_yy, "search_start_yy");
            this.search_start_yy.FormattingEnabled = true;
            this.search_start_yy.Name = "search_start_yy";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Name = "label42";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Name = "label39";
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToAddRows = false;
            this.historyGridView.AllowUserToDeleteRows = false;
            this.historyGridView.AllowUserToResizeColumns = false;
            this.historyGridView.AllowUserToResizeRows = false;
            this.historyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.historyGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historyGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            resources.ApplyResources(this.historyGridView, "historyGridView");
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ReadOnly = true;
            this.historyGridView.RowHeadersVisible = false;
            this.historyGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.historyGridView.RowTemplate.Height = 27;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.panel1);
            resources.ApplyResources(this.settingsPage, "settingsPage");
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settings_panel);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label14876);
            this.panel1.Controls.Add(this.label1324);
            this.panel1.Controls.Add(this.change_remitFormatBtn);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.change_databasePthBtn);
            this.panel1.Controls.Add(this.dataBAsePath_setTB);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.changeAllowanceBtn);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.allowanceSetting_TB);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // settings_panel
            // 
            this.settings_panel.BackColor = System.Drawing.Color.Transparent;
            this.settings_panel.Controls.Add(this.remitFormatTB4);
            this.settings_panel.Controls.Add(this.remitFormatTB3);
            this.settings_panel.Controls.Add(this.remitFormatTB2);
            this.settings_panel.Controls.Add(this.remitFormatTB1);
            resources.ApplyResources(this.settings_panel, "settings_panel");
            this.settings_panel.Name = "settings_panel";
            // 
            // remitFormatTB4
            // 
            resources.ApplyResources(this.remitFormatTB4, "remitFormatTB4");
            this.remitFormatTB4.Name = "remitFormatTB4";
            // 
            // remitFormatTB3
            // 
            resources.ApplyResources(this.remitFormatTB3, "remitFormatTB3");
            this.remitFormatTB3.Name = "remitFormatTB3";
            // 
            // remitFormatTB2
            // 
            resources.ApplyResources(this.remitFormatTB2, "remitFormatTB2");
            this.remitFormatTB2.Name = "remitFormatTB2";
            // 
            // remitFormatTB1
            // 
            resources.ApplyResources(this.remitFormatTB1, "remitFormatTB1");
            this.remitFormatTB1.Name = "remitFormatTB1";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.ForeColor = System.Drawing.Color.Navy;
            this.label32.Name = "label32";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.ForeColor = System.Drawing.Color.Maroon;
            this.label31.Name = "label31";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Name = "label30";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.ForeColor = System.Drawing.Color.Navy;
            this.label22.Name = "label22";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.ForeColor = System.Drawing.Color.Navy;
            this.label21.Name = "label21";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.ForeColor = System.Drawing.Color.Navy;
            this.label20.Name = "label20";
            // 
            // label14876
            // 
            resources.ApplyResources(this.label14876, "label14876");
            this.label14876.ForeColor = System.Drawing.Color.Navy;
            this.label14876.Name = "label14876";
            // 
            // label1324
            // 
            resources.ApplyResources(this.label1324, "label1324");
            this.label1324.Name = "label1324";
            // 
            // change_remitFormatBtn
            // 
            resources.ApplyResources(this.change_remitFormatBtn, "change_remitFormatBtn");
            this.change_remitFormatBtn.Name = "change_remitFormatBtn";
            this.change_remitFormatBtn.UseVisualStyleBackColor = true;
            this.change_remitFormatBtn.Click += new System.EventHandler(this.changeSettingsBtn_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // change_databasePthBtn
            // 
            resources.ApplyResources(this.change_databasePthBtn, "change_databasePthBtn");
            this.change_databasePthBtn.Name = "change_databasePthBtn";
            this.change_databasePthBtn.UseVisualStyleBackColor = true;
            this.change_databasePthBtn.Click += new System.EventHandler(this.changeSettingsBtn_Click);
            // 
            // dataBAsePath_setTB
            // 
            resources.ApplyResources(this.dataBAsePath_setTB, "dataBAsePath_setTB");
            this.dataBAsePath_setTB.Name = "dataBAsePath_setTB";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // changeAllowanceBtn
            // 
            resources.ApplyResources(this.changeAllowanceBtn, "changeAllowanceBtn");
            this.changeAllowanceBtn.Name = "changeAllowanceBtn";
            this.changeAllowanceBtn.UseVisualStyleBackColor = true;
            this.changeAllowanceBtn.Click += new System.EventHandler(this.changeSettingsBtn_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // allowanceSetting_TB
            // 
            resources.ApplyResources(this.allowanceSetting_TB, "allowanceSetting_TB");
            this.allowanceSetting_TB.Name = "allowanceSetting_TB";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CausesValidation = false;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.LogPage.ResumeLayout(false);
            this.LogPage.PerformLayout();
            this.collectionPanle.ResumeLayout(false);
            this.groupBox_Adress.ResumeLayout(false);
            this.groupBox_Adress.PerformLayout();
            this.groupBox_mate.ResumeLayout(false);
            this.groupBox_mate.PerformLayout();
            this.m_phone_pannel_0.ResumeLayout(false);
            this.m_phone_pannel_0.PerformLayout();
            this.ButtonPannel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.groupBox_newBorn.ResumeLayout(false);
            this.groupBox_newBorn.PerformLayout();
            this._newBorn_panel_0.ResumeLayout(false);
            this._newBorn_panel_0.PerformLayout();
            this.groupBox_query.ResumeLayout(false);
            this.groupBox_query.PerformLayout();
            this.q_phone_pannel_0.ResumeLayout(false);
            this.q_phone_pannel_0.PerformLayout();
            this.groupBox_apply.ResumeLayout(false);
            this.groupBox_apply.PerformLayout();
            this.a_phone_pannel_0.ResumeLayout(false);
            this.a_phone_pannel_0.PerformLayout();
            this.historyPage.ResumeLayout(false);
            this.historyPage.PerformLayout();
            this.collectionPanel1.ResumeLayout(false);
            this.collectionPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            this.settingsPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settings_panel.ResumeLayout(false);
            this.settings_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void IDsearchBtn_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage LogPage;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox search_end_mm;
        private System.Windows.Forms.ComboBox search_end_yy;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox search_start_mm;
        private System.Windows.Forms.ComboBox search_start_yy;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private Panel collectionPanle;
        private GroupBox groupBox_Adress;
        private CheckBox AdressCheck;
        private ComboBox refComboBox;
        private TextBox commAdressTb;
        private TextBox Comm_Road_TextBox;
        private Label label13;
        private ComboBox Comm_Country_combobox;
        private Label label14;
        private ComboBox Comm_City_combobox;
        private Label label15;
        private TextBox regisAdressTb;
        private Label label11;
        private TextBox accountID_tb;
        private Label label12;
        private TextBox Rgis_Road_TextBox;
        private Label label9;
        private ComboBox Rgis_Country_combobox;
        private Label label8;
        private ComboBox Rgis_City_combobox;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox_account_number;
        private TextBox textBox_account_divn;
        private Label label29;
        private TextBox textBox_account_name;
        private Label label28;
        private GroupBox groupBox_mate;
        private Label label4;
        private Button mate_Add_phoneBtn;
        private Panel m_phone_pannel_0;
        private Button m_delete_phone_button_0;
        private TextBox textBox_name_m0;
        private Label label74;
        private Button SearchBtn_mate;
        private TextBox textBox_mate_IDnumber;
        private Label label77;
        private TextBox textBox_mate_name;
        private Panel ButtonPannel;
        private Button CancelBtn;
        private Button ClearInfoBtn;
        private Button saveBtn;
        private Panel infoPanel;
        private GroupBox groupBox_newBorn;
        private TextBox nb_num_TextBOX;
        private Label label40;
        private Button Add_newBorn_Btn;
        private Panel _newBorn_panel_0;
        private Button newBornDelete_Btn_0;
        private ComboBox birthdayCB_0;
        private ComboBox birthMonthCB_0;
        private ComboBox birthYearCB_0;
        private Label yearLabelText_0;
        private Label dayLabelText;
        private Label monthLabelText;
        private Label nbBirthDateHint;
        private Label birthDate_Label;
        private TextBox textBox_newBorn_IDnumber_0;
        private Label nb_ID_label;
        private Label newBornNameLabel;
        private TextBox textBox_name_nb0;
        private Button SearchBtn_newBorn;
        private GroupBox groupBox_query;
        private TextBox query_relation;
        private Button Add_query_phoneBtn;
        private Panel q_phone_pannel_0;
        private Button q_delete_phone_button_0;
        private TextBox textBox_name_q0;
        private Label label23;
        private Label label24;
        private Button SearchBtn_query;
        private TextBox textBox_query_IDnumber;
        private Label label25;
        private Label label26;
        private TextBox textBox_query_name;
        private GroupBox groupBox_apply;
        private Button Add_apply_phoneBtn;
        private Panel a_phone_pannel_0;
        private Button a_delete_phone_button_0;
        private TextBox textBox_name_a0;
        private Label contactText_label;
        private Button SearchBtn_apply;
        private TextBox textBox_apply_IDnumber;
        private Label label3;
        private Label label2;
        private TextBox textBox_apply_name;
        private ComboBox search_start_dd;
        private Label label16;
        private ComboBox search_end_dd;
        private TabPage settingsPage;
        private Panel collectionPanel1;
        private Button exportRemitBTN;
        private Button exportPDFBtn;
        private Button clearSearchBtn;
        private Button IDsearchBtn;
        private TextBox IDsearchBOX;
        private Label label51;
        private Button exportExcelBtn;
        private Button batchSensorBtn;
        private Panel panel1;
        private Button change_remitFormatBtn;
        private Label label19;
        private Button change_databasePthBtn;
        private TextBox dataBAsePath_setTB;
        private Label label18;
        private Button changeAllowanceBtn;
        private Label label17;
        private TextBox allowanceSetting_TB;
        private Label label1324;
        private Button RemitDateBtn;
        private Label label21;
        private Label label20;
        private Label label14876;
        private Label label22;
        private Label label30;
        private Label label27;
        private Label label32;
        private Label label31;
        private Panel settings_panel;
        private TextBox remitFormatTB4;
        private TextBox remitFormatTB3;
        private TextBox remitFormatTB2;
        private TextBox remitFormatTB1;
        private Label RecentEditTimeLabel;
        private Label label45;
        private Label firstLogTimeLabel;
        private Label label43;
        private Label SerialNumLabel;
        private Label label41;
    }
}

