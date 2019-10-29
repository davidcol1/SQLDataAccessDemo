namespace FormUI
{
  partial class Dashboard
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
      this.peopleFoundListbox = new System.Windows.Forms.ListBox();
      this.lastNameText = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.searchButton1 = new System.Windows.Forms.Button();
      this.firstNameInsLabel = new System.Windows.Forms.Label();
      this.firstNameInsText = new System.Windows.Forms.TextBox();
      this.lastNameInsLabel = new System.Windows.Forms.Label();
      this.lastNameInsText = new System.Windows.Forms.TextBox();
      this.emailAddressInsLabel = new System.Windows.Forms.Label();
      this.emailAddressInsText = new System.Windows.Forms.TextBox();
      this.phoneNumberInsLabel = new System.Windows.Forms.Label();
      this.phoneNumberInsText = new System.Windows.Forms.TextBox();
      this.insertRecordButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // peopleFoundListbox
      // 
      this.peopleFoundListbox.FormattingEnabled = true;
      this.peopleFoundListbox.ItemHeight = 25;
      this.peopleFoundListbox.Location = new System.Drawing.Point(12, 156);
      this.peopleFoundListbox.Name = "peopleFoundListbox";
      this.peopleFoundListbox.Size = new System.Drawing.Size(566, 154);
      this.peopleFoundListbox.TabIndex = 0;
      // 
      // lastNameText
      // 
      this.lastNameText.Location = new System.Drawing.Point(133, 35);
      this.lastNameText.Name = "lastNameText";
      this.lastNameText.Size = new System.Drawing.Size(170, 31);
      this.lastNameText.TabIndex = 1;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Location = new System.Drawing.Point(12, 38);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
      this.lastNameLabel.TabIndex = 2;
      this.lastNameLabel.Text = "Last Name";
      // 
      // searchButton1
      // 
      this.searchButton1.Location = new System.Drawing.Point(87, 86);
      this.searchButton1.Name = "searchButton1";
      this.searchButton1.Size = new System.Drawing.Size(130, 46);
      this.searchButton1.TabIndex = 3;
      this.searchButton1.Text = "Search";
      this.searchButton1.UseVisualStyleBackColor = true;
      this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
      // 
      // firstNameInsLabel
      // 
      this.firstNameInsLabel.AutoSize = true;
      this.firstNameInsLabel.Location = new System.Drawing.Point(12, 347);
      this.firstNameInsLabel.Name = "firstNameInsLabel";
      this.firstNameInsLabel.Size = new System.Drawing.Size(116, 25);
      this.firstNameInsLabel.TabIndex = 5;
      this.firstNameInsLabel.Text = "First Name";
      // 
      // firstNameInsText
      // 
      this.firstNameInsText.Location = new System.Drawing.Point(172, 347);
      this.firstNameInsText.Name = "firstNameInsText";
      this.firstNameInsText.Size = new System.Drawing.Size(170, 31);
      this.firstNameInsText.TabIndex = 4;
      // 
      // lastNameInsLabel
      // 
      this.lastNameInsLabel.AutoSize = true;
      this.lastNameInsLabel.Location = new System.Drawing.Point(12, 384);
      this.lastNameInsLabel.Name = "lastNameInsLabel";
      this.lastNameInsLabel.Size = new System.Drawing.Size(115, 25);
      this.lastNameInsLabel.TabIndex = 7;
      this.lastNameInsLabel.Text = "Last Name";
      // 
      // lastNameInsText
      // 
      this.lastNameInsText.Location = new System.Drawing.Point(172, 384);
      this.lastNameInsText.Name = "lastNameInsText";
      this.lastNameInsText.Size = new System.Drawing.Size(170, 31);
      this.lastNameInsText.TabIndex = 6;
      // 
      // emailAddressInsLabel
      // 
      this.emailAddressInsLabel.AutoSize = true;
      this.emailAddressInsLabel.Location = new System.Drawing.Point(12, 421);
      this.emailAddressInsLabel.Name = "emailAddressInsLabel";
      this.emailAddressInsLabel.Size = new System.Drawing.Size(150, 25);
      this.emailAddressInsLabel.TabIndex = 9;
      this.emailAddressInsLabel.Text = "Email Address";
      // 
      // emailAddressInsText
      // 
      this.emailAddressInsText.Location = new System.Drawing.Point(172, 421);
      this.emailAddressInsText.Name = "emailAddressInsText";
      this.emailAddressInsText.Size = new System.Drawing.Size(170, 31);
      this.emailAddressInsText.TabIndex = 8;
      // 
      // phoneNumberInsLabel
      // 
      this.phoneNumberInsLabel.AutoSize = true;
      this.phoneNumberInsLabel.Location = new System.Drawing.Point(12, 458);
      this.phoneNumberInsLabel.Name = "phoneNumberInsLabel";
      this.phoneNumberInsLabel.Size = new System.Drawing.Size(155, 25);
      this.phoneNumberInsLabel.TabIndex = 11;
      this.phoneNumberInsLabel.Text = "Phone Number";
      // 
      // phoneNumberInsText
      // 
      this.phoneNumberInsText.Location = new System.Drawing.Point(172, 458);
      this.phoneNumberInsText.Name = "phoneNumberInsText";
      this.phoneNumberInsText.Size = new System.Drawing.Size(170, 31);
      this.phoneNumberInsText.TabIndex = 10;
      // 
      // insertRecordButton
      // 
      this.insertRecordButton.Location = new System.Drawing.Point(103, 511);
      this.insertRecordButton.Name = "insertRecordButton";
      this.insertRecordButton.Size = new System.Drawing.Size(130, 46);
      this.insertRecordButton.TabIndex = 12;
      this.insertRecordButton.Text = "Insert";
      this.insertRecordButton.UseVisualStyleBackColor = true;
      this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(630, 569);
      this.Controls.Add(this.insertRecordButton);
      this.Controls.Add(this.phoneNumberInsLabel);
      this.Controls.Add(this.phoneNumberInsText);
      this.Controls.Add(this.emailAddressInsLabel);
      this.Controls.Add(this.emailAddressInsText);
      this.Controls.Add(this.lastNameInsLabel);
      this.Controls.Add(this.lastNameInsText);
      this.Controls.Add(this.firstNameInsLabel);
      this.Controls.Add(this.firstNameInsText);
      this.Controls.Add(this.searchButton1);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.lastNameText);
      this.Controls.Add(this.peopleFoundListbox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Dashboard";
      this.Text = "SQL Data Access Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox peopleFoundListbox;
    private System.Windows.Forms.TextBox lastNameText;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.Button searchButton1;
    private System.Windows.Forms.Label firstNameInsLabel;
    private System.Windows.Forms.TextBox firstNameInsText;
    private System.Windows.Forms.Label lastNameInsLabel;
    private System.Windows.Forms.TextBox lastNameInsText;
    private System.Windows.Forms.Label emailAddressInsLabel;
    private System.Windows.Forms.TextBox emailAddressInsText;
    private System.Windows.Forms.Label phoneNumberInsLabel;
    private System.Windows.Forms.TextBox phoneNumberInsText;
    private System.Windows.Forms.Button insertRecordButton;
  }
}

