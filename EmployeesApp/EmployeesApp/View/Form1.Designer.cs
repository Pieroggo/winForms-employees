namespace EmployeesApp.View
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dateTimeBox = new System.Windows.Forms.DateTimePicker();
            this.permanentContractButton = new System.Windows.Forms.RadioButton();
            this.fixedTermContractButton = new System.Windows.Forms.RadioButton();
            this.mandateContractButton = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.employeeBox = new System.Windows.Forms.ListBox();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.salaryBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_surname = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_surname)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBox.Location = new System.Drawing.Point(129, 92);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(111, 20);
            this.dateTimeBox.TabIndex = 0;
            this.dateTimeBox.ValueChanged += new System.EventHandler(this.dateChanged);
            // 
            // permanentContractButton
            // 
            this.permanentContractButton.AutoSize = true;
            this.permanentContractButton.Location = new System.Drawing.Point(129, 188);
            this.permanentContractButton.Name = "permanentContractButton";
            this.permanentContractButton.Size = new System.Drawing.Size(124, 17);
            this.permanentContractButton.TabIndex = 1;
            this.permanentContractButton.TabStop = true;
            this.permanentContractButton.Text = "na czas nieokreślony";
            this.permanentContractButton.UseVisualStyleBackColor = true;
            this.permanentContractButton.Click += new System.EventHandler(this.contractChanged);
            // 
            // fixedTermContractButton
            // 
            this.fixedTermContractButton.AutoSize = true;
            this.fixedTermContractButton.Location = new System.Drawing.Point(129, 222);
            this.fixedTermContractButton.Name = "fixedTermContractButton";
            this.fixedTermContractButton.Size = new System.Drawing.Size(110, 17);
            this.fixedTermContractButton.TabIndex = 2;
            this.fixedTermContractButton.TabStop = true;
            this.fixedTermContractButton.Text = "na czas określony";
            this.fixedTermContractButton.UseVisualStyleBackColor = true;
            this.fixedTermContractButton.Click += new System.EventHandler(this.contractChanged);
            // 
            // mandateContractButton
            // 
            this.mandateContractButton.AutoSize = true;
            this.mandateContractButton.Location = new System.Drawing.Point(129, 259);
            this.mandateContractButton.Name = "mandateContractButton";
            this.mandateContractButton.Size = new System.Drawing.Size(101, 17);
            this.mandateContractButton.TabIndex = 3;
            this.mandateContractButton.TabStop = true;
            this.mandateContractButton.Text = "umowa zlecenie";
            this.mandateContractButton.UseVisualStyleBackColor = true;
            this.mandateContractButton.Click += new System.EventHandler(this.contractChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(129, 40);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(111, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.Click += new System.EventHandler(this.chosenNameBox);
            this.nameBox.TextChanged += new System.EventHandler(this.nameChanged);
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.inputValidation);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(129, 66);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(111, 20);
            this.surnameBox.TabIndex = 5;
            this.surnameBox.Click += new System.EventHandler(this.chosenSurnameBox);
            this.surnameBox.TextChanged += new System.EventHandler(this.nameChanged);
            this.surnameBox.Validating += new System.ComponentModel.CancelEventHandler(this.inputValidation);
            // 
            // employeeBox
            // 
            this.employeeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(274, 23);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(522, 420);
            this.employeeBox.TabIndex = 6;
            this.employeeBox.SelectedIndexChanged += new System.EventHandler(this.getEmployeeFromList);
            // 
            // positionBox
            // 
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Items.AddRange(new object[] {
            "Junior Developer",
            "Mid Developer",
            "Senior Developer",
            "Project Manager",
            "Tester"});
            this.positionBox.Location = new System.Drawing.Point(129, 145);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(111, 21);
            this.positionBox.TabIndex = 7;
            this.positionBox.Text = "Junior Developer";
            this.positionBox.SelectedIndexChanged += new System.EventHandler(this.positionChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(64, 340);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 391);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveToFile);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(193, 391);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Wczytaj";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadFromFile);
            // 
            // salaryBox
            // 
            this.salaryBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.salaryBox.Location = new System.Drawing.Point(129, 119);
            this.salaryBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.salaryBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(111, 20);
            this.salaryBox.TabIndex = 12;
            this.salaryBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryBox.ValueChanged += new System.EventHandler(this.salaryChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Imię:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data Urodzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pensja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stanowisko:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rodzaj umowy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dane pracownika:";
            // 
            // errorProvider_name
            // 
            this.errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_surname
            // 
            this.errorProvider_surname.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.mandateContractButton);
            this.Controls.Add(this.fixedTermContractButton);
            this.Controls.Add(this.permanentContractButton);
            this.Controls.Add(this.dateTimeBox);
            this.Name = "Form1";
            this.Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_surname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeBox;
        private System.Windows.Forms.RadioButton permanentContractButton;
        private System.Windows.Forms.RadioButton fixedTermContractButton;
        private System.Windows.Forms.RadioButton mandateContractButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.ListBox employeeBox;
        private System.Windows.Forms.ComboBox positionBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown salaryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider_name;
        private System.Windows.Forms.ErrorProvider errorProvider_surname;
    }
}

