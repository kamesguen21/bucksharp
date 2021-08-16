
using System.Windows.Forms.DataVisualization.Charting;

namespace bucksharp
{
	partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bucksharpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bucksharpDataSet = new bucksharp.bucksharpDataSet();
            this.bucksharpDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bucksharpDataSet1 = new bucksharp.bucksharpDataSet1();
            this.bucksharpDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.currencyBack = new System.Windows.Forms.Button();
            this.currencyConvert = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.currencyTo = new System.Windows.Forms.ListBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bucksharpDataSet4 = new bucksharp.bucksharpDataSet4();
            this.label15 = new System.Windows.Forms.Label();
            this.currencyReult = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.currencyFrom = new System.Windows.Forms.ListBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bucksharpDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.currencyAmount = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.saveEntryButton = new System.Windows.Forms.Button();
            this.categoryInput = new System.Windows.Forms.ListBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.dateInput = new System.Windows.Forms.DateTimePicker();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.ListBox();
            this.amountlabel = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.saveCat = new System.Windows.Forms.Button();
            this.backCat = new System.Windows.Forms.Button();
            this.catcolorInput = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.catnameInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bucksharpDataSet4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bucksharpDataSet3 = new bucksharp.bucksharpDataSet3();
            this.entryTableAdapter1 = new bucksharp.bucksharpDataSet3TableAdapters.EntryTableAdapter();
            this.bucksharpDataSet2 = new bucksharp.bucksharpDataSet2();
            this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entryTableAdapter = new bucksharp.bucksharpDataSet2TableAdapters.EntryTableAdapter();
            this.categoryTableAdapter = new bucksharp.bucksharpDataSet4TableAdapters.CategoryTableAdapter();
            this.entryTableAdapter2 = new bucksharp.bucksharpDataSet4TableAdapters.EntryTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.currencyTableAdapter = new bucksharp.bucksharpDataSet4TableAdapters.currencyTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet1BindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet4BindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bucksharpDataSetBindingSource
            // 
            this.bucksharpDataSetBindingSource.DataSource = this.bucksharpDataSet;
            this.bucksharpDataSetBindingSource.Position = 0;
            // 
            // bucksharpDataSet
            // 
            this.bucksharpDataSet.DataSetName = "bucksharpDataSet";
            this.bucksharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bucksharpDataSetBindingSource1
            // 
            this.bucksharpDataSetBindingSource1.DataSource = this.bucksharpDataSet;
            this.bucksharpDataSetBindingSource1.Position = 0;
            // 
            // bucksharpDataSet1
            // 
            this.bucksharpDataSet1.DataSetName = "bucksharpDataSet1";
            this.bucksharpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bucksharpDataSet1BindingSource
            // 
            this.bucksharpDataSet1BindingSource.DataSource = this.bucksharpDataSet1;
            this.bucksharpDataSet1BindingSource.Position = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 821F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1029, 290);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(211, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 284);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.currencyBack);
            this.panel8.Controls.Add(this.currencyConvert);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.currencyTo);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.currencyReult);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.currencyFrom);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.currencyAmount);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(815, 284);
            this.panel8.TabIndex = 3;
            // 
            // currencyBack
            // 
            this.currencyBack.Location = new System.Drawing.Point(279, 211);
            this.currencyBack.Name = "currencyBack";
            this.currencyBack.Size = new System.Drawing.Size(117, 45);
            this.currencyBack.TabIndex = 9;
            this.currencyBack.Text = "Back";
            this.currencyBack.UseVisualStyleBackColor = true;
            this.currencyBack.Click += new System.EventHandler(this.currencyBack_Click);
            // 
            // currencyConvert
            // 
            this.currencyConvert.Location = new System.Drawing.Point(445, 211);
            this.currencyConvert.Name = "currencyConvert";
            this.currencyConvert.Size = new System.Drawing.Size(117, 45);
            this.currencyConvert.TabIndex = 8;
            this.currencyConvert.Text = "convert";
            this.currencyConvert.UseVisualStyleBackColor = true;
            this.currencyConvert.Click += new System.EventHandler(this.currencyConvert_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "to";
            // 
            // currencyTo
            // 
            this.currencyTo.DataSource = this.currencyBindingSource1;
            this.currencyTo.DisplayMember = "name";
            this.currencyTo.FormattingEnabled = true;
            this.currencyTo.Location = new System.Drawing.Point(392, 36);
            this.currencyTo.Name = "currencyTo";
            this.currencyTo.Size = new System.Drawing.Size(145, 108);
            this.currencyTo.TabIndex = 6;
            this.currencyTo.ValueMember = "code";
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataMember = "currency";
            this.currencyBindingSource1.DataSource = this.bucksharpDataSet4;
            // 
            // bucksharpDataSet4
            // 
            this.bucksharpDataSet4.DataSetName = "bucksharpDataSet4";
            this.bucksharpDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Result";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // currencyReult
            // 
            this.currencyReult.Enabled = false;
            this.currencyReult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyReult.Location = new System.Drawing.Point(367, 174);
            this.currencyReult.Name = "currencyReult";
            this.currencyReult.Size = new System.Drawing.Size(100, 26);
            this.currencyReult.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "from";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // currencyFrom
            // 
            this.currencyFrom.DataSource = this.currencyBindingSource;
            this.currencyFrom.DisplayMember = "name";
            this.currencyFrom.FormattingEnabled = true;
            this.currencyFrom.Location = new System.Drawing.Point(159, 36);
            this.currencyFrom.Name = "currencyFrom";
            this.currencyFrom.Size = new System.Drawing.Size(149, 108);
            this.currencyFrom.TabIndex = 2;
            this.currencyFrom.ValueMember = "code";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.bucksharpDataSet4BindingSource;
            // 
            // bucksharpDataSet4BindingSource
            // 
            this.bucksharpDataSet4BindingSource.DataSource = this.bucksharpDataSet4;
            this.bucksharpDataSet4BindingSource.Position = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(543, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "amount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // currencyAmount
            // 
            this.currencyAmount.Location = new System.Drawing.Point(614, 36);
            this.currencyAmount.Name = "currencyAmount";
            this.currencyAmount.Size = new System.Drawing.Size(100, 20);
            this.currencyAmount.TabIndex = 0;
            this.currencyAmount.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.saveEntryButton);
            this.panel6.Controls.Add(this.categoryInput);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.dateInput);
            this.panel6.Controls.Add(this.typeLabel);
            this.panel6.Controls.Add(this.typeInput);
            this.panel6.Controls.Add(this.amountlabel);
            this.panel6.Controls.Add(this.amountInput);
            this.panel6.Controls.Add(this.descriptionLabel);
            this.panel6.Controls.Add(this.descriptionInput);
            this.panel6.Controls.Add(this.titleLabel);
            this.panel6.Controls.Add(this.titleInput);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(815, 284);
            this.panel6.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Category";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 48);
            this.button4.TabIndex = 14;
            this.button4.Text = "back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 46);
            this.label7.TabIndex = 13;
            this.label7.Text = "create Entry";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.Location = new System.Drawing.Point(402, 220);
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.Size = new System.Drawing.Size(120, 48);
            this.saveEntryButton.TabIndex = 12;
            this.saveEntryButton.Text = "Save";
            this.saveEntryButton.UseVisualStyleBackColor = true;
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // categoryInput
            // 
            this.categoryInput.DataSource = this.categoryBindingSource;
            this.categoryInput.DisplayMember = "name";
            this.categoryInput.FormattingEnabled = true;
            this.categoryInput.Location = new System.Drawing.Point(614, 119);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(120, 95);
            this.categoryInput.TabIndex = 10;
            this.categoryInput.ValueMember = "id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.bucksharpDataSet4BindingSource;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date";
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(193, 119);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(136, 20);
            this.dateInput.TabIndex = 8;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(342, 118);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type";
            // 
            // typeInput
            // 
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "IN",
            "OUT"});
            this.typeInput.Location = new System.Drawing.Point(402, 118);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(100, 30);
            this.typeInput.TabIndex = 6;
            this.typeInput.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Location = new System.Drawing.Point(543, 72);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(42, 13);
            this.amountlabel.TabIndex = 5;
            this.amountlabel.Text = "amount";
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(614, 69);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(100, 20);
            this.amountInput.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(332, 73);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(402, 69);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(100, 20);
            this.descriptionInput.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(127, 73);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // titleInput
            // 
            this.titleInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.titleInput.Location = new System.Drawing.Point(193, 70);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(100, 20);
            this.titleInput.TabIndex = 0;
            this.titleInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 284);
            this.panel2.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(57, 38);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(364, 203);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "TOTAL:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "OUT:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "IN:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = " ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.saveCat);
            this.panel7.Controls.Add(this.backCat);
            this.panel7.Controls.Add(this.catcolorInput);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.catnameInput);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(815, 284);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // saveCat
            // 
            this.saveCat.Location = new System.Drawing.Point(427, 211);
            this.saveCat.Name = "saveCat";
            this.saveCat.Size = new System.Drawing.Size(118, 45);
            this.saveCat.TabIndex = 7;
            this.saveCat.Text = "Save";
            this.saveCat.UseVisualStyleBackColor = true;
            this.saveCat.Click += new System.EventHandler(this.button5_Click);
            // 
            // backCat
            // 
            this.backCat.Location = new System.Drawing.Point(278, 211);
            this.backCat.Name = "backCat";
            this.backCat.Size = new System.Drawing.Size(118, 45);
            this.backCat.TabIndex = 6;
            this.backCat.Text = "Back";
            this.backCat.UseVisualStyleBackColor = true;
            this.backCat.Click += new System.EventHandler(this.button6_Click);
            // 
            // catcolorInput
            // 
            this.catcolorInput.FormattingEnabled = true;
            this.catcolorInput.Items.AddRange(new object[] {
            "#15b68c",
            "#4cf25d",
            "#28613f",
            "#3b09b1",
            "#780c81",
            "#29422f",
            "#4f3b43",
            "#c8b5ac",
            "#1f2446",
            "#0a4ff6",
            "#76d37f",
            "#0fbb1d",
            "#a65b9a",
            "#cc9b4b",
            "#eeb651",
            "#86cdea",
            "#b28cec",
            "#7f476c",
            "#aafad1",
            "#a35b88",
            "#0a7b3d",
            "#4b7090",
            "#9d44f0",
            "#f8d5c9",
            "#1c7496",
            "#6c11a6",
            "#feec6a",
            "#50ac81",
            "#d56f2b",
            "#86062b",
            "#48e521",
            "#a40cbc",
            "#a3ff2a",
            "#f4cfa0",
            "#88cd32",
            "#ff7817",
            "#4e3a1a",
            "#12375e",
            "#9175b5",
            "#584595",
            "#c612b3",
            "#7a77c8",
            "#2f0941",
            "#fa519d",
            "#d08731",
            "#f8bbf9",
            "#1e710b",
            "#b026fa",
            "#30d3b4",
            "#9d0607",
            "#1b2770",
            "#9d7eee",
            "#65f674",
            "#736100",
            "#b3cbcf",
            "#c59b7d",
            "#cf8221",
            "#ae6f55",
            "#da591b",
            "#e5b25d",
            "#322384",
            "#076b18",
            "#d52831",
            "#3f453b",
            "#566715",
            "#4f9179",
            "#ff53bf",
            "#f19f12",
            "#f574fc",
            "#d31ac1",
            "#bb95fe",
            "#41ae05",
            "#272005",
            "#a0eeff",
            "#2bc317",
            "#6124b4",
            "#f46ac8",
            "#c0bdc6",
            "#934940",
            "#feb092",
            "#858c73",
            "#5da4a5",
            "#5b6f9a",
            "#bde9dc",
            "#350164",
            "#51eccd",
            "#2da717",
            "#ec96d4",
            "#9ff7de",
            "#311e79",
            "#aaceee",
            "#d122df",
            "#6d3b09",
            "#1c5447",
            "#0e79d4",
            "#2ca3a2",
            "#2cff82",
            "#71b248",
            "#8be951",
            "#b4171c",
            "#cfd2c9",
            "#7b9de6",
            "#e11d69",
            "#244d10",
            "#30a1a6",
            "#517a84",
            "#b8fc91",
            "#8c738d",
            "#6fce3b",
            "#c31c1a",
            "#c4bf6a",
            "#e50a35",
            "#36fab4",
            "#8763bd",
            "#b8bbb3",
            "#803f69",
            "#660bfe",
            "#1a6100",
            "#64cd89",
            "#baebca",
            "#5f0d49",
            "#154157",
            "#d7b24d",
            "#678d68",
            "#094485",
            "#d1dfc1",
            "#687b5f",
            "#3cb4f8",
            "#e4a32d",
            "#d1689f",
            "#683488",
            "#674fa9",
            "#e2c8d3",
            "#7d27dd",
            "#273034",
            "#fdd635",
            "#6a89d4",
            "#b93d25",
            "#559ae5",
            "#753108",
            "#fd9d32",
            "#b50182",
            "#9a4d7f",
            "#9d2195",
            "#4c62db",
            "#b9745f",
            "#9453ef",
            "#0ec5b7",
            "#86c228",
            "#229d8b",
            "#72967c",
            "#0fe455",
            "#51f5aa",
            "#72406c",
            "#b1a88d",
            "#d05b57",
            "#f87298",
            "#e74b77",
            "#2666b1",
            "#53a770",
            "#feb1c0",
            "#c782da",
            "#fc8180",
            "#a9347c",
            "#14d9e8",
            "#7484d9",
            "#4df195",
            "#8e91c3",
            "#e039b4",
            "#b1559b",
            "#da8d46",
            "#353b2c",
            "#5bd342",
            "#5a02ae",
            "#7f6162",
            "#95ad35",
            "#f1e8ff",
            "#93c7fb",
            "#58b869",
            "#ecc353",
            "#3fa923",
            "#c78b5d",
            "#0d9484",
            "#106fdb",
            "#e40fcd",
            "#9ba59a",
            "#087d3c",
            "#470a45",
            "#1e76cc",
            "#0faecb",
            "#a20712",
            "#d61243",
            "#72ee8b",
            "#d40399",
            "#72b24d",
            "#126810",
            "#6722dd",
            "#02d23c",
            "#00cb01",
            "#29882a",
            "#334615",
            "#771209",
            "#d54c7e",
            "#32d6a8",
            "#b4a45d",
            "#250282",
            "#f6e5ac",
            "#afcadd",
            "#294e65",
            "#0478ec",
            "#9aaad8",
            "#8c850f",
            "#888de7",
            "#15259d",
            "#27d180",
            "#e16c77",
            "#7a3815",
            "#d33bfe",
            "#458cee",
            "#793dab",
            "#30c47a",
            "#458b53",
            "#191ef9",
            "#c7b684",
            "#6afd81",
            "#625a79",
            "#432445",
            "#75e1d0",
            "#d5da77",
            "#d9e50a",
            "#939275",
            "#5748eb",
            "#9b553f",
            "#8f65a2",
            "#9bffcf",
            "#eefb8a",
            "#31b11d",
            "#03bb95",
            "#b7fa94",
            "#e78a2f",
            "#8c47b2",
            "#21b7e0",
            "#a2c426",
            "#aa23c9",
            "#7b798d",
            "#27bd9d",
            "#ee8821",
            "#bb441c",
            "#37311a",
            "#aac216",
            "#0a81fa",
            "#7c5dea",
            "#e87654",
            "#2121cb",
            "#c99630",
            "#505fc2",
            "#215704",
            "#32c1fd",
            "#5b7d04",
            "#7e01cd",
            "#d6a3fa",
            "#95fea4",
            "#3b6276",
            "#806a9c",
            "#3b3ce6",
            "#f450b4",
            "#277300",
            "#7f5621",
            "#21b9d5",
            "#c17a4c",
            "#5fdb66",
            "#ffab38",
            "#e37dc6",
            "#91c5ea",
            "#985ee6",
            "#e8ad47",
            "#756817",
            "#f67c9a",
            "#b4c7ae",
            "#d278f9",
            "#c26d54",
            "#146e9b",
            "#0cc758",
            "#1bb6a9",
            "#23f0de",
            "#b1895e",
            "#22ecc1",
            "#0bdb7f",
            "#832681",
            "#45e37c",
            "#dcb99b",
            "#5d60eb",
            "#2a340a",
            "#5420f6",
            "#eab0c9",
            "#252517",
            "#b35895",
            "#4b8cf8",
            "#cffb7d",
            "#77d009"});
            this.catcolorInput.Location = new System.Drawing.Point(345, 95);
            this.catcolorInput.Name = "catcolorInput";
            this.catcolorInput.Size = new System.Drawing.Size(120, 95);
            this.catcolorInput.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "name";
            // 
            // catnameInput
            // 
            this.catnameInput.Location = new System.Drawing.Point(345, 39);
            this.catnameInput.Name = "catnameInput";
            this.catnameInput.Size = new System.Drawing.Size(100, 20);
            this.catnameInput.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.convert, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.80769F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.19231F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 274);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "view categories";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // convert
            // 
            this.convert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convert.Location = new System.Drawing.Point(3, 199);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(194, 72);
            this.convert.TabIndex = 3;
            this.convert.Text = "Convert Currencies";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 223);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1029, 223);
            this.panel5.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.categoryBindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1029, 223);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.bucksharpDataSet4BindingSource;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 223);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.description,
            this.title,
            this.amount,
            this.type,
            this.date,
            this.category_id});
            this.dataGridView1.DataSource = this.entryBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1029, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "description";
            this.description.Name = "description";
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.Name = "title";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "amount";
            this.amount.Name = "amount";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.Name = "type";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // category_id
            // 
            this.category_id.DataPropertyName = "category_id";
            this.category_id.HeaderText = "category_id";
            this.category_id.Name = "category_id";
            // 
            // entryBindingSource2
            // 
            this.entryBindingSource2.DataMember = "Entry";
            this.entryBindingSource2.DataSource = this.bucksharpDataSet4BindingSource;
            // 
            // bucksharpDataSet4BindingSource1
            // 
            this.bucksharpDataSet4BindingSource1.DataSource = this.bucksharpDataSet4;
            this.bucksharpDataSet4BindingSource1.Position = 0;
            // 
            // entryBindingSource1
            // 
            this.entryBindingSource1.DataMember = "Entry";
            this.entryBindingSource1.DataSource = this.bucksharpDataSet3;
            // 
            // bucksharpDataSet3
            // 
            this.bucksharpDataSet3.DataSetName = "bucksharpDataSet3";
            this.bucksharpDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryTableAdapter1
            // 
            this.entryTableAdapter1.ClearBeforeFill = true;
            // 
            // bucksharpDataSet2
            // 
            this.bucksharpDataSet2.DataSetName = "bucksharpDataSet2";
            this.bucksharpDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entryBindingSource
            // 
            this.entryBindingSource.DataMember = "Entry";
            this.entryBindingSource.DataSource = this.bucksharpDataSet2;
            // 
            // entryTableAdapter
            // 
            this.entryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // entryTableAdapter2
            // 
            this.entryTableAdapter2.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(40, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(229, 38);
            this.label16.TabIndex = 8;
            this.label16.Text = "Create Category";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "buckSharp";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet1BindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet4BindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bucksharpDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.BindingSource bucksharpDataSetBindingSource;
        private bucksharpDataSet bucksharpDataSet;
        private System.Windows.Forms.BindingSource bucksharpDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bucksharpDataSet1BindingSource;
        private bucksharpDataSet1 bucksharpDataSet1;
        private bucksharpDataSet2 bucksharpDataSet2;
        private System.Windows.Forms.BindingSource entryBindingSource;
        private bucksharpDataSet2TableAdapters.EntryTableAdapter entryTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private bucksharpDataSet3 bucksharpDataSet3;
        private System.Windows.Forms.BindingSource entryBindingSource1;
        private bucksharpDataSet3TableAdapters.EntryTableAdapter entryTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bucksharpDataSet4BindingSource;
        private bucksharpDataSet4 bucksharpDataSet4;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private bucksharpDataSet4TableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource entryBindingSource2;
        private bucksharpDataSet4TableAdapters.EntryTableAdapter entryTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_id;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Chart chart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.ListBox typeInput;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button saveEntryButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox categoryInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox catnameInput;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox catcolorInput;
        private System.Windows.Forms.Button saveCat;
        private System.Windows.Forms.Button backCat;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox currencyFrom;
        private System.Windows.Forms.BindingSource bucksharpDataSet4BindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox currencyAmount;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private bucksharpDataSet4TableAdapters.currencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox currencyTo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox currencyReult;
        private System.Windows.Forms.Button currencyBack;
        private System.Windows.Forms.Button currencyConvert;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.Label label16;
    }
}

