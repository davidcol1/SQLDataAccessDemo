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
      this.SuspendLayout();
      // 
      // peopleFoundListbox
      // 
      this.peopleFoundListbox.FormattingEnabled = true;
      this.peopleFoundListbox.ItemHeight = 25;
      this.peopleFoundListbox.Location = new System.Drawing.Point(12, 156);
      this.peopleFoundListbox.Name = "peopleFoundListbox";
      this.peopleFoundListbox.Size = new System.Drawing.Size(291, 329);
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
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1600, 865);
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
  }
}

